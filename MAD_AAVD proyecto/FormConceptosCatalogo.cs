using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MAD_AAVD_proyecto.Globals;

namespace MAD_AAVD_proyecto
{
    public partial class CONCEPTOSCAT_DB_Tipo : Form
    {
        public bool edit_Concepto = false; //Variable para saber si se esta editando el departamento
        public Int16 edit_noConcepto = 0; // guarda el número del departamento al que se le va a hacer un update
        public CONCEPTOSCAT_DB_Tipo()
        {
            InitializeComponent();
        }

        private void FormConceptosCatalogo_Load(object sender, EventArgs e)
        {
            Recharge();
        }

        private void Recharge()
        {
            ADMIN_DGV_Conceptos.DefaultCellStyle.ForeColor = Color.White;
            ADMIN_DGV_Conceptos.DefaultCellStyle.BackColor = Color.Black;

            CONCEPTOSCAT_CB_Tipo.SelectedIndex = 0;
            CONCEPTOSCAT_CB_Fijo.SelectedIndex = 0;


            //////////////////ENLACE SQL//////////////////////
            if (DB_SQLServer)
            {
                var linkDB = new EnlaceDB(); //enlace temporal con la db
                DataTable TablaConceptos = new DataTable(); //se crea una tabla
                TablaConceptos = linkDB.getTable("CONCEPTOS"); //se acceden a los departamentos de la db y se guardan en la tabla creada
                ADMIN_DGV_Conceptos.DataSource = TablaConceptos;

                CONCEPTOSCAT_TB_Cuota.Text = "N/A";
                CONCEPTOSCAT_TB_Porcentaje.Text = "N/A";
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
                    edit_noConcepto = Int16.Parse(ADMIN_DGV_Conceptos.CurrentRow.Cells["noConcepto"].Value.ToString());

                    //Cargar los datos a los text box
                    var linkDB = new EnlaceDB();
                    //saber que concepto selecciono
                    linkDB.GetConceptos(edit_noConcepto, CONCEPTOSCAT_TB_Nombre, CONCEPTOSCAT_TB_Cuota, CONCEPTOSCAT_TB_Porcentaje, CONCEPTOSCAT_CB_Fijo, CONCEPTOSCAT_CB_Tipo); //cambiar

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

        private void CONCEPTOSCAT_BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (ADMIN_DGV_Conceptos.CurrentRow != null) //hay fila seleccionada
            {
                ////////////////////////////////////////////////////////////////////////////////////
                if (DB_SQLServer)
                {
                    Int16 noConcepto = Int16.Parse(ADMIN_DGV_Conceptos.CurrentRow.Cells["noConcepto"].Value.ToString());
                    //Eliminar de la base de datos
                    var linkDB = new EnlaceDB();
                    bool ok = false;
                    ok = linkDB.GestionConceptos("D", noConcepto, "", 0.0M, 0.0M, false,false);

                    if (ok)
                    {
                        MessageBox.Show("Se elimino de la BD");
                    Recharge();
                    }
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
        private void CONCEPTOSCAT_BTN_Registrar_Click(object sender, EventArgs e)
        {
            string aux = CONCEPTOSCAT_TB_Cuota.Text.Trim();
            string aux2 = CONCEPTOSCAT_TB_Porcentaje.Text.Trim();

            if (CheckData(aux, aux2))
            {
                ///////////////////////////SQL///////////////////////////////////////////
                if (DB_SQLServer)
                {
                    aux = CONCEPTOSCAT_TB_Cuota.Text.Trim();
                    aux2 = CONCEPTOSCAT_TB_Porcentaje.Text.Trim();

                    var nombreConcepto = CONCEPTOSCAT_TB_Nombre.Text;
                    decimal porcentaje = 0.0M;
                    decimal cuota = 0.0M; //validar que sea mayor a 0

                    if (aux != "N/A")
                    {
                        cuota = decimal.Parse(CONCEPTOSCAT_TB_Cuota.Text);
                    }
                    else
                    {
                        if (aux2 != "N/A")
                        {
                            porcentaje = decimal.Parse(CONCEPTOSCAT_TB_Porcentaje.Text);
                            porcentaje /= 100;
                        }
                    }
                    string auxTipo = CONCEPTOSCAT_CB_Tipo.Text;
                    string auxFijo = CONCEPTOSCAT_CB_Fijo.Text;
                    bool isTipo, isFijo;
                    if (auxTipo == "Percepción")
                        isTipo = true;
                    else
                        isTipo = false;
                    if (auxFijo == "Sí")
                        isFijo = true;
                    else
                        isFijo = false;

                    var linkDB = new EnlaceDB();
                    bool ok = false;

                    if (!edit_Concepto) // si se va a hacer insert
                        ok = linkDB.GestionConceptos("I", 0, nombreConcepto, cuota, porcentaje, isTipo, isFijo);
                    else // si se esta modificando un puesto existente
                    {
                        ok = linkDB.GestionConceptos("U", edit_noConcepto, nombreConcepto, cuota, porcentaje, isTipo, isFijo);
                        edit_Concepto = false;
                    }
                    if (ok)
                    {
                        MessageBox.Show("Se guardo en la BD");
                        Clean();
                        Recharge();
                    }
                    else
                        MessageBox.Show("Error en el guardado");
                }
            }
        }




        private void CONCEPTOSCAT_BTN_Limpiar_Click(object sender, EventArgs e)
        {
            CONCEPTOSCAT_LBL_Titulo.Text = "Registrar nuevo concepto"; //Se deja de mostrar que se esta editando
            Clean();
        }

        private bool CheckData(string pAux, string pAux2)
        {
            // Aseguramos que las casillas de cuota y porcentaje tengan "N/A" si están vacías
            if (string.IsNullOrWhiteSpace(pAux))
                CONCEPTOSCAT_TB_Cuota.Text = "N/A";
            if (string.IsNullOrWhiteSpace(pAux2))
                CONCEPTOSCAT_TB_Porcentaje.Text = "N/A";


            pAux = CONCEPTOSCAT_TB_Cuota.Text.Trim();
            pAux2 = CONCEPTOSCAT_TB_Porcentaje.Text.Trim();

            // Verificamos que todos los campos tengan valores
            if (CONCEPTOSCAT_TB_Nombre.Text.Length == 0 ||
                CONCEPTOSCAT_TB_Cuota.Text.Length == 0 ||
                CONCEPTOSCAT_TB_Porcentaje.Text.Length == 0 || (pAux == "N/A" && pAux2 == "N/A"))
            {
                MessageBox.Show("(!) ATENCIÓN: Llene todos los datos");
                return false;
            }

            // Validamos el porcentaje
            if (CONCEPTOSCAT_TB_Porcentaje.Text != "N/A" &&
                (!decimal.TryParse(CONCEPTOSCAT_TB_Porcentaje.Text, out decimal porcentaje) || porcentaje <= 0))
            {
                MessageBox.Show("(!) ATENCIÓN: Ha ingresado un porcentaje inválido");
                CONCEPTOSCAT_TB_Porcentaje.Text = "N/A";
                return false;
            }

            // Validamos la cuota
            if (CONCEPTOSCAT_TB_Cuota.Text != "N/A" &&
                (!decimal.TryParse(CONCEPTOSCAT_TB_Cuota.Text, out decimal cuota) || cuota <= 0))
            {
                MessageBox.Show("(!) ATENCIÓN: Ha ingresado una cuota inválida");
                CONCEPTOSCAT_TB_Cuota.Text = "N/A";
                return false;
            }

            // Verificamos que no se defina tanto cuota como porcentaje
            if (pAux != "N/A" && pAux2 != "N/A")
            {
                CONCEPTOSCAT_TB_Porcentaje.Text = "N/A";
                CONCEPTOSCAT_TB_Cuota.Text = "N/A";
                MessageBox.Show("(!) ATENCIÓN: Solo puede definir un concepto como cuota o como porcentaje");
                return false;
            }

            return true;
        }

        private void Clean()
        {
            edit_Concepto = false;
            edit_noConcepto = 0;
            CONCEPTOSCAT_TB_Nombre.Clear();
            CONCEPTOSCAT_TB_Cuota.Clear();
            CONCEPTOSCAT_TB_Porcentaje.Clear();
            CONCEPTOSCAT_CB_Tipo.SelectedIndex = 0;
            CONCEPTOSCAT_CB_Fijo.SelectedIndex = 0;

        }

        private void ADMIN_DGV_Conceptos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
