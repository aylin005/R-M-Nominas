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
    public partial class FormNominaReporte : Form
    {
        public FormNominaReporte()
        {
            InitializeComponent();
            UpdateTable();
        }
        void UpdateTable()
        {
            NREPORTE_DGV_table.DefaultCellStyle.ForeColor = Color.Black; //por alguna razon me sale en blanco
            NREPORTE_DGV_table.Rows.Add("DESARROLLO", 2024, "Marzo", "$180,000.00", "200,000.00");
            NREPORTE_DGV_table.Rows.Add("DESARROLLO", 2024, "Abril", "$160,000.00", "180,000.00");
            NREPORTE_DGV_table.Rows.Add("DESARROLLO", 2024, "Mayo", "$200,000.00", "205,000.00");
            NREPORTE_DGV_table.Rows.Add("CONTABILIDAD", 2024, "Marzo", "$120,000.00", "135,000.00");
            //recuperar las celdas 3 y 4 anteriores a la final para obtener la sumatoria
            int lastIndex = NREPORTE_DGV_table.Rows.Count - 1; //esto es por si agregas mas
            NREPORTE_DGV_table.Rows[lastIndex].DefaultCellStyle.ForeColor = Color.RoyalBlue;
            NREPORTE_DGV_table.Rows[lastIndex].Cells[3].Value = "$660,000.00"; //estas son para los totales
            NREPORTE_DGV_table.Rows[lastIndex].Cells[4].Value = "$720,000.00";
        }

        private void NReport_CB_OrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NREPORT_BTN_Filter_Click(object sender, EventArgs e)
        {

        }

        private void NREPORTE_DTP_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NREPORTE_DGV_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormNominaReporte_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
