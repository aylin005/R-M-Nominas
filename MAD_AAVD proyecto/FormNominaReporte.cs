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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void UpdateTable()
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black; //por alguna razon me sale en blanco
            dataGridView1.Rows.Add("Administracion", 2020, "Octubre", "$" + 290, "$" + 690); //ejemplo
            //recuperar las celdas 3 y 4 anteriores a la final para obtener la sumatoria
            int lastIndex = dataGridView1.Rows.Count - 1; //esto es por si agregas mas
            dataGridView1.Rows[lastIndex].DefaultCellStyle.ForeColor = Color.RoyalBlue;
            dataGridView1.Rows[lastIndex].Cells[3].Value = "$" +  0; //estas son para los totales
            dataGridView1.Rows[lastIndex].Cells[4].Value = "$" + 10;
        }
    }
}
