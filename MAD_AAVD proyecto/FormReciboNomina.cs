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
            RECIBO_DGV_Percepciones.DefaultCellStyle.ForeColor = Color.Black; //por alguna razon me sale en blanco
            RECIBO_DGV_Percepciones.Rows.Add(001, "SALARIO", "12,600.00"); //ejemplo
            RECIBO_DGV_Percepciones.Rows.Add(002, "BONO DE ASISTENCIA", "$120.00"); //ejemplo
            //recuperar las celdas 3 y 4 anteriores a la final para obtener la sumatoria
            int lastIndex = RECIBO_DGV_Percepciones.Rows.Count - 1; //esto es por si agregas mas
            RECIBO_DGV_Percepciones.Rows[lastIndex].DefaultCellStyle.ForeColor = Color.RoyalBlue;
            RECIBO_DGV_Percepciones.Rows[lastIndex].Cells[2].Value = "$12,720.00"; //estas son para los totales

            RECIBO_DGV_Deducciones.DefaultCellStyle.ForeColor = Color.Black; //por alguna razon me sale en blanco
            RECIBO_DGV_Deducciones.Rows.Add(003, "FALTAS", "120.00"); //ejemplo
            //recuperar las celdas 3 y 4 anteriores a la final para obtener la sumatoria
            lastIndex = RECIBO_DGV_Deducciones.Rows.Count - 1; //esto es por si agregas mas
            RECIBO_DGV_Deducciones.Rows[lastIndex].DefaultCellStyle.ForeColor = Color.RoyalBlue;
            RECIBO_DGV_Deducciones.Rows[lastIndex].Cells[2].Value = "$120.00"; //estas son para los totales
            /////
            ///
            RECIBO_TXT_RazonSocial.Text = companyName;
            RECIBO_TXT_RegistroPatronal.Text = RP;
            RECIBO_TXT_RFC.Text = RFC;
            RECIBO_TXT_DomicilioFiscal.Text = DF;
            RECIBO_TXT_NoTel.Text = noTel;
            RECIBO_TXT_Email.Text = email;
        }

        private void GREPORTE_DTP_date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
