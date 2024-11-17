using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    //Calcular total percepciones y total deducciones
                    float totalPercepciones = percepciones.Sum(p => p.cuota);
                    float totalDeducciones= deducciones.Sum(d => d.cuota);
                    //Calcular total final
                    float total = totalPercepciones - totalDeducciones;
                    //Calcular total con letra
                    //Insertar todo a recibo
                }

                //Guardar registro de la nomina generada
                //Mostrar tabla con la info
            }
            else
            {
                MessageBox.Show("No se ha generado la nómina del mes anterior", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            linkCassandra.desconectar();
        }
    }
}
