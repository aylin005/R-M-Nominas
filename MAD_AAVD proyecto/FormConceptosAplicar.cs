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
        bool aplicarEmp = false;
        bool aplicarDepto = false;
        public List<Conceptos> listaConceptos;
        public FormConceptosAplicar()
        {
            InitializeComponent();
        }

        private void Reload()
        {
            
            var linkCassandra = new EnlaceCassandra();
            //COMBOBOX CONCEPTOS
            //listaConceptos = linkCassandra.GetConceptosNoFijos();
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

            aplicarDepto = true;
        }

        private void CONCEPAPLICAR_RB_Empleado_CheckedChanged(object sender, EventArgs e)
        {
            CONCEPAPLICAR_Panel_Empleado.Visible = true;
            CONCEPAPLICAR_Panel_Departamento.Visible = false;

            aplicarEmp = true;
        }

        private void FormConceptosAplicar_Load(object sender, EventArgs e)
        {
            CONCEPAPLICAR_Panel_Empleado.Visible = false;
            CONCEPAPLICAR_Panel_Departamento.Visible = false;

            Reload();
        }

        private void ActualizarCBEmp()
        {
            CONCEPAPLICAR_CB_Emp.Text = "";

            var linkCassandra = new EnlaceCassandra();

            List<Empleados> listaEmpleados = linkCassandra.FilterEmpleados(CONCEPAPLICAR_DTP_EmpFecha.Value, true, false, CONCEPAPLICAR_CB_EmpDepto.Text, CONCEPAPLICAR_CB_EmpPuesto.Text);
            CONCEPAPLICAR_CB_Emp.DataSource = listaEmpleados;
            CONCEPAPLICAR_CB_Emp.DisplayMember = "nombres";
            CONCEPAPLICAR_CB_Emp.ValueMember = "noEmpleado";

            CONCEPAPLICAR_CB_Emp.SelectedItem = 0;
        }
        private void CONCEPAPLICAR_CB_EmpPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCBEmp();
        }

        private void CONCEPAPLICAR_CB_EmpDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCBEmp();
        }

        private void CONCEPAPLICAR_CB_Emp_SelectedItemChanged(object sender, EventArgs e)
        {
            //Escribir numero de empleado
            CONCEPAPLICAR_TB_NoEmp.Text = CONCEPAPLICAR_CB_Emp.SelectedValue.ToString();
        }

        private void CONCEPAPLICAR_BTN_Registrar_Click(object sender, EventArgs e)
        {
            string noEmp = CONCEPAPLICAR_TB_NoEmp.Text;
            var linkCassandra = new EnlaceCassandra();

            if (aplicarEmp)
            {
                if (noEmp != null)
                {
                    CONCEPAPLICAR_LBL_Loading.Visible = true;
                    //1. Obtener Empleado en el puesto activo durante esa fecha
                    string[] columnas = { "noEmpleado", "nombres", "apPaterno", "apMaterno", "curp", "rfc", "nss", "banco", "noCuenta", "salarioDiario", "departamento", "puesto", "fechaIngreso" };
                    Empleados empleado = linkCassandra.LastPuesto2<Empleados>(columnas, noEmp, CONCEPAPLICAR_DTP_Fecha.Value);

                    aplicarCpEmp(empleado, CONCEPAPLICAR_CB_Conceptos.SelectedValue.ToString(), CONCEPAPLICAR_DTP_Fecha.Value);
                    CONCEPAPLICAR_LBL_Loading.Visible = false;
                }
                else
                {
                    MessageBox.Show("Seleccione un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (aplicarDepto)
            {
                CONCEPAPLICAR_LBL_Loading.Visible = true;
                //Obtener empleados
                //Por cada empleado llamar aplicarEmp
                List<Empleados> empleadosDepto = linkCassandra.FilterEmpByDepto(CONCEPAPLICAR_DTP_Fecha.Value, CONCEPAPLICAR_CB_Departamentos.Text);
                foreach(var empleado in empleadosDepto)
                {
                    aplicarCpEmp(empleado, CONCEPAPLICAR_CB_Conceptos.SelectedValue.ToString(), CONCEPAPLICAR_DTP_Fecha.Value);
                }
                CONCEPAPLICAR_LBL_Loading.Visible = false;
            }
        

        }

        private void aplicarCpEmp(Empleados empleado, string noConcepto, DateTime fecha)
        {
            var linkCassandra = new EnlaceCassandra();

            if (empleado != null)
            {
                //2. Se trae el concepto a insertar de la lista que ya se trajo para hacer más rápido el proceso
                Conceptos concepto = listaConceptos[int.Parse(noConcepto)-1]; //Índice del comboBox

                //3. Insertar en recibo
                linkCassandra.InsertRecibo(empleado, concepto, fecha);
            }
            
        }

        private void CONCEPAPLICAR_CB_Conceptos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
