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
    public partial class FormHeadCounter : Form
    {
        //private bool areAllElementsOn = true; //muestra todos los elementos
        //private bool isOneElementOn = false; //mejor chequemos esto despues
        //private bool isFilteredByDepYPlace = false; //se muestra departamento y puesto
        //private bool isFilteredByDep = false; //se muestra el departamento


        //**** M A N E J A D O R    D E   V E N T A N A
        public FormHeadCounter()
        {
            InitializeComponent();
            InitializeValues(false);
        }

        private void FormHeadCounter_Load(object sender, EventArgs e) 
        {
            HDCOUNTER_DGV_table.DefaultCellStyle.ForeColor = Color.Black; //por alguna razon me sale en blanco
            HDCOUNTER_DGV_table.Rows.Add(00123, "DESARROLLO", "Programador Junior", "30"); //ejemplo
            HDCOUNTER_DGV_table.Rows.Add(00124, "DESARROLLO", "Programador Senior", "10");
            HDCOUNTER_DGV_table.Rows.Add(00125, "CONTABILIDAD", "Contador", "JOSÉ ARTURO RODRÍGUEZ CAVAZOS", "24", "$700.00");
            HDCOUNTER_DGV_table.Rows.Add(00126, "CONTABILIDAD", "Interno", "ELIUD ASAEL SÁNCHEZ MORALES", "19", "$400.00");
        }
        private void HDCOUNTER_Title_Click(object sender, EventArgs e) { }

        private void HDCOUNTER_ComboBoxDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HDCOUNTER_ComboBoxDep.SelectedIndex == 0)
            {
                InitializeValues(false);
            }
            else
            {
                if (HDCOUNTER_ComboBoxDep.SelectedIndex == 1)
                {
                    InitializeValues(true);
                }
            }
        }

        private void HDCOUNTER_DTP_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HDCOUNTER_DGV_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //**** F U N C I O N E S   A U X I L I A R E S
        private void InitializeValues(bool status) //por default solo mostramos dos campos
        {
            jobPlace.Visible = status;
            employCountJob.Visible = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void HDCOUNTER_CB_orderOption_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
