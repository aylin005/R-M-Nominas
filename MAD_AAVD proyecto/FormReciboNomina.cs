using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static MAD_AAVD_proyecto.Globals;

namespace MAD_AAVD_proyecto
{
    public partial class FormReciboNomina : Form
    {
        public FormReciboNomina()
        {
            InitializeComponent();
        }

        private void RECIBO_DGV_Percepciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   

        }

        private void FormReciboNomina_Load(object sender, EventArgs e)
        {
            //Carga datos de la empresa
            RECIBO_TXT_NombreEmpresa.Text = companyName;
            RECIBO_TXT_RegistroPatronal.Text = RP;
            RECIBO_TXT_RFC.Text = RFC;
            RECIBO_TXT_DomicilioFiscal.Text = DF;
            RECIBO_TXT_NoTel.Text = noTel;
            RECIBO_TXT_Email.Text = email;

            RECIBO_DGV_Percepciones.DefaultCellStyle.ForeColor = Color.White;
            RECIBO_DGV_Percepciones.DefaultCellStyle.BackColor = Color.Black;

            RECIBO_DGV_Deducciones.DefaultCellStyle.ForeColor = Color.White;
            RECIBO_DGV_Deducciones.DefaultCellStyle.BackColor = Color.Black;
            /////
            ///

        }

        private void getRecibo()
        {
            Clear();
            var linkCassandra = new EnlaceCassandra();

            //Obtener recibo
            string[] auxColumnas = { "idRecibo", "finPeriodo", "inicioPeriodo", "diasTrabajados", 
                "totalPercepciones","totalDeducciones","total", "totalLetra" };
            Recibos recibo = linkCassandra.BuscarRecibo(auxColumnas, activeUser, RECIBO_DTP_Fecha.Value);

            if (recibo != null)
            {
                loadRecibo(recibo);

                ////////Carga datos del empleado activo///
                //Obtener empleado activo
                string[] columnas = {"nombres", "apPaterno", "apMaterno", "nss", "curp", "rfc", "noEmpleado", "puesto", "departamento",
                "salarioDiario", "fechaIngreso"};
                Empleados emp = linkCassandra.LastPuesto2<Empleados>(columnas, activeUser.ToString(), RECIBO_DTP_Fecha.Value);

                if (emp != null)
                {
                    loadEmp(emp);
                }

                //CARGAR CONCEPTOS
                List<Conceptos> conceptos = linkCassandra.getConceptosRecibo(activeUser, RECIBO_DTP_Fecha.Value);
                //Dividir la lista en dos
                List<Conceptos> percepciones = conceptos.Where(c => c.percepcion).ToList();
                List<Conceptos> deducciones = conceptos.Where(c => !c.percepcion).ToList();

                //////////////AÑADIR CONCEPTOS//////////////////
                //PERCEPCIONES
                foreach (var item in percepciones)
                {
                    RECIBO_DGV_Percepciones.Rows.Add(
                        item.noConcepto,
                        item.nombreConcepto,
                        item.cantConcepto
                    );
                }
                //Agregar total percepciones
                RECIBO_DGV_Percepciones.Rows.Add(null,"TOTAL",recibo.totalPercepciones);
                // Renglón total en negritas
                var lastRowIndex = RECIBO_DGV_Percepciones.Rows.Count - 1;
                RECIBO_DGV_Percepciones.Rows[lastRowIndex].DefaultCellStyle.Font = new Font(RECIBO_DGV_Percepciones.Font, FontStyle.Bold);

                //DEDUCCIONES
                foreach(var item in deducciones)
                {
                    RECIBO_DGV_Deducciones.Rows.Add(
                        item.noConcepto,
                        item.nombreConcepto,
                        item.cantConcepto
                    );
                }
                //Agregar total percepciones
                RECIBO_DGV_Deducciones.Rows.Add(null, "TOTAL", recibo.totalDeducciones);
                // Renglón total en negritas
                lastRowIndex = RECIBO_DGV_Deducciones.Rows.Count - 1;
                RECIBO_DGV_Deducciones.Rows[lastRowIndex].DefaultCellStyle.Font = new Font(RECIBO_DGV_Deducciones.Font, FontStyle.Bold);

                //Formato dinero
                RECIBO_DGV_Percepciones.Columns["pImporte"].DefaultCellStyle.Format = "C";
                RECIBO_DGV_Deducciones.Columns["dImporte"].DefaultCellStyle.Format = "C";
            }
            else if(recibo == null)
            {
                MessageBox.Show("El recibo no se ha generado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadRecibo(Recibos recibo)
        {
            RECIBO_TB_IdRecibo.Text = recibo.idRecibo.ToString();
            RECIBO_TB_FechaPago.Text = recibo.finPeriodo.ToString();
            RECIBO_TB_PeriodoPago.Text = $"{recibo.inicioPeriodo} - {recibo.finPeriodo}";
            RECIBO_TB_DiasTrabajados.Text = recibo.diasTrabajados.ToString();
            RECIBO_TB_Total.Text = recibo.total.ToString("C");
            RECIBO_TB_TotalLetra.Text = recibo.totalLetra;
        }

        private void loadEmp(Empleados emp)
        {
            RECIBO_TB_NombreEmp.Text = $"{emp.nombres} {emp.apPaterno} {emp.apMaterno}";
            RECIBO_TB_Imss.Text = emp.nss;
            RECIBO_TB_Curp.Text = emp.curp;
            RECIBO_TB_Rfc.Text = emp.rfc;
            RECIBO_TB_NoEmp.Text = emp.noEmpleado.ToString();
            RECIBO_TB_Puesto.Text = emp.puesto;
            RECIBO_TB_Departamento.Text = emp.departamento;
            RECIBO_TB_SalarioDiario.Text = emp.salarioDiario.ToString("C");
            RECIBO_TB_FechaAlta.Text = emp.fechaIngreso.ToString();
        }
        private void GREPORTE_DTP_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RECIBO_BTN_Aplicar_Click(object sender, EventArgs e)
        {
            getRecibo();
        }

        private void Clear()
        {
            RECIBO_DGV_Percepciones.Rows.Clear();
            RECIBO_DGV_Deducciones.Rows.Clear();

            RECIBO_TB_IdRecibo.Text = "";
            RECIBO_TB_FechaPago.Text = "";
            RECIBO_TB_PeriodoPago.Text = "";
            RECIBO_TB_DiasTrabajados.Text = "";
            RECIBO_TB_Total.Text ="";
            RECIBO_TB_TotalLetra.Text = "";

            RECIBO_TB_NombreEmp.Text = "";
            RECIBO_TB_Imss.Text ="";
            RECIBO_TB_Curp.Text = "";
            RECIBO_TB_Rfc.Text = "";
            RECIBO_TB_NoEmp.Text = "";
            RECIBO_TB_Puesto.Text = "";
            RECIBO_TB_Departamento.Text = "";
            RECIBO_TB_SalarioDiario.Text = "";
            RECIBO_TB_FechaAlta.Text = "";
        }
    }

}
