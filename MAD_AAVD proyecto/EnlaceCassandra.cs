using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.Data.Common;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Security.Cryptography;
using System.Collections;
using static System.Collections.Specialized.BitVector32;
using Microsoft.Win32;
using static MAD_AAVD_proyecto.Globals;

namespace MAD_AAVD_proyecto
{
    class EnlaceCassandra
    {
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;

        public static void conectar()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();


            _cluster = Cluster.Builder()
                .AddContactPoint(_dbServer)
                .Build();

            _session = _cluster.Connect(_dbKeySpace);
        }


        private static void conectar2()
        {
            // Este solo es un ejemplo, NO hay que hacerlo de esta manera

            _cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .Build();

            _session = _cluster.Connect("keyspace3");
        }

        public static void desconectar()
        {
            _cluster.Dispose();
        }

        public bool Autenticar(string username, string password)
        {
            string query = $"SELECT noEmpleado, contrasena FROM EMPLEADOS WHERE noEmpleado = {username} AND contrasena = '{password}' ALLOW FILTERING;";
            conectar();
            IMapper mapper = new Mapper(_session);
            Empleados emp = mapper.FirstOrDefault<Empleados>(query); //un solo resultado.
            desconectar();
            if (emp != null)
            {
                activeUser = emp.noEmpleado;
                return true;
            }
            else
                return false;
            
        }

        public List<T> Get_All<T>(string[] columnas, string nombreTabla, bool withConnect = true)
        {
            string query = "SELECT ";
            foreach (var columna in columnas)
            {
                query += columna + ", ";
            }
            query = query.Remove(query.Length - 2);
            query += " FROM " + nombreTabla + ";";
            if(withConnect)
                conectar();

            IMapper mapper = new Mapper(_session);
            IEnumerable<T> table = mapper.Fetch<T>(query);

            if (withConnect)
                desconectar();
            return table.ToList();
        }

        public void Insert(bool edit, string nombreTabla, string[] primaryKey , string[] pkValues, string[] columns, string[] values, bool withConnect = true)//en values enviar strings entre ''
        {
            try
            {
                if(withConnect)
                    conectar();
                string query = "";
                
                //contar arreglos
                int cantColumns = 0;
                foreach(var column in columns)
                {
                    cantColumns++;
                }
                int cantPrimaryKey = 0;
                foreach (var column in primaryKey)
                {
                    cantPrimaryKey++;
                }

                if (!edit)
                {
                    query = $"SELECT MAX({primaryKey[0]}) FROM {nombreTabla};"; //seria la partition
                    IMapper mapper = new Mapper(_session);
                    // int? para que acepte null en caso de que no haya resultados
                    int? lastNumber = mapper.Single<int?>(query);
                    
                    // Asigna 0 si lastNumber es null
                    if (lastNumber == null)
                        lastNumber = 1;
                    else
                        lastNumber++;

                    query = $"INSERT INTO {nombreTabla}(";
                    foreach (var column in primaryKey)
                    {
                        query += column + ", ";
                    }
                    foreach (var column in columns)
                    {
                        query += column + ", ";
                    }
                    //eliminar el ultimo , 
                    query = query.Remove(query.Length - 2);
                    query = query + ") VALUES(" + lastNumber + ", ";

                    for (int i = 0; i < cantPrimaryKey - 1; i++)
                    {
                        query += pkValues[i + 1] + ", "; // se salta id porque ya se aplico
                    }
                    for (int i = 0; i < cantColumns; i++)
                    {
                        query += values[i] + ", "; // se salta id porque ya se aplico
                    }

                    query = query.Remove(query.Length - 2);
                    query += ") IF NOT EXISTS;"; 
                }
                else
                {
                    query = "UPDATE ";
                    query += nombreTabla + " SET ";
                    
                    for (int i = 0; i < cantColumns; i++)
                    {
                        query += columns[i] + " = " + values[i] + ", "; 
                    }
                    query = query.Remove(query.Length - 2); //quita el ultimo ,
                   
                    query += " WHERE ";
                    for (int i = 0; i < cantPrimaryKey; i++)
                    {
                        query += primaryKey[i] + " = " + pkValues[i] + " AND ";
                    }
                    query = query.Remove(query.Length - 5); //quita el ultimo AND
                    query += ";";
                }

                _session.Execute(query);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (withConnect)
                    desconectar();
            }
        }
       
