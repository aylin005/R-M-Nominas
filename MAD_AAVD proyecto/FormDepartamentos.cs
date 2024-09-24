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
    public partial class FormDepartamentos : Form
    {
        public FormDepartamentos()
        {
            InitializeComponent();
        }

        private void FormDepartamentos_Load(object sender, EventArgs e)
        {
            ADMIN_DGV_Departamentos.DefaultCellStyle.ForeColor = Color.Black; //por alguna razon me sale en blanco
            ADMIN_DGV_Departamentos.Rows.Add(001, "DESARROLLO"); //ejemplo
            ADMIN_DGV_Departamentos.Rows.Add(002, "CONTABILIDAD");
            ADMIN_DGV_Departamentos.Rows.Add(003, "IT");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
