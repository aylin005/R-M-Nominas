using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD_AAVD_proyecto
{
    public partial class FormNominaReporte : Form
    {
        string[] meses = {
        "", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO",
        "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"
};
        public FormNominaReporte()
        {
            InitializeComponent();
            Reload();
        }
        void Reload()
        {
            NREPORTE_DGV_table.DefaultCellStyle.ForeColor = Color.White;
            NREPORTE_DGV_table.DefaultCellStyle.BackColor = Color.Black;


            var linkCassandra = new EnlaceCassandra();
            List<DepartamentosSueldos> aux = linkCassandra.GetReporteNomina(NREPORTE_DTP_date.Value.Year);
            // Calcular totales
            var totalSueldoBruto = aux.Sum(x => x.sueldoBruto);
            var totalSueldoNeto = aux.Sum(x => x.sueldoNeto);

            // Crear un nuevo registro con los totales
            DepartamentosSueldos totalRow = new DepartamentosSueldos
            {
                nombreDepto = "Total",
                //year = 0,
                //month = 0,
                sueldoBruto = totalSueldoBruto,
                sueldoNeto = totalSueldoNeto
            };

            //Añadir el registro de totales a la lista
            aux.Add(totalRow);

            //Asignar la lista actualizada al DataGridView
            // Limpiar las filas existentes
            NREPORTE_DGV_table.Rows.Clear();

            // Añadir filas desde la lista aux
            foreach (var item in aux)
            {
                NREPORTE_DGV_table.Rows.Add(
                    item.nombreDepto,
                    item.year,
                    meses[item.month],//Mes en letras
                    item.sueldoBruto,
                    item.sueldoNeto
                );
            }

            // Renglón total en negritas
            var lastRowIndex = NREPORTE_DGV_table.Rows.Count - 1;
            NREPORTE_DGV_table.Rows[lastRowIndex].DefaultCellStyle.Font = new Font(NREPORTE_DGV_table.Font, FontStyle.Bold);
            NREPORTE_DGV_table.Columns["baseSalary"].DefaultCellStyle.Format = "C"; // Formato de moneda
            NREPORTE_DGV_table.Columns["totalSalary"].DefaultCellStyle.Format = "C";
        }

        private void NReport_CB_OrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NREPORT_BTN_Filter_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void NREPORTE_DTP_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NREPORTE_DGV_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormNominaReporte_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