        public void InsertFechaNomina (DateTime fecha, bool withConectar = true)
        {
            int days = DateTime.DaysInMonth(fecha.Year, fecha.Month);
            DateTime auxFin = new DateTime(fecha.Year, fecha.Month, days);

            string query = $"INSERT INTO REGISTRO_NOMINAS (year, month) VALUES ({auxFin.Year},{auxFin.Month})";

            try
            {
                if (withConectar)
                    conectar();
                IMapper mapper = new Mapper(_session);
                _session.Execute(query);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (withConectar)
                    desconectar();
            }
        }
        public void InsertRecibo(Empleados empleado, Conceptos concepto, DateTime fecha, bool mulpDias, bool withConectar = true)
        {
            DateTime auxInicio = new DateTime(fecha.Year, fecha.Month, 1);
            int days = DateTime.DaysInMonth(fecha.Year, fecha.Month);
            DateTime auxFin = new DateTime(fecha.Year, fecha.Month, days);

            string fechaConcepto = fecha.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string inicioPeriodo = auxInicio.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string finPeriodo = auxFin.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            //Concatenar nombre del empleado
            string nombreEmpleado = $"{empleado.nombres} {empleado.apPaterno} {empleado.apMaterno}";

            //Obtener cantidad del concepto
            decimal cantConcepto;

            if (concepto.cuota != 0)
            {
                cantConcepto = concepto.cuota;
            }
            else
            {//calcular porcentaje
                if (mulpDias)
                    cantConcepto = empleado.salarioDiario * (concepto.porcentaje) * days;
                else
                    cantConcepto = empleado.salarioDiario * (concepto.porcentaje);
            }
            
            try
            {
                if(withConectar)
                    conectar();
                string query = $"INSERT INTO RECIBOS (idRecibo, noEmpleado, mesRecibo, noConcepto, percepcion, nombreConcepto, cantConcepto, fechaConcepto, " +
                    $"nombreEmpleado, departamento, puesto, salarioDiario, banco, noCuenta, fechaAlta, inicioPeriodo, finPeriodo, nss, rfc, curp)";

                query += $"VALUES(uuid(), {empleado.noEmpleado}, '{finPeriodo}', {concepto.noConcepto}, {concepto.percepcion.ToString()},'{concepto.nombreConcepto}', {cantConcepto}, '{fechaConcepto}'," +
                    $" '{nombreEmpleado}', '{empleado.departamento}', '{empleado.puesto}', {empleado.salarioDiario}, '{empleado.banco}', '{empleado.noCuenta}', '{empleado.fechaIngreso}', " +
                    $"'{inicioPeriodo}', '{finPeriodo}', '{empleado.nss}', '{empleado.rfc}', '{empleado.curp}')";
                IMapper mapper = new Mapper(_session);

                _session.Execute(query);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //MessageBox.Show("Insertado exitosamente");
                if(withConectar)
                    desconectar();
            }
        }
        public List<Conceptos> getConceptosRecibo(int noEmp, DateTime fecha, bool withConectar = true)
        {
            //Traer todos los conceptos del recibo
            // Dia ultimo del mes seleccionado
            DateTime auxDate1 = new DateTime(fecha.Year, fecha.Month, 1);
            auxDate1 = auxDate1.AddMonths(1).AddDays(-1);

            // Convertir ambas fechas a string en el formato de Cassandra
            string date1 = auxDate1.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);


            string query = $"SELECT noConcepto, nombreConcepto, cantConcepto, percepcion FROM RECIBOS " +
                $"WHERE noEmpleado = {noEmp} AND mesRecibo = '{date1}';";
            if(withConectar)
                conectar();
            IMapper mapper = new Mapper(_session);
            IEnumerable<Conceptos> finalList = mapper.Fetch<Conceptos>(query);

