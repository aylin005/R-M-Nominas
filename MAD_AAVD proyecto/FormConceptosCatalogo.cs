using Cassandra.Mapping;
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
        string[] primaryKey = { "noConcepto" };
        string[] columnas = {"nombreConcepto","cuota","porcentaje", "fijo", "percepcion" };
        public CONCEPTOSCAT_DB_Tipo()
        {
            InitializeComponent();
        }

        /// ******************************************************************************************************************************************************************************************************

        private void FormConceptosCatalogo_Load(object sender, EventArgs e)
        {
            Reload();
        }

        /// ******************************************************************************************************************************************************************************************************
        private void Reload()
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
                TablaConceptos = linkDB.GetConceptos(); //se acceden a los departamentos de la db y se guardan en la tabla creada

                //Importante limpiar antes para que al recargar no se duplique
                ADMIN_DGV_Conceptos.Rows.Clear();

                // Añade cada fila del DataTable al DGV
                foreach (DataRow row in TablaConceptos.Rows)
                {
                    // Crea una nueva fila en el DataGridView
                    int rowIndex = ADMIN_DGV_Conceptos.Rows.Add();

                    //Se especifica bien qué columna de la tabla SQL se asigna a qué columna de DGV
                    ADMIN_DGV_Conceptos.Rows[rowIndex].Cells["noConcepto"].Value = row["noConcepto"];
                    ADMIN_DGV_Conceptos.Rows[rowIndex].Cells["Nombre"].Value = row["nombreConcepto"];
                    ADMIN_DGV_Conceptos.Rows[rowIndex].Cells["Cuota"].Value = row["cuota"];
                    ADMIN_DGV_Conceptos.Rows[rowIndex].Cells["Porcentaje"].Value = row["porcentaje"];
                    ADMIN_DGV_Conceptos.Rows[rowIndex].Cells["Fijo"].Value = row["fijo"];
                    ADMIN_DGV_Conceptos.Rows[rowIndex].Cells["Percepcion"].Value = row["percepcion"];

                }

                CONCEPTOSCAT_TB_Cuota.Text = "N/A";
                CONCEPTOSCAT_TB_Porcentaje.Text = "N/A";
                edit_Concepto = false;
                CONCEPTOSCAT_LBL_Edit.Visible = false;
            }
            ////////////////ENLACE CASSANDRA////////////////////
            else if (DB_Cassandra)
            {
                var linkCassandra = new EnlaceCassandra();

                string[] columnas = { "noConcepto", "nombreConcepto", "cuota", "porcentaje", "fijo", "percepcion" };
                List<Conceptos> tabla = linkCassandra.Get_All<Conceptos>(columnas, "CONCEPTOS");
                ADMIN_DGV_Conceptos.Rows.Clear();
                foreach (var item in tabla)
                {
                    ADMIN_DGV_Conceptos.Rows.Add(
                        item.noConcepto,
                        item.nombreConcepto,
                        item.cuota,
                        item.porcentaje,
                        item.fijo,
                        item.percepcion
                        );
                }
                //ADMIN_DGV_Conceptos.DataSource = tabla;
                ADMIN_DGV_Conceptos.Columns["noConcepto"].Visible = false;

                CONCEPTOSCAT_TB_Cuota.Text = "N/A";
                CONCEPTOSCAT_TB_Porcentaje.Text = "N/A";
                edit_Concepto = false;
                CONCEPTOSCAT_LBL_Edit.Visible = false;
            }
        }

        /// ******************************************************************************************************************************************************************************************************
        private void CONCEPTOSCAT_BTN_Editar_Click(object sender, EventArgs e)
        {
            if (ADMIN_DGV_Conceptos.CurrentRow != null)
            {
                edit_noConcepto = Int16.Parse(ADMIN_DGV_Conceptos.CurrentRow.Cells["noConcepto"].Value.ToString());
                ////////////S Q L 
                if (DB_SQLServer)
                {
                    //Cargar los datos a los text box
                    var linkDB = new EnlaceDB();
                    //saber que concepto selecciono
                    linkDB.GetConceptos(edit_noConcepto, CONCEPTOSCAT_TB_Nombre, CONCEPTOSCAT_TB_Cuota, CONCEPTOSCAT_TB_Porcentaje, CONCEPTOSCAT_CB_Fijo, CONCEPTOSCAT_CB_Tipo); //cambiar

                    edit_Concepto = true; //para que cuando registre se haga un update en vez de un insert
                    CONCEPTOSCAT_LBL_Edit.Visible = true;
                    CONCEPTOSCAT_LBL_Edit.Text = "EDITANDO CONCEPTO " + edit_noConcepto.ToString();

                }
                ////////////C A S S A N D R A, L A   D A M A   D E   L A S   B A S E S   D E   D A T O S
                else if (DB_Cassandra)
                {
                    var linkCassandra = new EnlaceCassandra();
                    CONCEPTOSCAT_LBL_Loading.Visible = true;
                    string[] pkValues = { edit_noConcepto.ToString() };
                    Conceptos concepto = linkCassandra.Get_One<Conceptos>(primaryKey,columnas,"CONCEPTOS", pkValues);

                    if (concepto != null) // Verificar que el puesto existe
                    {
                        CONCEPTOSCAT_TB_Nombre.Text = concepto.nombreConcepto;
                        CONCEPTOSCAT_CB_Tipo.SelectedIndex = Convert.ToInt32(concepto.percepcion);
                        CONCEPTOSCAT_CB_Fijo.SelectedIndex = Convert.ToInt32(concepto.fijo);
                        if(concepto.porcentaje > 0)
                        {
                            CONCEPTOSCAT_TB_Porcentaje.Text = concepto.porcentaje.ToString();
                            CONCEPTOSCAT_TB_Cuota.Text = "N/A";
                        }
                        else if(concepto.cuota > 0)
                        {
                            CONCEPTOSCAT_TB_Cuota.Text = concepto.cuota.ToString();
                            CONCEPTOSCAT_TB_Porcentaje.Text = "N/A";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Concepto no encontrado.");
                    }
                    edit_Concepto = true; //para que cuando registre se haga un update en vez de un insert
                    CONCEPTOSCAT_LBL_Edit.Text = "EDITANDO CONCEPTO " + edit_noConcepto.ToString();
                    CONCEPTOSCAT_LBL_Edit.Visible = true;
                    CONCEPTOSCAT_LBL_Loading.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        /// ******************************************************************************************************************************************************************************************************

        private void CONCEPTOSCAT_BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (ADMIN_DGV_Conceptos.CurrentRow != null) //hay fila seleccionada
            {
                Int16 noConcepto = Int16.Parse(ADMIN_DGV_Conceptos.CurrentRow.Cells["noConcepto"].Value.ToString());
                ////////////S Q L 
                if (DB_SQLServer)
                {
                    var linkDB = new EnlaceDB();
                    bool ok = false;
                    ok = linkDB.GestionConceptos("D", noConcepto, "", 0.0M, 0.0M, false,false); //para definir un decimal usa una M, en lugar de una f : 0.0f -> 0.0M

                    if (ok)
                    {
                        MessageBox.Show("Se elimino de la BD");
                        Reload();
                    }
                    else
                        MessageBox.Show("Error en el proceso");
                }
                ////////////C A S S A N D R A, L A   D A M A   D E   L A S   B A S E S   D E   D A T O S
                else if (DB_Cassandra)
                {
                    var linkCassandra = new EnlaceCassandra();
                    CONCEPTOSCAT_LBL_Loading.Visible = true;
                    linkCassandra.Delete("CONCEPTOS", primaryKey, noConcepto);
                    Reload();
                    CONCEPTOSCAT_LBL_Loading.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        /// ******************************************************************************************************************************************************************************************************

        private void CONCEPTOSCAT_BTN_Registrar_Click(object sender, EventArgs e)
        {
            string aux = CONCEPTOSCAT_TB_Cuota.Text.Trim();
            string aux2 = CONCEPTOSCAT_TB_Porcentaje.Text.Trim();

            if (CheckData(aux, aux2))
            {
                aux = CONCEPTOSCAT_TB_Cuota.Text.Trim();
                aux2 = CONCEPTOSCAT_TB_Porcentaje.Text.Trim();

                var nombreConcepto = CONCEPTOSCAT_TB_Nombre.Text;
                decimal porcentaje = 0.0M;
                decimal cuota = 0.0M;

                if (aux != "N/A") //hay que asegurarnos de que sean datos númericos
                {
                    cuota = decimal.Parse(CONCEPTOSCAT_TB_Cuota.Text);
                }
                else
                {
                    if (aux2 != "N/A")
                    {
                        porcentaje = decimal.Parse(CONCEPTOSCAT_TB_Porcentaje.Text);
                        porcentaje /= 100; //se divide entre 100 para que se guarde así -> 25% -> 0.25 
                    }
                }

                string auxTipo = CONCEPTOSCAT_CB_Tipo.Text; //se obtienen del CB
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

                ////////////S Q L 
                if (DB_SQLServer)
                {
                    var linkDB = new EnlaceDB();
                    bool ok = false;

                    if (!edit_Concepto)
                        ok = linkDB.GestionConceptos("I", 0, nombreConcepto, cuota, porcentaje, isTipo, isFijo);
                    else
                    {
                        ok = linkDB.GestionConceptos("U", edit_noConcepto, nombreConcepto, cuota, porcentaje, isTipo, isFijo);
                        edit_Concepto = false;
                    }
                    if (ok)
                    {
                        MessageBox.Show("Se guardo en la BD");
                        Clean(); //actualizamos la tabla
                        Reload();
                    }
                    else
                        MessageBox.Show("Error en el guardado");
                }
                else if(DB_Cassandra)
                {
                    CONCEPTOSCAT_LBL_Loading.Visible = true;
                    var linkCassandra = new EnlaceCassandra();

                    string strNombre = $"'{nombreConcepto}'"; //agregar comillas al nombre
                    string[] pkValues = { edit_noConcepto.ToString() };
                    string[] values = { strNombre, cuota.ToString(), ((float)porcentaje).ToString(), isFijo.ToString(), isTipo.ToString() };
                    
                    if (cuota == 0)
                        values[1] = "null";
                    else if(porcentaje == 0)
                        values[2] = "null";

                    linkCassandra.Insert(edit_Concepto, "CONCEPTOS", primaryKey, pkValues, columnas, values);
                    Clean();
                    Reload();
                    CONCEPTOSCAT_LBL_Loading.Visible = false;
                    edit_Concepto = false;
                }
            }
        }

        /// ******************************************************************************************************************************************************************************************************

        private void CONCEPTOSCAT_BTN_Limpiar_Click(object sender, EventArgs e)
        {
            //CONCEPTOSCAT_LBL_Titulo.Text = "Registrar nuevo concepto"; //Se deja de mostrar que se esta editando
            Clean();
        }

        /// ******************************************************************************************************************************************************************************************************

        private bool CheckData(string pAux, string pAux2)
        {
            if (string.IsNullOrWhiteSpace(pAux))
                CONCEPTOSCAT_TB_Cuota.Text = "N/A"; //si el usuario deja en blanco la casilla entonces le ponemos N/A -> No Aplica
            if (string.IsNullOrWhiteSpace(pAux2))
                CONCEPTOSCAT_TB_Porcentaje.Text = "N/A";


            pAux = CONCEPTOSCAT_TB_Cuota.Text.Trim(); //se actualizan, si no, marcaría error en las siguientes validaciones
            pAux2 = CONCEPTOSCAT_TB_Porcentaje.Text.Trim();

            if (CONCEPTOSCAT_TB_Nombre.Text.Length == 0 || CONCEPTOSCAT_TB_Cuota.Text.Length == 0 || CONCEPTOSCAT_TB_Porcentaje.Text.Length == 0 || (pAux == "N/A" && pAux2 == "N/A"))
            {
                MessageBox.Show("(!) ATENCIÓN: Llene todos los datos");
                return false;
            }

            if (CONCEPTOSCAT_TB_Porcentaje.Text != "N/A" && (!decimal.TryParse(CONCEPTOSCAT_TB_Porcentaje.Text, out decimal porcentaje) || porcentaje <= 0))
                //que no sea menor a 0, no lo he limitado a que no sea mayor a 100 por que no sé si esa validación sea necesaria
            {
                MessageBox.Show("(!) ATENCIÓN: Ha ingresado un porcentaje inválido");
                CONCEPTOSCAT_TB_Porcentaje.Text = "N/A";
                return false;
            }

            if (CONCEPTOSCAT_TB_Cuota.Text != "N/A" && (!decimal.TryParse(CONCEPTOSCAT_TB_Cuota.Text, out decimal cuota) || cuota <= 0))
                //que no sea menor a 0 | El tryParse valida si el numero es válido, si lo es, guarda el valor en cuota, si no se devuelve un false
            {
                MessageBox.Show("(!) ATENCIÓN: Ha ingresado una cuota inválida");
                CONCEPTOSCAT_TB_Cuota.Text = "N/A";
                return false;
            }

            if (pAux != "N/A" && pAux2 != "N/A")
            {
                CONCEPTOSCAT_TB_Porcentaje.Text = "N/A";
                CONCEPTOSCAT_TB_Cuota.Text = "N/A";
                MessageBox.Show("(!) ATENCIÓN: Solo puede definir un concepto como cuota o como porcentaje");
                return false;
            }
            return true;
        }

        /// ******************************************************************************************************************************************************************************************************

        private void Clean()
        {
            edit_Concepto = false;
            edit_noConcepto = 0;
            CONCEPTOSCAT_LBL_Edit.Visible = false;
            CONCEPTOSCAT_TB_Nombre.Clear();
            CONCEPTOSCAT_TB_Cuota.Text = "N/A";
            CONCEPTOSCAT_TB_Porcentaje.Text = "N/A";
            CONCEPTOSCAT_CB_Tipo.SelectedIndex = 0;
            CONCEPTOSCAT_CB_Fijo.SelectedIndex = 0;
        }

        /// ******************************************************************************************************************************************************************************************************

        private void ADMIN_DGV_Conceptos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DEPARTAMENTOS_LBL_Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
