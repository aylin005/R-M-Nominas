using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using static MAD_AAVD_proyecto.Globals;

namespace MAD_AAVD_proyecto
{
    public partial class FormNominaGenerar : Form
    {
        public FormNominaGenerar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GREPORTE_DTP_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormNominaGenerar_Load(object sender, EventArgs e)
        {
            GREPORTE_DGV_table.DefaultCellStyle.ForeColor = Color.White;
            GREPORTE_DGV_table.DefaultCellStyle.BackColor = Color.Black;
            GREPORTE_DGV_table.Rows.Clear();
            GREPORTE_DGV_table.Columns["salaryResult"].DefaultCellStyle.Format = "C"; // Formato de moneda

            //Agregar columna cantidad a depositar ?
        }

        private void GREPORTE_BTN_generate_Click(object sender, EventArgs e)
        {
            GREPORTE_DGV_table.Rows.Clear();
            DateTime fecha = GREPORTE_DTP_date.Value; //Revisar valor que trae

            int days = DateTime.DaysInMonth(fecha.Year, fecha.Month);
            DateTime auxFin = new DateTime(fecha.Year, fecha.Month, days);
            DateTime mesAnterior = GREPORTE_DTP_date.Value.AddMonths(-1);

            if (DB_SQLServer)
            {
                var linkDB = new EnlaceDB();
                bool ok = linkDB.GenerarNomina(fecha);
                if (ok)
                {
                    MessageBox.Show("Se generó la nómina correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataTable reporteNomina = linkDB.GetReporteNomina(fecha);

                    GREPORTE_DGV_table.Rows.Clear();

                    // Añade cada fila del DataTable al DGV
                    foreach (DataRow row in reporteNomina.Rows)
                    {
                        // Crea una nueva fila en el DataGridView
                        int rowIndex = GREPORTE_DGV_table.Rows.Add();

                        //Se especifica bien qué columna de la tabla SQL se asigna a qué columna de DGV
                        GREPORTE_DGV_table.Rows[rowIndex].Cells["numEmploy"].Value = row["empleado"];
                        GREPORTE_DGV_table.Rows[rowIndex].Cells["nameEmploy"].Value = row["Nombres"];
                        GREPORTE_DGV_table.Rows[rowIndex].Cells["date"].Value = row["fechaPago"];
                        GREPORTE_DGV_table.Rows[rowIndex].Cells["salaryResult"].Value = row["total"];
                        GREPORTE_DGV_table.Rows[rowIndex].Cells["bank"].Value = row["nombreBanco"];
                        GREPORTE_DGV_table.Rows[rowIndex].Cells["accountNum"].Value = row["noCuenta"];

                    }

                    //Generar CSV
                    string projectPath = AppDomain.CurrentDomain.BaseDirectory;
                    string folderPath = Path.Combine(projectPath, "Nóminas");

                    // Crear la carpeta si no existe
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    string filePath = Path.Combine(folderPath, $"Nómina_{auxFin:yyyy-MM-dd}.csv");

                    WriteDataTableToCsv(reporteNomina, filePath);

                    MessageBox.Show($"Se generó con éxito el archivo CSV. Archivo guardado en: {filePath}");
                }
                    

            }
            else 
            if(DB_Cassandra)
            {
                var linkCassandra = new EnlaceCassandra();
                //Revisar si se generó el recibo del mes anterior
                string[] primaryKey = { "year", "month" }; string[] columnas = primaryKey;
                string[] pkValues = { mesAnterior.Year.ToString(), (mesAnterior.Month).ToString() };
            
                // Obtener la lista de nóminas generadas
                List<RegistroNominas> nominasGeneradas = linkCassandra.Get_All<RegistroNominas>(columnas, "REGISTRO_NOMINAS");

                // Verificar si la lista contiene datos
                if (nominasGeneradas != null && nominasGeneradas.Count > 0)
                {
                    // Ordenar por año y mes en orden descendente
                    RegistroNominas ultimaNomina = nominasGeneradas
                        .OrderByDescending(n => n.year)
                        .ThenByDescending(n => n.month)
                        .FirstOrDefault();

                    if (ultimaNomina != null)
                    {
                        // Convertir el año y mes a un objeto DateTime
                        DateTime fechaUltimaNomina = new DateTime(ultimaNomina.year, ultimaNomina.month, 1);

                        // Comparar con la nueva fecha seleccionada
                        DateTime nuevaFecha = GREPORTE_DTP_date.Value;
                        DateTime primerDiaNuevoMes = new DateTime(nuevaFecha.Year, nuevaFecha.Month, 1);

                        // Verificar si la nueva fecha es el mes siguiente de la última nómina
                        DateTime mesSiguiente = fechaUltimaNomina.AddMonths(1);
                        if (primerDiaNuevoMes == mesSiguiente) //Se puede generar la nomina
                        {
                            generarNomina(fecha, auxFin);
                        }
                        else
                        {
                            MessageBox.Show("Primero genere la nómina del mes anterior", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una última nómina válida.");
                    }
                }
                else // no hay nominas registradas
                {
                    generarNomina(fecha, auxFin);
                }
            }
        }
        //EnlaceCassandra.desconectar();

        private void generarNomina(DateTime fecha, DateTime auxFin)
        {
            var linkCassandra = new EnlaceCassandra();
            //Obtener empleados activos en ese mes
            List<Empleados> empleados = linkCassandra.FilterEmpleados(fecha, false, false, "", "");
            //Obtener conceptos fijos
            List<Conceptos> conceptos = linkCassandra.GetConceptos(true);

            List<DepartamentosSueldos> auxDepSueldos = new List<DepartamentosSueldos>(); //Lista aux para la tabla de departamentosSueldos
            //Por cada empleado se va a ir sumando en ese departamento en esa fecha

            List<GenerarNomina> generarNomina = new List<GenerarNomina>();//Para tabla que se muestra en pantalla

            //Insertar en recibos (Por cada uno)
            foreach (Empleados emp in empleados)
            {
                foreach (Conceptos concepto in conceptos)
                {
                    linkCassandra.InsertRecibo(emp, concepto, fecha, true);
                }
                //*Obtener lista de percepciones y lista de deducciones*
                //Traer lista de todos sus conceptos
                List<Conceptos> conceptosRecibo = linkCassandra.getConceptosRecibo(emp.noEmpleado, fecha);
                //Dividir la lista en lista de percepciones y lista de deducciones
                List<Conceptos> percepciones = conceptosRecibo.Where(c => c.percepcion).ToList();//Usando LINQ de .NET Language Integrated Query
                List<Conceptos> deducciones = conceptosRecibo.Where(c => !c.percepcion).ToList();

                //Obtener días trabajados
                int daysInMonth = DateTime.DaysInMonth(fecha.Year, fecha.Month);
                //"FALTA" puede ser parte del nombre, por ejemplo: "FALTA INJUSTIFICADA"
                int faltas = deducciones.Count(d => d.nombreConcepto.IndexOf("FALTA", StringComparison.OrdinalIgnoreCase) >= 0);
                int diasTrabajados = daysInMonth - faltas;

                //Calcular total percepciones y total deducciones
                decimal totalPercepciones = percepciones.Sum(p => p.cantConcepto);
                decimal totalDeducciones = deducciones.Sum(d => d.cantConcepto);////
                //Agregar el SUELDO BURTO
                decimal sueldoBruto = emp.salarioDiario * diasTrabajados;
                //Calcular total final
                decimal total = sueldoBruto + totalPercepciones - totalDeducciones;
                //Calcular total con letra
                string totalConLetra = total.NumeroALetras();
                //Insertar todo a recibo (Agrega el sueldo Bruto como concepto y en la CK de SALARIO se encuentran todos los datos del recibo finalizado)
                linkCassandra.cerrarRecibo(emp, fecha, diasTrabajados, sueldoBruto, totalPercepciones, totalDeducciones, total, totalConLetra);
                //Insertar datos en el DGV
                string nombreCompleto = $"{emp.nombres} {emp.apPaterno} {emp.apMaterno}";
                
                //Se agrega a la lista para mostrar en la tabla
                GenerarNomina empAux = new GenerarNomina(emp.noEmpleado, nombreCompleto, auxFin.ToString("yyyy/MMM/dd"), total, emp.banco, emp.noCuenta.ToString());
                generarNomina.Add(empAux);
                GREPORTE_DGV_table.Rows.Add(emp.noEmpleado, nombreCompleto, auxFin.ToString("yyyy/MMM/dd"), total, emp.banco, emp.noCuenta.ToString());

                //Se agrega a la lista auxiliar
                DepartamentosSueldos aux = new DepartamentosSueldos(emp.departamento, fecha.Year, fecha.Month, sueldoBruto, total);
                auxDepSueldos.Add(aux);
            }
            //Mostrar datos en la tabla de la pantalla
            //GREPORTE_DGV_table.DataSource = generarNomina;

            MessageBox.Show("Nómina generada exitosamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Generar CSV
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.Combine(projectPath, "Nóminas");

            // Crear la carpeta si no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, $"Nómina_{auxFin:yyyy-MM-dd}.csv");

            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(generarNomina);
            }

            MessageBox.Show($"Se generó con éxito el archivo CSV. Archivo guardado en: {filePath}");
            //MessageBox.Show("Se generó con éxito el archivo CSV", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Guardar registro de la nomina generada
            string[] auxPrimaryKey = { "year", "month" }; string[] auxPkValues = { $"{fecha.Year}", $"{fecha.Month}" };
            string[] columns = { }; string[] values = { }; //Vacias porque no se necesitan
            linkCassandra.InsertFechaNomina(fecha);

            //Registrar reporte nómina
            // Agrupar por departamento, año y mes
            List<DepartamentosSueldos> finalReporteNomina = auxDepSueldos
                .GroupBy(d => new { d.nombreDepto, d.year, d.month })
                .Select(grupo => new DepartamentosSueldos
                {
                    nombreDepto = grupo.Key.nombreDepto,
                    year = grupo.Key.year,
                    month = grupo.Key.month,
                    sueldoBruto = grupo.Sum(x => x.sueldoBruto),
                    sueldoNeto = grupo.Sum(x => x.sueldoNeto)
                })
                .ToList();

            //Insertar tabla en cassandra
            linkCassandra.InserReporteNomina(finalReporteNomina);

            ///////HEADCOUNTER///////////
            List<Headcounter> headCounter = new List<Headcounter>();
            int year = fecha.Year; // Año de la fecha de referencia
            int month = fecha.Month; // Mes de la fecha de referencia

            // Agrupar empleados por departamento y puesto
            var agrupadosPorPuesto = empleados
                .GroupBy(emp => new { emp.departamento, emp.puesto })
                .Select(g => new
                {
                    Departamento = g.Key.departamento,
                    Puesto = g.Key.puesto,
                    Cantidad = g.Count()
                });

            // Agrupar empleados solo por departamento
            var agrupadosPorDepartamento = empleados
                .GroupBy(emp => emp.departamento)
                .Select(g => new
                {
                    Departamento = g.Key,
                    Cantidad = g.Count()
                });

            // Crear objetos Headcounter para departamento y puesto
            foreach (var grupo in agrupadosPorPuesto)
            {
                Headcounter hc = new Headcounter
                {
                    departamento = grupo.Departamento,
                    puesto = grupo.Puesto,
                    year = (short)year,
                    cantEmpMes = new Dictionary<short, short>
                    {
                        { (short)month, (short)grupo.Cantidad } // Cantidad por mes
                    }
                };

                headCounter.Add(hc);
            }

            // Crear objetos Headcounter para departamento (puesto = -1)
            foreach (var grupo in agrupadosPorDepartamento)
            {
                Headcounter hc = new Headcounter
                {
                    departamento = grupo.Departamento,
                    puesto = "-1", // Signfica que cuenta todo el departamento
                    year = (short)year,
                    cantEmpMes = new Dictionary<short, short>
                    {
                        { (short)month, (short)grupo.Cantidad } // Cantidad por mes
                    }
                };

                headCounter.Add(hc);
            }

            //Insertar en tabla headcounter
            linkCassandra.InsertHeadcounter(headCounter, GREPORTE_DTP_date.Value.Month);
        }

        static void WriteDataTableToCsv(DataTable table, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Escribir los encabezados de las columnas
                string[] columnNames = new string[table.Columns.Count];
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    columnNames[i] = table.Columns[i].ColumnName;
                }
                writer.WriteLine(string.Join(",", columnNames));

                // Escribir las filas
                foreach (DataRow row in table.Rows)
                {
                    string[] fields = new string[table.Columns.Count];
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        fields[i] = row[i]?.ToString().Replace(",", " "); // Manejar comas en los datos
                    }
                    writer.WriteLine(string.Join(",", fields));
                }
            }
        }
    }


