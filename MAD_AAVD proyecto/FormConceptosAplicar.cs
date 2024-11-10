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

        private void Reload()
        {
            
            var linkCassandra = new EnlaceCassandra();
            //COMBOBOX CONCEPTOS
            string[] columnasConcepto = { "noConcepto", "nombreConcepto" };
            List<Conceptos> listaConceptos = linkCassandra.Get_All<Conceptos>(columnasConcepto, "CONCEPTOS");
            CONCEPAPLICAR_CB_Conceptos.DataSource = listaConceptos;
            CONCEPAPLICAR_CB_Conceptos.DisplayMember = "nombreConcepto";
            CONCEPAPLICAR_CB_Conceptos.ValueMember = "noConcepto";

            //COMBOBOX DEPARTAMENTOS
            string[] columnasDepto = { "noDepto", "nombreDpto" };
            List<Departamentos> listaDeptos = linkCassandra.Get_All<Departamentos>(columnasDepto, "DEPARTAMENTOS");
            CONCEPAPLICAR_CB_Departamentos.DataSource = listaDeptos;
            CONCEPAPLICAR_CB_Departamentos.DisplayMember = "nombreDpto";
            CONCEPAPLICAR_CB_Departamentos.ValueMember = "noDepto";

            CONCEPAPLICAR_CB_EmpDepto.DataSource = listaDeptos;
            CONCEPAPLICAR_CB_EmpDepto.DisplayMember = "nombreDpto";
            CONCEPAPLICAR_CB_EmpDepto.ValueMember = "noDepto";

            //COMBOBOX PUESTOS
            string[] columnasPuestos = { "noPuesto", "nombrePuesto" };
            List<Puestos> listaPuestos = linkCassandra.Get_All<Puestos>(columnasPuestos, "PUESTOS");
            CONCEPAPLICAR_CB_EmpPuesto.DataSource = listaPuestos;
            CONCEPAPLICAR_CB_EmpPuesto.DisplayMember = "nombrePuesto";
            CONCEPAPLICAR_CB_EmpPuesto.ValueMember = "noPuesto";

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

            Reload();
        }
    }
}
