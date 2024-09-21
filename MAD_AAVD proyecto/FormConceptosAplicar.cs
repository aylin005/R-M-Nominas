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
    public partial class FormConceptosAplicar : Form
    {
        public FormConceptosAplicar()
        {
            InitializeComponent();
        }

        private void CONCEPAPLICAR_RB_Departamento_CheckedChanged(object sender, EventArgs e)
        {
            CONCEPAPLICAR_Panel_Departamento.Visible = true;
            CONCEPAPLICAR_Panel_Empleado.Visible = false;
        }

        private void CONCEPAPLICAR_RB_Empleado_CheckedChanged(object sender, EventArgs e)
        {
            CONCEPAPLICAR_Panel_Empleado.Visible = true;
            CONCEPAPLICAR_Panel_Departamento.Visible = false;
        }

        private void FormConceptosAplicar_Load(object sender, EventArgs e)
        {
            CONCEPAPLICAR_Panel_Empleado.Visible = false;
            CONCEPAPLICAR_Panel_Departamento.Visible = false;
        }
    }
}
