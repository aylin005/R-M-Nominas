using Cassandra.Mapping;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static MAD_AAVD_proyecto.Globals; //Agregar a cada archivo para no tener que escribir Globals.

namespace MAD_AAVD_proyecto
{
    public partial class FormGestionEmpleados : Form
    {
        public bool edit_Emp = false;
        public Int16 edit_noEmp = 0;

        string[] primaryKey = { "noEmpleado", "fechaInicio", "departamento", "puesto", "salarioDiario" };

        public FormGestionEmpleados()
        {
            InitializeComponent();
        }

        private void FormGestionEmpleados_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            EMP_TB_NoEmpleado.Clear();
            EMP_TB_Nombres.Clear();
            EMP_TB_ApPaterno.Clear();
            EMP_TB_ApMaterno.Clear();
            EMP_TB_Contrasena.Clear();
            EMP_DTP_Nacimiento.Value = DateTime.Now;
            EMP_DTP_FiltroFecha.Value = DateTime.Now;
            EMP_DTP_Fecha.Value = DateTime.Now;
            EMP_TB_CalleNo.Clear();
            EMP_TB_Colonia.Clear();
            EMP_TB_Cp.Clear();
            EMP_TB_Banco.Clear();
            EMP_TB_NoCuenta.Clear();
            EMP_TB_Email.Clear();
            EMP_TB_Tel1.Clear();
            EMP_TB_Tel2.Clear();
            EMP_TB_Curp.Clear();
            EMP_TB_Nss.Clear();
            EMP_TB_Rfc.Clear();

            EMP_DGV_Empleados.DefaultCellStyle.ForeColor = Color.White;
            EMP_DGV_Empleados.DefaultCellStyle.BackColor = Color.Black;

            //////////////////ENLACE SQL//////////////////////
            if (DB_SQLServer)
            {
                var linkDB = new EnlaceDB();
                DataTable TablaEmpleados = new DataTable();
                TablaEmpleados = linkDB.GetEmpleados();
                EMP_DGV_Empleados.DataSource = TablaEmpleados;

                DataTable TablaDepartamentos = linkDB.GetDepto();
                EMP_CB_Departamento.DataSource = TablaDepartamentos;
                EMP_CB_Departamento.DisplayMember = "nombreDpto";  // dato
                EMP_CB_Departamento.ValueMember = "noDepto";       // indice al que se relaciona el valor

                DataTable TablaPuestos = linkDB.GetPuesto();
                EMP_CB_Puesto.DataSource = TablaPuestos;
                EMP_CB_Puesto.DisplayMember = "nombrePuesto"; 
                EMP_CB_Puesto.ValueMember = "noPuesto";

                DataTable TablaEstados = linkDB.GetEstados();
                EMP_CB_ESTADO.DataSource = TablaEstados;
                EMP_CB_ESTADO.DisplayMember = "nombreEstado";
                EMP_CB_ESTADO.ValueMember = "noEstado";

                DataTable TablaMunicipios = linkDB.GetMunicipios(EMP_CB_ESTADO.Text);
                EMP_CB_Municipio.DataSource = TablaMunicipios;
                EMP_CB_Municipio.DisplayMember = "nombreMunicipio";
                EMP_CB_Municipio.ValueMember = "noMunicipio";

                // Falta actualizar municipios cada vez que se cambia de estado

                EMP_CB_Departamento.SelectedIndex= 0; //Aqui ya se selecciona
                EMP_CB_Puesto.SelectedIndex = 0;
                EMP_CB_ESTADO.SelectedIndex = 0;
                //EMP_CB_Municipio.SelectedIndex = 0;

            }
            ////////////////ENLACE CASSANDRA////////////////////
            else if (DB_Cassandra)
            {
                var linkCassandra = new EnlaceCassandra();
                //COMBOBOX DEPARTAMENTOS
                string[] columnasDepto = { "noDepto", "nombreDpto"};
                List<Departamentos> listaDepartamentos = linkCassandra.Get_All<Departamentos>(columnasDepto, "DEPARTAMENTOS");
                EMP_CB_Departamento.DataSource = listaDepartamentos;
                EMP_CB_Departamento.DisplayMember = "nombreDpto";
                EMP_CB_Departamento.ValueMember = "noDepto";

                //COMBOBOX PUESTOS
                string[] columnasPuestos = { "noPuesto", "nombrePuesto" };
                List<Puestos> listaPuestos = linkCassandra.Get_All<Puestos>(columnasPuestos, "PUESTOS");
                EMP_CB_Puesto.DataSource = listaPuestos;
                EMP_CB_Puesto.DisplayMember = "nombrePuesto";
                EMP_CB_Puesto.ValueMember = "noPuesto";

                string[] columnasTablaEmp = { "noEmpleado", "nombres", "apPaterno", "apMaterno", "departamento", "puesto", "fechaInicio" };
                List<Empleados> tabla = linkCassandra.Get_All<Empleados>(columnasTablaEmp, "EMPLEADOS");
                EMP_DGV_Empleados.DataSource = tabla;
                EMP_DGV_Empleados.Columns["contrasena"].Visible = false;
                EMP_DGV_Empleados.Columns["fechaNacimiento"].Visible = false;
                EMP_DGV_Empleados.Columns["curp"].Visible = false;
                EMP_DGV_Empleados.Columns["rfc"].Visible = false;
                EMP_DGV_Empleados.Columns["nss"].Visible = false;
                EMP_DGV_Empleados.Columns["calleNo"].Visible = false;
                EMP_DGV_Empleados.Columns["colonia"].Visible = false;
                EMP_DGV_Empleados.Columns["municipio"].Visible = false;
                EMP_DGV_Empleados.Columns["estado"].Visible = false;
                EMP_DGV_Empleados.Columns["cp"].Visible = false;
                EMP_DGV_Empleados.Columns["colonia"].Visible = false;
                EMP_DGV_Empleados.Columns["banco"].Visible = false;
                EMP_DGV_Empleados.Columns["noCuenta"].Visible = false;
                EMP_DGV_Empleados.Columns["email"].Visible = false;
                EMP_DGV_Empleados.Columns["telefonos"].Visible = false;
                EMP_DGV_Empleados.Columns["salarioDiario"].Visible = false;
                EMP_DGV_Empleados.Columns["fechaBaja"].Visible = false;
            }
        }

