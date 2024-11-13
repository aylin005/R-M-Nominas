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


namespace MAD_AAVD_proyecto
{
    class EnlaceCassandra
    {
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;

        private static void conectar()
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

        private static void desconectar()
        {
            _cluster.Dispose();
        }

        public List<T> Get_All<T>(string[] columnas, string nombreTabla)
        {
            string query = "SELECT ";
            foreach (var columna in columnas)
            {
                query += columna + ", ";
            }
            query = query.Remove(query.Length - 2);
            query += " FROM " + nombreTabla + ";";
            conectar();

            IMapper mapper = new Mapper(_session);
            IEnumerable<T> table = mapper.Fetch<T>(query);

            desconectar();
            return table.ToList();
        }

        public void Insert(bool edit, string nombreTabla, string[] primaryKey , string[] pkValues, string[] columns, string[] values)//en values enviar strings entre ''
        {
            try
            {
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
                desconectar();
            }
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
            T row = mapper.Single<T>(query); //un solo resultado.
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
        public List<T> FilterDate<T>(string[] columnas, string nombreTabla, DateTime date)
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
            query += " FROM " + nombreTabla + " WHERE fechaInicio>= '" + date1 + "' AND fechaInicio < '" + date2 + "' ALLOW FILTERING;";
            conectar();

            IMapper mapper = new Mapper(_session);
            IEnumerable<T> table = mapper.Fetch<T>(query);

            desconectar();
            return table.ToList();
        }

        public List<Empleados> FilterEmpleados(DateTime date, bool withDep = false, string departamento = "", string puesto = "")
        {
            var finalList = new List<Empleados>(); // Tabla final del filtro
                                                   // Dia ultimo del mes seleccionado
            DateTime auxDate1 = new DateTime(date.Year, date.Month, 1);
            auxDate1 = auxDate1.AddMonths(1).AddDays(-1);

            // Convertir ambas fechas a string en el formato de Cassandra
            string date1 = auxDate1.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            // Ejecutamos primera consulta
            string query = $"SELECT noEmpleado FROM Empleados GROUP BY noEmpleado ALLOW FILTERING;";
            conectar();
            IMapper mapper = new Mapper(_session);

            IEnumerable<Empleados> tableEmpleados = mapper.Fetch<Empleados>(query);
            var empleados = tableEmpleados.ToList(); // Guarda la última fecha de inicio antes de la seleccionada por cada empleado

            if (!withDep)//Para tabla de empleados en la pantalla de empleados
            {
                // Bucle para realizar la segunda consulta para cada resultado de la primera consulta
                foreach (var registro in empleados)
                {
                    // Ejecutar la segunda consulta usando noEmpleado y fechaInicio máxima
                    query = $"SELECT noEmpleado, nombres, apPaterno, apMaterno, departamento, puesto, fechaInicio " +
                        $"FROM Empleados WHERE noEmpleado = {registro.noEmpleado} AND fechaInicio <= '{date1}' AND activo = TRUE LIMIT 1 ALLOW FILTERING;";

                    Empleados empleado = mapper.FirstOrDefault<Empleados>(query); // Devuelve null si no hay resultado

                    // Agregar el resultado a la lista final si se encontró un registro
                    if (empleado != null)
                    {
                        finalList.Add(empleado);
                    }
                }
            }
            else if(withDep)//para CB de empleados en la pantalla aplicar conceptos
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

            
            desconectar();
            return finalList; // Guarda el último puesto de cada empleado para la fecha seleccionada
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
            Empleados row = mapper.Single<Empleados>(query); //un solo resultado.
            desconectar();
            return row;
        }
    }
}
