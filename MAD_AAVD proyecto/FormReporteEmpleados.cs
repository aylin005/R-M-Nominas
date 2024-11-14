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

        private void FormEmployReport_Load(object sender, EventArgs e)
        {
            RGN_DGV_Reporte.DefaultCellStyle.ForeColor = Color.Black;

            var linkCassandra = new EnlaceCassandra();
            //COMBOBOX DEPARTAMENTOS
            string[] columnasDepto = { "noDepto", "nombreDpto" };
            List<Departamentos> listaDeptos = linkCassandra.Get_All<Departamentos>(columnasDepto, "DEPARTAMENTOS");
            CONCEPAPLICAR_CB_Departamentos.DataSource = listaDeptos;
            CONCEPAPLICAR_CB_Departamentos.DisplayMember = "nombreDpto";
            CONCEPAPLICAR_CB_Departamentos.ValueMember = "noDepto";

            CONCEPAPLICAR_CB_EmpDepto.DataSource = listaDeptos;
            CONCEPAPLICAR_CB_EmpDepto.DisplayMember = "nombreDpto";
            CONCEPAPLICAR_CB_EmpDepto.ValueMember = "noDepto";
        }


    }
}
