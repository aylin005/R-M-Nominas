using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Agregar columna cantidad a depositar ?
        }

        private void GREPORTE_BTN_generate_Click(object sender, EventArgs e)
        {
            GREPORTE_DGV_table.Rows.Clear();
            var linkCassandra = new EnlaceCassandra();
            //EnlaceCassandra.conectar();

            DateTime fecha = GREPORTE_DTP_date.Value; //Revisar valor que trae

            int days = DateTime.DaysInMonth(fecha.Year, fecha.Month);
            DateTime auxFin = new DateTime(fecha.Year, fecha.Month, days);

            //Revisar si se generó el recibo del mes anterior

            DateTime mesAnterior = GREPORTE_DTP_date.Value.AddMonths(-1);
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
        //EnlaceCassandra.desconectar();

        private void generarNomina(DateTime fecha, DateTime auxFin)
        {
            var linkCassandra = new EnlaceCassandra();
            //Obtener empleados activos en ese mes
            List<Empleados> empleados = linkCassandra.FilterEmpleados(fecha, false, false, "", "");
            //Obtener conceptos fijos
            List<Conceptos> conceptos = linkCassandra.GetConceptos(true);


            //Insertar en recibos (Por cada uno)
            foreach (Empleados emp in empleados)
            {
                foreach (Conceptos concepto in conceptos)
                {
                    linkCassandra.InsertRecibo(emp, concepto, fecha);
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
                GREPORTE_DGV_table.Rows.Add(emp.noEmpleado, nombreCompleto, auxFin.ToShortDateString(), total, emp.banco, emp.noCuenta);
            }
            MessageBox.Show("Nómina generada exitosamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Guardar registro de la nomina generada
            string[] auxPrimaryKey = { "year", "month" }; string[] auxPkValues = { $"{fecha.Year}", $"{fecha.Month}" };
            string[] columns = { }; string[] values = { }; //Vacias porque no se necesitan
            linkCassandra.InsertFechaNomina(fecha);
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
            {
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

