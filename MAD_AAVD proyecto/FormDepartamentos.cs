using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MAD_AAVD_proyecto.Globals;
using System.Windows.Forms;

namespace MAD_AAVD_proyecto
{
    public partial class FormDepartamentos : Form
    {
        public bool edit_Depto = false; //Variable para saber si se esta editando el departamento
        public Int16 edit_noDepto = 0; // guarda el número del departamento al que se le va a hacer un update
        public FormDepartamentos()
        {
            InitializeComponent();
        }

        private void FormDepartamentos_Load(object sender, EventArgs e)
        {
            ADMIN_DGV_Departamentos.DefaultCellStyle.ForeColor = Color.White;
            ADMIN_DGV_Departamentos.DefaultCellStyle.BackColor = Color.Black;

            //////////////////ENLACE SQL//////////////////////
            if (DB_SQLServer)
            {
                var linkDB = new EnlaceDB(); //enlace temporal con la db
                DataTable TablaDepartamentos = new DataTable(); //se crea una tabla
                TablaDepartamentos = linkDB.getTable("DEPARTAMENTOS"); //se acceden a los departamentos de la db y se guardan en la tabla creada
                ADMIN_DGV_Departamentos.DataSource = TablaDepartamentos; 
            }
            ////////////////ENLACE CASSANDRA////////////////////
            else if (DB_Cassandra)
            { //q miedo Cassandra, la dama de las bases de datos
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
        private void DEPARTAMENTOS_BTN_Registrar_Click(object sender, EventArgs e)
        {
            if (DEPARTAMENTOS_TB_NombreDepto.Text.Length == 0 || DEPARTAMENTOS_TB_Sueldo.Text.Length == 0) // si los campos estan vacios
                MessageBox.Show("Llene todos los campos");

            ///////////////////////////SQL///////////////////////////////////////////
            else if (DB_SQLServer)
            {
                var nombreDepto = DEPARTAMENTOS_TB_NombreDepto.Text;
                var saldoDepto = decimal.Parse(DEPARTAMENTOS_TB_Sueldo.Text);

                var linkDB = new EnlaceDB();
                bool ok = false;

                if (!edit_Depto) // si se va a hacer insert
                    ok = linkDB.GestionDeptos("I", 0, nombreDepto, saldoDepto);//noPuesto 0 porq no importa
                else // si se esta modificando un puesto existente
                {
                    ok = linkDB.GestionDeptos("U", edit_noDepto, nombreDepto, saldoDepto);
                    edit_Depto = false;
                    DEPARTAMENTOS_LBL_Edit.Visible = false;
                }


                if (ok)
                {
                    MessageBox.Show("Se guardo en la BD");
                    DEPARTAMENTOS_TB_NombreDepto.Clear();//Se limpian para que no se pueda agregar un nuevo campo con lo que se edito antes
                    DEPARTAMENTOS_TB_Sueldo.Clear();
                }
                else
                    MessageBox.Show("Error en el guardado");
            }
        }
        private void DEPARTAMENTOS_BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (ADMIN_DGV_Departamentos.CurrentRow != null) //hay fila seleccionada
            {
                ////////////////////////////////////////////////////////////////////////////////////
                if (DB_SQLServer)
                {
                    Int16 noDepto = Int16.Parse(ADMIN_DGV_Departamentos.CurrentRow.Cells["noDepto"].Value.ToString());
                    //Eliminar de la base de datos
                    var linkDB = new EnlaceDB();
                    bool ok = false;
                    ok = linkDB.GestionPuestos("D", noDepto, null, 0.0f);

                    if (ok)
                        MessageBox.Show("Se elimino de la BD");
                    else
                        MessageBox.Show("Error en el proceso");
                }
                /////////////////////////////////////////////////////////////////////////////////////
                else if (DB_Cassandra)
                {

                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }
        private void DEPARTAMENTOS_BTN_Editar_Click(object sender, EventArgs e)
        {
            if (ADMIN_DGV_Departamentos.CurrentRow != null) //hay fila seleccionada
            {
                ////////////////////////////////////////////////////////////////////////
                if (DB_SQLServer)
                {
                    edit_noDepto = Int16.Parse(ADMIN_DGV_Departamentos.CurrentRow.Cells["noDepto"].Value.ToString());

                    //Cargar los datos a los text box
                    var linkDB = new EnlaceDB();
                    linkDB.GetDepto(edit_noDepto, DEPARTAMENTOS_TB_NombreDepto, DEPARTAMENTOS_TB_Sueldo);

                    edit_Depto = true; //para que cuando registre se haga un update en vez de un insert
                    DEPARTAMENTOS_LBL_Edit.Text = "EDITANDO EL DEPARTAMENTO no. " + edit_noDepto.ToString();
                    DEPARTAMENTOS_LBL_Edit.Visible = true;
                }
                ///////////////////////////////////////////////////////////////////////
                else if (DB_Cassandra)
                {

                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void DEPARTAMENTOS_BTN_Limpiar_Click(object sender, EventArgs e)
        {
            DEPARTAMENTOS_LBL_Edit.Visible = false; //Se deja de mostrar que se esta editando
            edit_Depto = false;
            edit_noDepto = 0;
            DEPARTAMENTOS_TB_NombreDepto.Clear();
            DEPARTAMENTOS_TB_Sueldo.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PUESTOS_LBL_Edit_Click(object sender, EventArgs e)
        {

        }

    }
}
