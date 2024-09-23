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
            RECIBO_DGV_Percepciones.Rows.Add(001, "SALARIO", "$" + 290); //ejemplo
            RECIBO_DGV_Percepciones.Rows.Add(001, "SALARIO", "$" + 200); //ejemplo
            //recuperar las celdas 3 y 4 anteriores a la final para obtener la sumatoria
            int lastIndex = RECIBO_DGV_Percepciones.Rows.Count - 1; //esto es por si agregas mas
            RECIBO_DGV_Percepciones.Rows[lastIndex].DefaultCellStyle.ForeColor = Color.RoyalBlue;
            RECIBO_DGV_Percepciones.Rows[lastIndex].Cells[2].Value = "$" + 0; //estas son para los totales
        }
    }
}
