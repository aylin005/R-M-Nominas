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
            RGN_DGV_Reporte.DefaultCellStyle.ForeColor = Color.White;
            RGN_DGV_Reporte.DefaultCellStyle.BackColor = Color.Black;

            RGN_LBL_Loading.Visible = true;

            var linkCassandra = new EnlaceCassandra();
            //COMBOBOX DEPARTAMENTOS
            //string[] columnasDepto = { "noDepto", "nombreDpto" };
            //List<Departamentos> listaDeptos = linkCassandra.Get_All<Departamentos>(columnasDepto, "DEPARTAMENTOS");
            //RGN_CB_Departamento.DataSource = listaDeptos;
            //RGN_CB_Departamento.DisplayMember = "nombreDpto";
            //RGN_CB_Departamento.ValueMember = "noDepto";

            //RGN_CB_Departamento.DataSource = listaDeptos;
            //RGN_CB_Departamento.DisplayMember = "nombreDpto";
            //RGN_CB_Departamento.ValueMember = "noDepto";

            //RGN_DGV_Reporte.Columns.Add("Edad", "Edad");
            LoadTablaReporte();
            
            RGN_LBL_Loading.Visible = false;
        }

        private void HideUnnecessaryColumns()
        {
            RGN_DGV_Reporte.Columns["contrasena"].Visible = false;
            RGN_DGV_Reporte.Columns["fechaNacimiento"].Visible = false;
            RGN_DGV_Reporte.Columns["curp"].Visible = false;
            RGN_DGV_Reporte.Columns["rfc"].Visible = false;
            RGN_DGV_Reporte.Columns["nss"].Visible = false;
            RGN_DGV_Reporte.Columns["calleNo"].Visible = false;
            RGN_DGV_Reporte .Columns["colonia"].Visible = false;
            RGN_DGV_Reporte.Columns["municipio"].Visible = false;
            RGN_DGV_Reporte.Columns["estado"].Visible = false;
            RGN_DGV_Reporte.Columns["cp"].Visible = false;
            RGN_DGV_Reporte.Columns["colonia"].Visible = false;
            RGN_DGV_Reporte.Columns["banco"].Visible = false;
            RGN_DGV_Reporte.Columns["noCuenta"].Visible = false;
            RGN_DGV_Reporte.Columns["email"].Visible = false;
            RGN_DGV_Reporte.Columns["telefonos"].Visible = false;
            RGN_DGV_Reporte.Columns["fechaBaja"].Visible = false;
            RGN_DGV_Reporte.Columns["fechaInicio"].Visible = false;
        }

        private void RGN_BTN_Filtrar_Click(object sender, EventArgs e)
        {
            LoadTablaReporte();
        }

        private void LoadTablaReporte()
        {
            RGN_LBL_Loading.Visible = true;
            DateTime fechaFiltro = RGN_DTP_FiltroFecha.Value;
            //string departamento = RGN_CB_Departamento.Text;

            var linkCassandra = new EnlaceCassandra();

            //List<Empleados> tablaReporte = linkCassandra.FilterEmpleados(fechaFiltro, false, true, departamento);
            List<Empleados> tablaReporte = linkCassandra.FilterEmpleados(fechaFiltro, false);
            //RGN_DGV_Reporte.DataSource = tablaReporte;
            //HideUnnecessaryColumns();
            RGN_DGV_Reporte.Rows.Clear();
            foreach (var item in tablaReporte)
            {
                string formattedDateIngreso = new DateTime(item.fechaIngreso.Year, item.fechaIngreso.Month, item.fechaIngreso.Day)
                .ToString("dd/MMM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                //Obtener edad
                DateTime fechaNacimiento = new DateTime(item.fechaNacimiento.Year, item.fechaNacimiento.Month, item.fechaNacimiento.Day);
                int edad = DateTime.Now.Year - fechaNacimiento.Year;
                // Ajuste si no ha cumplido años este año
                if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
                    edad--;

                RGN_DGV_Reporte.Rows.Add(
                    item.noEmpleado,
                    $"{item.nombres} {item.apPaterno} {item.apMaterno}",
                    item.departamento,
                    item.puesto,
                    formattedDateIngreso,
                    item.salarioDiario,
                    edad
                    );
            }

            //foreach (DataGridViewRow row in RGN_DGV_Reporte.Rows)
            //{
            //    if (row.Cells["fechaNacimiento"].Value is Cassandra.LocalDate localDate)
            //    {
            //        // Convierte LocalDate a DateTime
            //        DateTime fechaNacimiento = new DateTime(localDate.Year, localDate.Month, localDate.Day);
            //        int edad = DateTime.Now.Year - fechaNacimiento.Year;

            //        // Ajuste si no ha cumplido años este año
            //        if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
            //            edad--;

            //        // Insertar la edad en la columna
            //        row.Cells["Edad"].Value = edad;
            //    }
            //}
            //RGN_DGV_Reporte.Columns["Edad"].DisplayIndex = RGN_DGV_Reporte.Columns.Count - 1; //Reacomoda columna Edad para aparecer al final
            RGN_LBL_Loading.Visible = false;
        }

        private void RGN_LBL_Loading_Click(object sender, EventArgs e)
        {

        }

        private void RGN_DTP_FiltroFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
