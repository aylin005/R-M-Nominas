using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
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

            //Agregar columna cantidad a depositar ?
        }

        private void GREPORTE_BTN_generate_Click(object sender, EventArgs e)
        {
            var linkCassandra = new EnlaceCassandra();
            linkCassandra.conectar();

            //Revisar si se generó el recibo del mes anterior
            DateTime fecha = GREPORTE_DTP_date.Value; //Revisar valor que trae
            DateTime mesAnterior = GREPORTE_DTP_date.Value.AddMonths(-1);
            string[] primaryKey = { "year", "month" }; string[] columnas = primaryKey;
            string[] pkValues = { mesAnterior.Year.ToString(), (mesAnterior.Month).ToString() };
            RegistroNominas nominaMesAnterior = linkCassandra.Get_One<RegistroNominas>(primaryKey, columnas, "REGISTRO_NOMINAS", pkValues,2);
            if(nominaMesAnterior != null )
            {
                //Obtener empleados activos en ese mes
                List<Empleados> empleados = linkCassandra.FilterEmpleados(fecha, false, false, "", "", false);
                //Obtener conceptos fijos
                List<Conceptos> conceptos = linkCassandra.GetConceptos(true, false);
                

                //Insertar en recibos (Por cada uno)
                foreach( Empleados emp in empleados )
                {
                    foreach(Conceptos concepto in conceptos)
                    {
                        linkCassandra.InsertRecibo(emp, concepto, fecha, false);
                    }
                    //********REVISAR LO DE CONCEPTOS***********
                    //*Obtener lista de percepciones y lista de deducciones*
                    //Traer lista de todos sus conceptos
                    List<Conceptos> conceptosRecibo = linkCassandra.getConceptosRecibo(emp.noEmpleado, fecha, false);
                    //Dividir la lista en lista de percepciones y lista de deducciones
                    List<Conceptos> percepciones = conceptosRecibo.Where(c => c.percepcion).ToList();//Usando LINQ de .NET Language Integrated Query
                    List<Conceptos> deducciones = conceptosRecibo.Where(c => !c.percepcion).ToList();

                    //Obtener días trabajados
                    int daysInMonth = DateTime.DaysInMonth(fecha.Year, fecha.Month);
                    //"FALTA" puede ser parte del nombre, por ejemplo: "FALTA INJUSTIFICADA"
                    int faltas = deducciones.Count(d => d.nombreConcepto.IndexOf("FALTA", StringComparison.OrdinalIgnoreCase) >= 0);
                    int diasTrabajados = daysInMonth - faltas;

                    //Calcular total percepciones y total deducciones
                    decimal totalPercepciones = percepciones.Sum(p => p.cuota);
                    decimal totalDeducciones= deducciones.Sum(d => d.cuota);
                    //Agregar el SUELDO BURTO
                    decimal sueldoBruto = emp.salarioDiario * diasTrabajados;
                    //Calcular total final
                    decimal total = sueldoBruto + totalPercepciones - totalDeducciones;
                    //Calcular total con letra
                    string totalConLetra = NumeroALetras(total);
                    //Insertar todo a recibo
                    //Insertar datos en el DGV
                }

                //Guardar registro de la nomina generada
            }
            else
            {
                MessageBox.Show("No se ha generado la nómina del mes anterior", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            linkCassandra.desconectar();
        }


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
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
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
}