        /// ******************************************************************************************************************************************************************************************************

        private void EMP_BTN_Editar_Click(object sender, EventArgs e)
        {
            if (EMP_DGV_Empleados.CurrentRow != null)
            {
                edit_noEmp = Int16.Parse(EMP_DGV_Empleados.CurrentRow.Cells["noEmpleado"].Value.ToString());
                string fechaInicio = "'" + EMP_DGV_Empleados.CurrentRow.Cells["fechaInicio"].Value.ToString() + "'";
                if (DB_SQLServer)
                {
                    ////Cargar los datos a los text box
                    //var linkDB = new EnlaceDB();
                    //linkDB.GetEmpleados(edit_noEmp, EMP_TB_NoEmpleado, EMP_TB_Nombres, EMP_TB_ApPaterno, EMP_TB_ApMaterno, EMP_TB_Contrasena,
                    //    EMP_TB_CalleNo, EMP_TB_Colonia, EMP_TB_Municipio, EMP_TB_Estado, EMP_TB_Cp, EMP_TB_Banco, EMP_TB_NoCuenta, EMP_TB_Email, EMP_TB_Tel1, EMP_TB_Tel2,
                    //    EMP_TB_Curp, EMP_TB_Nss, EMP_TB_Rfc, 
                    //    EMP_CB_Departamento, EMP_CB_Puesto,
                    //    EMP_DTP_Nacimiento, EMP_DTP_Fecha);

                    //isEditingEmp = true; //para que cuando registre se haga un update en vez de un insert
                    //EMP_LBL_Titulo.Text = "EDITANDO EMPLEADO " + edit_noEmp.ToString();
                }
                ///////////////////////////////////////////////////////////////////////
                else if (DB_Cassandra)
                {
                    var linkCassandra = new EnlaceCassandra();
                    EMP_LBL_Loading.Visible = true;

                    string[] pkValues = { edit_noEmp.ToString(), fechaInicio};
                    string[] primaryKey = { "noEmpleado", "fechaInicio"}; //columnas de la condicion WHERE
                    string[] columnas = { "nombres", "apPaterno", "apMaterno", "departamento", "puesto"};//SELECT
                    Empleados empleado = linkCassandra.Get_One<Empleados>(primaryKey, columnas, "EMPLEADOS", pkValues, 2);

                    //Asignacion de valores a los TextBox
                    EMP_TB_NoEmpleado.Text = empleado.noEmpleado.ToString();
                    EMP_TB_Nombres.Text = empleado.nombres;
                    EMP_TB_ApPaterno.Text = empleado.apPaterno;
                    EMP_TB_ApMaterno.Text = empleado.apMaterno;
                    EMP_CB_Departamento.Text = empleado.departamento;
                    EMP_CB_Puesto.Text = empleado.puesto;
                    EMP_DTP_Fecha.Text = empleado.fechaInicio.ToString();


                    edit_Emp = true; //para que cuando registre se haga un update en vez de un insert
                    EMP_LBL_Edit.Text = "EDITANDO EMPLEADO " + edit_noEmp.ToString();
                    EMP_LBL_Edit.Visible = true;
                    EMP_LBL_Loading.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        /// ******************************************************************************************************************************************************************************************************
        private void EMP_BTN_Limpiar_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        /// ******************************************************************************************************************************************************************************************************
        private void EMP_BTN_Registrar_Click(object sender, EventArgs e)
        {
            string nombres = "'" + EMP_TB_Nombres.Text + "'";
            string apPaterno = "'"+ EMP_TB_ApPaterno.Text + "'";
            string apMaterno = "'" + EMP_TB_ApMaterno.Text + "'";
            string departamento = "'" + EMP_CB_Departamento.Text + "'";
            string puesto = "'" + EMP_CB_Puesto.Text + "'";
            string fechaInicio = "'" + EMP_DTP_Fecha.Value.ToString("yyyy-MM-dd") + "'";

            if(DB_SQLServer)
            {

            }
            else if (DB_Cassandra)
            {
                var linkCassandra = new EnlaceCassandra();

                //CALCULAR SALARIO DIARIO
                string[] pkValues = { edit_noEmp.ToString(), fechaInicio, departamento, puesto, "350.00" };
                string[] columnas = { "nombres", "apPaterno", "apMaterno" };
                string[] values = { nombres, apPaterno, apMaterno };
                
                linkCassandra.Insert(edit_Emp, "EMPLEADOS", primaryKey, pkValues, columnas, values);
                ClearAll();
                Reload();
                edit_Emp = false;
            }

        }

        private void EMP_DGV_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearAll()
        {
            EMP_LBL_Edit.Visible = false;
            EMP_TB_NoEmpleado.Clear();
            EMP_TB_Nombres.Clear();
            EMP_TB_ApPaterno.Clear();
            EMP_TB_ApMaterno.Clear();
            EMP_TB_Contrasena.Clear();
            EMP_DTP_Nacimiento.Value = DateTime.Now;
            //EMP_DTP_FiltroFecha.Value = DateTime.Now;
            EMP_DTP_Fecha.Value = DateTime.Now;
            EMP_TB_CalleNo.Clear();
            EMP_TB_Colonia.Clear();
            EMP_TB_Cp.Clear();
            EMP_TB_Banco.Clear();
            EMP_TB_NoCuenta.Clear();
            EMP_TB_Email.Clear();
            EMP_TB_Tel1.Clear();
            EMP_TB_Tel2.Clear();
            EMP_TB_Curp.Clear();
            EMP_TB_Nss.Clear();
            EMP_TB_Rfc.Clear();

            EMP_DGV_Empleados.DefaultCellStyle.ForeColor = Color.White;
            EMP_DGV_Empleados.DefaultCellStyle.BackColor = Color.Black;
        }

    }
}
