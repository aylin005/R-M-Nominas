using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static MAD_AAVD_proyecto.Globals; //Agregar a cada archivo para no tener que escribir Globals.

namespace MAD_AAVD_proyecto
{
    public partial class FormGestionEmpleados : Form
    {
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
          //  EMP_CB_Departamento.SelectedIndex = 0;
         //   EMP_CB_Puesto.SelectedIndex = 0;
            EMP_DTP_Nacimiento.Value = DateTime.Now;
            EMP_DTP_FiltroFecha.Value = DateTime.Now;
            EMP_DTP_Fecha.Value = DateTime.Now;
            EMP_TB_CalleNo.Clear();
            EMP_TB_Colonia.Clear();
            EMP_TB_Municipio.Clear();
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
                TablaEmpleados = linkDB.getTable("EMPLEADOS"); 
                EMP_DGV_Empleados.DataSource = TablaEmpleados;
            }
            ////////////////ENLACE CASSANDRA////////////////////
            else if (DB_Cassandra)
            { 
                //var stopwatch = new System.Diagnostics.Stopwatch();

                //// Medir tiempo de la consulta a Cassandra
                //stopwatch.Start();
                //var linkCassandra = new EnlaceCassandra();
                //List<Puestos> tabla = linkCassandra.Get_All();
                //stopwatch.Stop();
                //MessageBox.Show($"Tiempo de consulta a Cassandra: {stopwatch.ElapsedMilliseconds} ms");

                //// Reiniciar el cronómetro
                //stopwatch.Restart();

                //// Medir tiempo de asignación al DataGridView
                //ADMIN_DGV_Puestos.DataSource = tabla;
                //stopwatch.Stop();
                //MessageBox.Show($"Tiempo de asignación al DataGridView: {stopwatch.ElapsedMilliseconds} ms");
            }
        }
   
        private void EMP_DGV_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
