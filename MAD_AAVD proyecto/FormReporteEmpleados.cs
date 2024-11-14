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
            RGN_CB_Departamento.DataSource = listaDeptos;
            RGN_CB_Departamento.DisplayMember = "nombreDpto";
            RGN_CB_Departamento.ValueMember = "noDepto";

            RGN_CB_Departamento.DataSource = listaDeptos;
            RGN_CB_Departamento.DisplayMember = "nombreDpto";
            RGN_CB_Departamento.ValueMember = "noDepto";

            List<Empleados> tabla = linkCassandra.FilterEmpleados(RGN_DTP_FiltroFecha.Value);
            RGN_DGV_Reporte.DataSource = tabla;
            RGN_DGV_Reporte.Columns.Add("Edad", "Edad");
            HideUnnecessaryColumns();
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
        }
    }
}
