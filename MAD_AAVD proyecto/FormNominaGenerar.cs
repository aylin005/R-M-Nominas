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
            GREPORTE_DGV_table.DefaultCellStyle.ForeColor = Color.Black; //por alguna razon me sale en blanco
            GREPORTE_DGV_table.Rows.Add(00123, "AYLIN CELESTE RODRÍGUEZ CAVAZOS", "01/Sep/2024", "$14,000.00", "Banorte", "01234456789"); //ejemplo
            GREPORTE_DGV_table.Rows.Add(00124, "ITZEL ANAHÍ PÉREZ MORALES", "01/Sep/2024", "$19,000.00", "Banregio", "0374865378");
            GREPORTE_DGV_table.Rows.Add(00125, "ELIUD ASAEL SÁNCHEZ MORALES", "01/Sep/2024", "$12,000.00", "Afirme", "0274658470");
            GREPORTE_DGV_table.Rows.Add(00126, "JOSÉ ARTURO RODRÍGUEZ CAVAZOS", "01/Sep/2024", "$21,000.00", "banorte", "3745345982");
        }
    }
}