    public static class ExtensionMethods
    {
        public static string NumeroALetras(this decimal numberAsString)
        {
            string dec;

            var entero = Convert.ToInt64(Math.Truncate(numberAsString));
            var decimales = Convert.ToInt32(Math.Round((numberAsString - entero) * 100, 2));
            if (decimales > 0)
            {
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" PESOS {decimales:0,0} /100";
            }
            //Código agregado por mí
            else
            {//r
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" PESOS {decimales:0,0} /100";
            }
            var res = NumeroALetras(Convert.ToDouble(entero)) + dec;
            return res;
        }


        private static string NumeroALetras(double value)
        {
            string num2Text; value = Math.Truncate(value);
            if (value == 0) num2Text = "CERO";
            else if (value == 1) num2Text = "UNO";
            else if (value == 2) num2Text = "DOS";
            else if (value == 3) num2Text = "TRES";
            else if (value == 4) num2Text = "CUATRO";
            else if (value == 5) num2Text = "CINCO";
            else if (value == 6) num2Text = "SEIS";
            else if (value == 7) num2Text = "SIETE";
            else if (value == 8) num2Text = "OCHO";
            else if (value == 9) num2Text = "NUEVE";
            else if (value == 10) num2Text = "DIEZ";
            else if (value == 11) num2Text = "ONCE";
            else if (value == 12) num2Text = "DOCE";
            else if (value == 13) num2Text = "TRECE";
            else if (value == 14) num2Text = "CATORCE";
            else if (value == 15) num2Text = "QUINCE";
            else if (value < 20) num2Text = "DIECI" + NumeroALetras(value - 10);
            else if (value == 20) num2Text = "VEINTE";
            else if (value < 30) num2Text = "VEINTI" + NumeroALetras(value - 20);
            else if (value == 30) num2Text = "TREINTA";
            else if (value == 40) num2Text = "CUARENTA";
            else if (value == 50) num2Text = "CINCUENTA";
            else if (value == 60) num2Text = "SESENTA";
            else if (value == 70) num2Text = "SETENTA";
            else if (value == 80) num2Text = "OCHENTA";
            else if (value == 90) num2Text = "NOVENTA";
            else if (value < 100) num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " Y " + NumeroALetras(value % 10);
            else if (value == 100) num2Text = "CIEN";
            else if (value < 200) num2Text = "CIENTO " + NumeroALetras(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) num2Text = NumeroALetras(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) num2Text = "QUINIENTOS";
            else if (value == 700) num2Text = "SETECIENTOS";
            else if (value == 900) num2Text = "NOVECIENTOS";
            else if (value < 1000) num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
            else if (value == 1000) num2Text = "MIL";
            else if (value < 2000) num2Text = "MIL " + NumeroALetras(value % 1000);
            else if (value < 1000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value % 1000);
                }
            }
            else if (value == 1000000)
            {
                num2Text = "UN MILLON";
            }
            else if (value < 2000000)
            {
                num2Text = "UN MILLON " + NumeroALetras(value % 1000000);
            }
            else if (value < 1000000000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
                }
            }
            else if (value == 1000000000000) num2Text = "UN BILLON";
            else if (value < 2000000000000) num2Text = "UN BILLON " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
                }
            }
            return num2Text;
        }   
    }
}

