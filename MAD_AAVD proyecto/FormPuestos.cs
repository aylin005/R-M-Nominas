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
using Cassandra;
using Cassandra.Mapping;

namespace MAD_AAVD_proyecto
{
    public partial class FormPuestos : Form
    {
        public bool edit_Puesto = false; //Variable para saber si se esta editando el puesto
        public Int16 edit_noPuesto = 0; // guarda el noPuesto al que se le va a hacer un update
        public string[] primaryKey = { "noPuesto" };
        public string[] columnas = { "nombrePuesto", "nivelSalarial" };
        public FormPuestos()
        {
            InitializeComponent();
        }
        private void FormPuestos_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void PUESTOS_BTN_Registrar_Click(object sender, EventArgs e)
        {
            if (PUESTOS_TB_Nombre.Text.Length == 0 || PUESTOS_TB_Nivel.Text.Length == 0) // si los campos estan vacios
                MessageBox.Show("(!) Llene todos los campos");

            ///////////////////////////SQL///////////////////////////////////////////
            else
            {
                //if ((!decimal.TryParse(PUESTOS_TB_Nivel.Text, out decimal nivel)))
                //{
                //    MessageBox.Show("(!) Ingresó un nivel salarial incorrecto");
                //}
                 if (DB_SQLServer)
                {
                    var nombrePuesto = PUESTOS_TB_Nombre.Text;
                    var nivelPuesto = float.Parse(PUESTOS_TB_Nivel.Text);

                    var linkDB = new EnlaceDB();
                    bool ok = false;

                    if (!edit_Puesto) // si se va a hacer insert
                        ok = linkDB.GestionPuestos("I", 0, nombrePuesto, nivelPuesto);//noPuesto 0 porq no importa
                    else // si se esta modificando un puesto existente
                    {
                        ok = linkDB.GestionPuestos("U", edit_noPuesto, nombrePuesto, nivelPuesto);
                        edit_Puesto = false;
                        PUESTOS_LBL_Edit.Visible = false;
                    }

                    if (ok)
                    {
                        MessageBox.Show("Se guardo en la BD");
                        Reload();
                    }
                    else
                        MessageBox.Show("Error en el guardado");
                }
                ////////////////////////////////ENLACE CASSANDRA///////////////////////////////
                else if (DB_Cassandra)
                {
                    var nombrePuesto = PUESTOS_TB_Nombre.Text;
                    var nivelPuesto = float.Parse(PUESTOS_TB_Nivel.Text);

                    PUESTOS_LBL_Loading.Visible = true;
                    var linkCassandra = new EnlaceCassandra();

                    string strNombrePuesto = "'" + nombrePuesto + "'"; //agregar comillas al nombre
                    string[] pkValues = { edit_noPuesto.ToString()};
                    string[] values = { strNombrePuesto, nivelPuesto.ToString() };

                    linkCassandra.Insert(edit_Puesto, "PUESTOS", primaryKey, pkValues, columnas, values);

                    Reload();
                    PUESTOS_LBL_Loading.Visible = false;
                    edit_Puesto = false;
                }
            }
        }

