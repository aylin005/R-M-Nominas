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
    public partial class FormPuestos : Form
    {
        public FormPuestos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPuestos_Load(object sender, EventArgs e)
        {
            ADMIN_DGV_Puestos.DefaultCellStyle.ForeColor = Color.Black; //por alguna razon me sale en blanco
            ADMIN_DGV_Puestos.Rows.Add(001, "Programador Junior","2.0"); //ejemplo
            ADMIN_DGV_Puestos.Rows.Add(002, "Programador Senior", "4.0");
            ADMIN_DGV_Puestos.Rows.Add(003, "Interno", "1.5");
            ADMIN_DGV_Puestos.Rows.Add(004, "Ayudante", "1.3");
        }
    }
}
