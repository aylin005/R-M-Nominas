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
    public partial class FormEmployReport : Form
    {
        public FormEmployReport()
        {
            InitializeComponent();
        }

        private void HDCOUNTER_Title_Click(object sender, EventArgs e)
        {

        }

        private void HDCOUNTER_Filter_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void HDCOUNTER_DTP_Date_ValueChanged(object sender, EventArgs e)
        {
            //corregir hora
        }

        private void FormEmployReport_Load(object sender, EventArgs e)
        {
            ADMIN_DGV_ReporteGeneral.DefaultCellStyle.ForeColor = Color.Black; //por alguna razon me sale en blanco
            ADMIN_DGV_ReporteGeneral.Rows.Add("DESARROLLO", "Programador Junior", "AYLIN CELESTE RODRÍGUEZ CAVAZOS","14/ago/2024", "19", "$680.00"); //ejemplo
            ADMIN_DGV_ReporteGeneral.Rows.Add("DESARROLLO", "Programador Senior", "ITZEL ANAHÍ PÉRES MORALES", "28/sep/2021", "20", "$1,000.00");
            ADMIN_DGV_ReporteGeneral.Rows.Add("CONTABILIDAD", "Contador", "JOSÉ ARTURO RODRÍGUEZ CAVAZOS", "04/ene/2022", "24","$700.00");
            ADMIN_DGV_ReporteGeneral.Rows.Add("CONTABILIDAD", "Interno","ELIUD ASAEL SÁNCHEZ MORALES", "09/oct/2023", "19","$400.00");
        }
    }
}