            if(withConectar)
                desconectar();

            return finalList.ToList();
        }
        public void Delete(string nombreTabla, string [] columnas, int noID)
        {
            try
            {
                conectar();
                string query = $"DELETE FROM {nombreTabla} WHERE {columnas[0]} = {noID};";

                _session.Execute(query);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }
        public T Get_One<T>(string[] primaryKey, string[]columnas, string nombreTabla, string[] pkValues, short cantPK = 1) //template
        { //SELECT SIMPLE (solo con =)
            string query = "SELECT ";
            foreach (string column in primaryKey)
            {
                query += column + ", ";
            }
            foreach (string column in columnas)
            {
                query += column + ", ";
            }
            query = query.Remove(query.Length - 2); //quita el ultimo ,
            query += " FROM " + nombreTabla + " WHERE ";
            
            for (int i = 0; i < cantPK; i++)
            {
                query += primaryKey[i] + " = " + pkValues[i] + " AND ";
            }
            query = query.Remove(query.Length - 5); //quita el ultimo ,
            query += ";";

            conectar();
            IMapper mapper = new Mapper(_session);
            T row = mapper.FirstOrDefault<T>(query); //un solo resultado.
            desconectar();
            return row;
        }

        public void EmpDarBaja(string fechaBaja, int noEmpleado, string fechaInicio, string departamento, string puesto, string salarioDiario)
        {
            string query = $"UPDATE EMPLEADOS SET fechaBaja = '{fechaBaja}', activo = FALSE " +
                $"WHERE noEmpleado = {noEmpleado} AND fechaInicio = '{fechaInicio}' AND departamento = '{departamento}'" +
                $" AND puesto = '{puesto}' AND salarioDiario = {salarioDiario};";
            try
            {
                conectar();
                _session.Execute(query);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }
        public Recibos BuscarRecibo(string[] columnas, int noEmp, DateTime date)
        {
            // Establecer el día en 1 para el mes actual
            DateTime auxDate1 = new DateTime(date.Year, date.Month, 1);

            // Aumentar un mes y establecer el día en 1 para el mes siguiente
            DateTime auxDate2 = auxDate1.AddMonths(1);

            // Convertir ambas fechas a string en el formato de Cassandra
            string date1 = auxDate1.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string date2 = auxDate2.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);


            string query = "SELECT ";
            foreach (var columna in columnas)
            {
                query += columna + ", ";
            }
            query = query.Remove(query.Length - 2);
            query += " FROM RECIBOS WHERE noEmpleado = " + noEmp + " AND mesRecibo>= '" + date1 + "' AND mesRecibo < '" + date2 + "' ALLOW FILTERING;";
            conectar();

            IMapper mapper = new Mapper(_session);
            Recibos recibo = mapper.FirstOrDefault<Recibos>(query);

            desconectar();
            return recibo;
        }

        public List<Empleados> FilterEmpleados(DateTime date, bool withPuesto = false, bool withDepto = false, string departamento = "", string puesto = "", bool withConectar =  true)
        {
            var finalList = new List<Empleados>(); // Tabla final del filtro
                                                   // Dia ultimo del mes seleccionado
            DateTime auxDate1 = new DateTime(date.Year, date.Month, 1);
            auxDate1 = auxDate1.AddMonths(1).AddDays(-1);

            // Convertir ambas fechas a string en el formato de Cassandra
            string date1 = auxDate1.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            // Ejecutamos primera consulta
            string query = $"SELECT noEmpleado FROM Empleados GROUP BY noEmpleado ALLOW FILTERING;";
            if(withConectar)
                conectar();
            IMapper mapper = new Mapper(_session);

            IEnumerable<Empleados> tableEmpleados = mapper.Fetch<Empleados>(query);
            var empleados = tableEmpleados.ToList(); // Guarda la última fecha de inicio antes de la seleccionada por cada empleado

            if (!withPuesto && !withDepto)//Para tabla de empleados en la pantalla de empleados
            {
                // Bucle para realizar la segunda consulta para cada resultado de la primera consulta
                foreach (var registro in empleados)
                {
                    // Ejecutar la segunda consulta usando noEmpleado y fechaInicio máxima
                    query = $"SELECT noEmpleado, nombres, apPaterno, apMaterno, departamento, puesto, fechaInicio, fechaIngreso, rfc, nss, curp, salarioDiario, banco, noCuenta, fechaNacimiento " +
                        $"FROM Empleados WHERE noEmpleado = {registro.noEmpleado} AND fechaInicio <= '{date1}' AND activo = TRUE LIMIT 1 ALLOW FILTERING;";

                    Empleados empleado = mapper.FirstOrDefault<Empleados>(query); // Devuelve null si no hay resultado

                    // Agregar el resultado a la lista final si se encontró un registro
                    if (empleado != null)
                    {
                        finalList.Add(empleado);
                    }
                }
            }
            else if(withPuesto)//para CB de empleados en la pantalla aplicar conceptos
            {
                foreach (var registro in empleados)
                {
                    // Ejecutar la segunda consulta usando noEmpleado y fechaInicio máxima
                    query = $"SELECT noEmpleado, nombres, apPaterno, apMaterno, departamento, puesto, fechaInicio " +
                        $"FROM Empleados WHERE noEmpleado = {registro.noEmpleado} AND fechaInicio <= '{date1}' AND departamento = '{departamento}' AND puesto = '{puesto}' " +
                        $"AND activo = TRUE LIMIT 1 ALLOW FILTERING;";

                    Empleados empleado = mapper.FirstOrDefault<Empleados>(query); // Devuelve null si no hay resultado

                    // Agregar el resultado a la lista final si se encontró un registro
                    if (empleado != null)
                    {
                        finalList.Add(empleado);
                    }
                }
            }
            else if(withDepto) //Para reporte general de nomina
            {
                foreach (var registro in empleados)
                {
                    // Ejecutar la segunda consulta usando noEmpleado y fechaInicio máxima
                    query = $"SELECT noEmpleado, nombres, apPaterno, apMaterno, departamento, puesto, fechaInicio, fechaIngreso, salarioDiario, fechaNacimiento " +
                        $"FROM Empleados WHERE noEmpleado = {registro.noEmpleado} AND fechaInicio <= '{date1}' AND departamento = '{departamento}' " +
                        $"AND activo = TRUE LIMIT 1 ALLOW FILTERING;";

                    Empleados empleado = mapper.FirstOrDefault<Empleados>(query); // Devuelve null si no hay resultado

                    // Agregar el resultado a la lista final si se encontró un registro
                    if (empleado != null)
                    {
                        finalList.Add(empleado);
                    }
                }
            }
            if(withConectar)
                desconectar();
            return finalList; // Guarda el último puesto de cada empleado para la fecha seleccionada
        }
        public bool cerrarRecibo(Empleados emp, DateTime fecha, int diasTrabajados, decimal sueldoBruto, 
            decimal totalP, decimal totalD, decimal total, string totalLetra, bool withConectar = true)
        {
            DateTime auxInicio = new DateTime(fecha.Year, fecha.Month, 1);
            int days = DateTime.DaysInMonth(fecha.Year, fecha.Month);
            DateTime auxFin = new DateTime(fecha.Year, fecha.Month, days);

            string fechaConcepto = fecha.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string inicioPeriodo = auxInicio.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string finPeriodo = auxFin.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            //Concatenar nombre del empleado
            string nombreEmpleado = $"{emp.nombres} {emp.apPaterno} {emp.apMaterno}";

            try
            {
                if (withConectar)
                    conectar();
                string query = $"INSERT INTO RECIBOS (idRecibo, noEmpleado, mesRecibo, noConcepto, percepcion, nombreConcepto, cantConcepto, fechaConcepto, " +
                    $"nombreEmpleado, departamento, puesto, salarioDiario, banco, noCuenta, fechaAlta, inicioPeriodo, finPeriodo, nss, rfc, curp" +
                    $",diasTrabajados, sueldoBruto, totalPercepciones, totalDeducciones, total, totalLetra, generado)";

                query += $"VALUES(uuid(), {emp.noEmpleado}, '{finPeriodo}', 0, TRUE, 'SALARIO', {sueldoBruto}, '{fechaConcepto}'," +
                    $" '{nombreEmpleado}', '{emp.departamento}', '{emp.puesto}', {emp.salarioDiario}, '{emp.banco}', '{emp.noCuenta}', '{emp.fechaIngreso}', " +
                    $"'{inicioPeriodo}', '{finPeriodo}', '{emp.nss}', '{emp.rfc}', '{emp.curp}', {diasTrabajados}, {sueldoBruto}, {totalP + sueldoBruto}, {totalD}," +
                    $"{total}, '{totalLetra}', TRUE)";
                IMapper mapper = new Mapper(_session);

                _session.Execute(query);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //MessageBox.Show("Insertado exitosamente");
                if (withConectar)
                    desconectar();
            }
            return false; 
        }
        public List<Empleados> FilterEmpByDepto (DateTime fecha, string departamento, bool withConnect = true)
        {
            // Dia ultimo del mes seleccionado
            DateTime auxDate1 = new DateTime(fecha.Year, fecha.Month, 1);
            auxDate1 = auxDate1.AddMonths(1).AddDays(-1);

            // Convertir ambas fechas a string en el formato de Cassandra
            string date1 = auxDate1.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            
            // Ejecutar la segunda consulta usando noEmpleado y fechaInicio máxima

            string query = $"SELECT noEmpleado, nombres, apPaterno, apMaterno, curp, rfc, nss, banco, noCuenta, salarioDiario, departamento, puesto, fechaIngreso " +
                $"FROM Empleados WHERE fechaInicio <= '{date1}' AND departamento = '{departamento}'" +
                $"AND activo = TRUE ALLOW FILTERING;";

            if (withConnect)
                conectar();
            IMapper mapper = new Mapper(_session);
            IEnumerable<Empleados> finalList = mapper.Fetch<Empleados>(query);

            if (withConnect)
                desconectar();
            return finalList.ToList(); // Guarda el último puesto de cada empleado para la fecha seleccionada
        }

        public List<Empleados> ObtenerUltimoPuestoPorFecha(string[] columnas, DateTime date)
        {
            DateTime auxDate1 = new DateTime(date.Year, date.Month, 1);
            string date1 = auxDate1.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            var linkCassandra = new EnlaceCassandra();
            string query = $"SELECT ";

            foreach (var column in columnas)
            {
                query += column + ", ";
            }
            query = query.Remove(query.Length - 2);
            query += $"FROM EMPLEADOS WHERE fechaInicio <= '{date1}' ALLOW FILTERING;";
            conectar();
            // Ejecutar la consulta
            IMapper mapper = new Mapper(_session);
            IEnumerable<Empleados> empleados = mapper.Fetch<Empleados>(query);

            // Agrupar por noEmpleado y tomar el primer registro de cada grupo (el más reciente)
            var ultimosPuestos = new List<Empleados>();
            foreach (var grupoEmpleado in empleados.GroupBy(e => e.noEmpleado))
            {
                var ultimoPuesto = grupoEmpleado
                    .OrderByDescending(e => e.fechaInicio) // Orden descendente por fechaInicio
                    .FirstOrDefault(); // Tomar el primer registro (último puesto)

                if (ultimoPuesto != null)
                    ultimosPuestos.Add(ultimoPuesto);
            }
            desconectar();
            return ultimosPuestos;
        }

        public Empleados LastPuesto<Empleados>(string[] columnas, string noEmpleado)
        {
            string query = "SELECT ";
            foreach (var columna in columnas)
            {
                query += columna + ", ";
            }
            query = query.Remove(query.Length - 2);
            query += $" FROM EMPLEADOS WHERE noEmpleado = {noEmpleado} ORDER BY fechaInicio DESC LIMIT 1";

            conectar();
            IMapper mapper = new Mapper(_session);
            Empleados row = mapper.FirstOrDefault<Empleados>(query); //un solo resultado.
            desconectar();
            return row;
        }

        public Empleados LastPuesto2<Empleados>(string[] columnas, string noEmpleado, DateTime date, bool withConnect = true) //Obtiene el puesto activo en cierta fecha
        { //REVISAR LO DE ACTIVO
            string date1 = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            string query = "SELECT ";
            foreach (var columna in columnas)
            {
                query += columna + ", ";
            }
            query = query.Remove(query.Length - 2);
            query += $" FROM EMPLEADOS WHERE noEmpleado = {noEmpleado} AND fechaInicio <= '{date1}' AND activo = TRUE ORDER BY fechaInicio DESC LIMIT 1 ALLOW FILTERING";

            if(withConnect)
                conectar();
            IMapper mapper = new Mapper(_session);
            Empleados row = mapper.FirstOrDefault<Empleados>(query); //un solo resultado.
            if (withConnect)
                desconectar();
            return row;
        }

        public List<Conceptos> GetConceptos(bool fijo = false, bool withConectar = true)
        {
            string query;
            if(!fijo)
                query = "SELECT noConcepto, nombreConcepto, cuota, porcentaje, percepcion, fijo FROM CONCEPTOS WHERE fijo = FALSE ALLOW FILTERING";
            else
                query = "SELECT noConcepto, nombreConcepto, cuota, porcentaje, percepcion, fijo FROM CONCEPTOS WHERE fijo = TRUE ALLOW FILTERING";

            if(withConectar)
                conectar();

            IMapper mapper = new Mapper(_session);
            IEnumerable<Conceptos> table = mapper.Fetch<Conceptos>(query);

            if(withConectar)
                desconectar();
            return table.ToList();

        }

        public void InserReporteNomina(List<DepartamentosSueldos> depSueldo)
        {
            try
            {
                conectar();
                foreach (DepartamentosSueldos depto in depSueldo)
                {
                    string query = $"INSERT INTO departamentos_sueldos (nombreDepto, year, month, sueldoBruto, sueldoNeto)" +
                      $" VALUES('{depto.nombreDepto}', {depto.year}, {depto.month}, {depto.sueldoBruto}, {depto.sueldoNeto});";
                    
                    _session.Execute(query);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public List<DepartamentosSueldos> GetReporteNomina(int year)
        {
            string query;
            query = $"SELECT nombreDepto, year, month, sueldoBruto, sueldoNeto FROM departamentos_sueldos WHERE year = {year};";
           

            conectar();

            IMapper mapper = new Mapper(_session);
            IEnumerable<DepartamentosSueldos> table = mapper.Fetch<DepartamentosSueldos>(query);

            desconectar();
            return table.ToList();

        }

        public void InsertHeadcounter(List<Headcounter> headcounter, int month)
        {
            try
            {
                conectar();
                foreach (Headcounter hc in headcounter)
                {
                    string query = "UPDATE HEADCOUNTER SET cantEmpMes = cantEmpMes + {"+ month + ":" + hc.cantEmpMes[(byte)month] + "} WHERE " +
                        $"departamento = '{hc.departamento}' AND puesto = '{hc.puesto}' AND year = {hc.year};";

                    _session.Execute(query);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public List<Headcounter> GetHeadcounter(DateTime fecha, string departamento)
        {
            string query;

            if(departamento != "TODOS") //Trae cierto departamento
                query = $"SELECT departamento, year, puesto, cantEmpMes FROM HEADCOUNTER " +
                    $"WHERE departamento = '{departamento}' AND year = {fecha.Year} ALLOW FILTERING;";
            else //Trae todos los departamentos
                query = "SELECT departamento, year, puesto, cantEmpMes FROM HEADCOUNTER " +
                    $"WHERE year = {fecha.Year} ALLOW FILTERING";


            conectar();

            IMapper mapper = new Mapper(_session);
            IEnumerable<Headcounter> table = mapper.Fetch<Headcounter>(query);

            desconectar();
            return table.ToList();
        }
    }
}
