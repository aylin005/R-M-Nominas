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
            NREPORTE_DGV_table.Rows.Add("Administracion", 2020, "Octubre", "$" + 290, "$" + 690); //ejemplo
            //recuperar las celdas 3 y 4 anteriores a la final para obtener la sumatoria
            int lastIndex = NREPORTE_DGV_table.Rows.Count - 1; //esto es por si agregas mas
            NREPORTE_DGV_table.Rows[lastIndex].DefaultCellStyle.ForeColor = Color.RoyalBlue;
            NREPORTE_DGV_table.Rows[lastIndex].Cells[3].Value = "$" +  0; //estas son para los totales
            NREPORTE_DGV_table.Rows[lastIndex].Cells[4].Value = "$" + 10;
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
