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
            
            //Revisar si se generó el recibo del mes anterior
            DateTime mesAnterior = GREPORTE_DTP_date.Value.AddMonths(-1);
            string[] primaryKey = { "year", "month" }; string[] columnas = primaryKey;
            string[] pkValues = { mesAnterior.Year.ToString(), (mesAnterior.Month).ToString() };
            RegistroNominas nominaMesAnterior = linkCassandra.Get_One<RegistroNominas>(primaryKey, columnas, "REGISTRO_NOMINAS", pkValues,2);
            if(nominaMesAnterior != null )
            {
                //Obtener empleados activos en ese mes

                //Obtener conceptos fijos

                //Insertar en recibos (Por cada uno)
            }
            else
            {
                MessageBox.Show("No se ha generado la nómina del mes anterior", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            //Insertar conceptos fijos al recibo
            //Obtener lista de percepciones y lista de deducciones
            //Calcular total percepciones y total deducciones
            //Calcular total final
            //Calcular total con letra
            //Insertar todo a recibo
            //Mostrar tabla con la info
        }
    }
}