        private void PUESTOS_BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (ADMIN_DGV_Puestos.CurrentRow != null) //hay fila seleccionada
            {
                Int16 noPuesto = Int16.Parse(ADMIN_DGV_Puestos.CurrentRow.Cells["noPuesto"].Value.ToString());
                ////////////////////////////////////////////////////////////////////////////////////
                if (DB_SQLServer)
                {
                    //Eliminar de la base de datos
                    var linkDB = new EnlaceDB();
                    bool ok = false;
                    ok = linkDB.GestionPuestos("D", noPuesto, null, 0.0f);

                    if (ok)
                    {
                        MessageBox.Show("Se elimino de la BD");
                        Reload();
                    }
                    else
                        MessageBox.Show("Error en el proceso");
                }
                /////////////////////////////////////////////////////////////////////////////////////
                else if (DB_Cassandra)
                {
                    var linkCassandra = new EnlaceCassandra();
                    PUESTOS_LBL_Loading.Visible= true;
                    linkCassandra.Delete("PUESTOS", primaryKey, noPuesto);
                    Reload();
                    PUESTOS_LBL_Loading.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void PUESTOS_BTN_Editar_Click(object sender, EventArgs e)
        {
            if (ADMIN_DGV_Puestos.CurrentRow != null) //hay fila seleccionada
            {
                edit_noPuesto = Int16.Parse(ADMIN_DGV_Puestos.CurrentRow.Cells["noPuesto"].Value.ToString());
                ////////////////////////////////////////////////////////////////////////
                if (DB_SQLServer)
                {
                    //Cargar los datos a los text box
                    var linkDB = new EnlaceDB();
                    linkDB.GetPuesto(edit_noPuesto, PUESTOS_TB_Nombre, PUESTOS_TB_Nivel);

                    edit_Puesto = true; //para que cuando registre se haga un update en vez de un insert
                    PUESTOS_LBL_Edit.Text = "EDITANDO PUESTO " + edit_noPuesto.ToString();
                    PUESTOS_LBL_Edit.Visible = true;
                }
                ///////////////////////////////////////////////////////////////////////
                else if(DB_Cassandra)
                {
                    var linkCassandra = new EnlaceCassandra();
                    PUESTOS_LBL_Loading.Visible = true;
                    string[] pkValues = { edit_noPuesto.ToString() };
                    Puestos puesto = linkCassandra.Get_One<Puestos>(primaryKey, columnas, "PUESTOS", pkValues);
                    
                    if (puesto != null) // Verificar que el puesto existe
                    {
                        PUESTOS_TB_Nombre.Text = puesto.nombrePuesto;
                        PUESTOS_TB_Nivel.Text = puesto.nivelSalarial.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Puesto no encontrado.");
                    }
                    edit_Puesto = true; //para que cuando registre se haga un update en vez de un insert
                    PUESTOS_LBL_Edit.Text = "EDITANDO PUESTO " + edit_noPuesto.ToString();
                    PUESTOS_LBL_Edit.Visible = true;
                    PUESTOS_LBL_Loading.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        private void Reload()
        {
            PUESTOS_TB_Nombre.Clear();//Se limpian para que no se pueda agregar un nuevo campo con lo que se edito antes
            PUESTOS_TB_Nivel.Clear();
            PUESTOS_LBL_Edit.Visible = false;

            ADMIN_DGV_Puestos.DefaultCellStyle.ForeColor = Color.White;
            ADMIN_DGV_Puestos.DefaultCellStyle.BackColor = Color.Black;

            //////////////////ENLACE SQL//////////////////////
            if (DB_SQLServer)
            {
                var linkDB = new EnlaceDB();
                DataTable TablaPuestos = new DataTable();
                TablaPuestos = linkDB.GetPuesto(); //sin parametros trae toda la tabla
                ADMIN_DGV_Puestos.DataSource = TablaPuestos;
            }
            ////////////////ENLACE CASSANDRA////////////////////
            else if (DB_Cassandra)
            {
                var linkCassandra = new EnlaceCassandra();

                string[] columnas = { "noPuesto", "nombrePuesto", "nivelSalarial" };
                List<Puestos> tabla = linkCassandra.Get_All<Puestos>(columnas, "PUESTOS");
                ADMIN_DGV_Puestos.DataSource = tabla;
                ADMIN_DGV_Puestos.Columns["noPuesto"].Visible = false;
            }
        }

        private void PUESTOS_BTN_Limpiar_Click(object sender, EventArgs e)
        {
            PUESTOS_LBL_Edit.Visible = false; //Se deja de mostrar que se esta editando
            edit_Puesto = false;
            edit_noPuesto = 0;
            PUESTOS_TB_Nombre.Clear();
            PUESTOS_TB_Nivel.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPuestos_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }
    }
}
