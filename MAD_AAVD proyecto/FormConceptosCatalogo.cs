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
    public partial class FormConceptosCatalogo : Form
    {
        public bool edit_Concepto = false; //Variable para saber si se esta editando el departamento
        public Int16 edit_noConcepto = 0; // guarda el número del departamento al que se le va a hacer un update
        public FormConceptosCatalogo()
        {
            InitializeComponent();
        }

        private void FormConceptosCatalogo_Load(object sender, EventArgs e)
        {
            ADMIN_DGV_Conceptos.DefaultCellStyle.ForeColor = Color.White;
            ADMIN_DGV_Conceptos.DefaultCellStyle.BackColor = Color.Black;
            //////////////////ENLACE SQL//////////////////////
            if (DB_SQLServer)
            {
                var linkDB = new EnlaceDB(); //enlace temporal con la db
                DataTable TablaConceptos = new DataTable(); //se crea una tabla
                TablaConceptos = linkDB.getTable("CONCEPTOS"); //se acceden a los departamentos de la db y se guardan en la tabla creada
                ADMIN_DGV_Conceptos.DataSource = TablaConceptos;
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
        private void CONCEPTOSCAT_BTN_Editar_Click(object sender, EventArgs e)
        {
            if (ADMIN_DGV_Conceptos.CurrentRow != null) //hay fila seleccionada
            {
                ////////////////////////////////////////////////////////////////////////
                if (DB_SQLServer)
                {
                    edit_noConcepto = Int16.Parse(ADMIN_DGV_Conceptos.CurrentRow.Cells["noDepto"].Value.ToString());

                    //Cargar los datos a los text box
                    var linkDB = new EnlaceDB();
                    linkDB.GetConcepto(edit_noConcepto, CONCEPTOSCAT_TB_Nombre, CONCEPTOSCAT_TB_Cuota, CONCEPTOSCAT_TB_Porcentaje); //cambiar

                    edit_Concepto = true; //para que cuando registre se haga un update en vez de un insert
                    CONCEPTOSCAT_LBL_Titulo.Text = "Edición de conceptos ";
                }
                ///////////////////////////////////////////////////////////////////////
                else if (DB_Cassandra)
                {
                    //aaaa
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void ADMIN_DGV_Conceptos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
