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
using Cassandra.Mapping;

namespace MAD_AAVD_proyecto
{
    public partial class FormDepartamentos : Form
    {
        public bool edit_Depto = false; //Variable para saber si se esta editando el departamento
        public Int16 edit_noDepto = 0; // guarda el número del departamento al que se le va a hacer un update
        public string[] primaryKey = { "noDepto" };
        public string[] columnas = { "nombreDpto", "sueldoBase" };
        public FormDepartamentos()
        {
            InitializeComponent();
        }

        /// ******************************************************************************************************************************************************************************************************

        private void FormDepartamentos_Load(object sender, EventArgs e)
        {
            Reload();
            ADMIN_DGV_Departamentos.Columns["SueldoBase"].DefaultCellStyle.Format = "C"; // Formato de moneda
        }

        /// ******************************************************************************************************************************************************************************************************

        private void DEPARTAMENTOS_BTN_Registrar_Click(object sender, EventArgs e)
        {
            //////////////////////////SQL///////////////////////////////////////////
            if (DEPARTAMENTOS_TB_NombreDepto.Text.Length == 0 || DEPARTAMENTOS_TB_Sueldo.Text.Length == 0) // si los campos estan vacios
            {
                MessageBox.Show("(!) Llene todos los campos");
            }
            else
            {
                if ((!decimal.TryParse(DEPARTAMENTOS_TB_Sueldo.Text, out decimal porcentaje)) || porcentaje <= 0) //solo valores numericos y mayores a 0
                {
                    MessageBox.Show("(!) Valor inválido");
                }
                else if (DB_SQLServer)
                {
                    var nombreDepto = DEPARTAMENTOS_TB_NombreDepto.Text;
                    var sueldoDepto = decimal.Parse(DEPARTAMENTOS_TB_Sueldo.Text);

                    var linkDB = new EnlaceDB();
                    bool ok = false;

                    if (!edit_Depto) // si se va a hacer insert
                        ok = linkDB.GestionDeptos("I", 0, nombreDepto, sueldoDepto);
                    else
                    {
                        ok = linkDB.GestionDeptos("U", edit_noDepto, nombreDepto, sueldoDepto);
                        edit_Depto = false;
                        DEPARTAMENTOS_LBL_Edit.Visible = false;
                    }


                    if (ok)
                    {
                        MessageBox.Show("Se guardo en la BD");
                        Reload();
                    }
                    else
                        MessageBox.Show("Error en el guardado");
                }
                else if(DB_Cassandra)
                {
                    var nombreDepto = DEPARTAMENTOS_TB_NombreDepto.Text;
                    var sueldoDepto = float.Parse(DEPARTAMENTOS_TB_Sueldo.Text);

                    DEPARTAMENTOS_LBL_Loading.Visible = true;
                    var linkCassandra = new EnlaceCassandra();

                    string strNombreDepto =$"'{nombreDepto}'"; //agregar comillas al nombre
                    string[] pkValues = { edit_noDepto.ToString()};
                    string[] values = { strNombreDepto, sueldoDepto.ToString() };

                    linkCassandra.Insert(edit_Depto, "DEPARTAMENTOS", primaryKey, pkValues, columnas, values);

                    Reload();
                    DEPARTAMENTOS_LBL_Loading.Visible = false;
                    edit_Depto = false;
                }
            }
        }

        /// ******************************************************************************************************************************************************************************************************

        private void DEPARTAMENTOS_BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (ADMIN_DGV_Departamentos.CurrentRow != null) 
            {
                Int16 noDepto = Int16.Parse(ADMIN_DGV_Departamentos.CurrentRow.Cells["noDepto"].Value.ToString());
                if (DB_SQLServer)
                {
                    //Eliminar de la base de datos
                    var linkDB = new EnlaceDB();
                    bool ok = false;
                    ok = linkDB.GestionDeptos("D", noDepto, null, 0.0M);

                    if (ok)
                    {
                        MessageBox.Show("Se elimino de la BD");
                        Reload();
                    }
                    else
                        MessageBox.Show("Error en el proceso");
                }
                else if (DB_Cassandra)
                {
                    var linkCassandra = new EnlaceCassandra();
                    DEPARTAMENTOS_LBL_Loading.Visible = true;
                    linkCassandra.Delete("DEPARTAMENTOS", primaryKey, noDepto);
                    Reload();
                    DEPARTAMENTOS_LBL_Loading.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        /// ******************************************************************************************************************************************************************************************************

        private void DEPARTAMENTOS_BTN_Editar_Click(object sender, EventArgs e)
        {
            if (ADMIN_DGV_Departamentos.CurrentRow != null)
            {
                edit_noDepto = Int16.Parse(ADMIN_DGV_Departamentos.CurrentRow.Cells["noDepto"].Value.ToString());

                if (DB_SQLServer)
                {
                    //Cargar los datos a los text box
                    var linkDB = new EnlaceDB();
                    linkDB.GetDepto(edit_noDepto, DEPARTAMENTOS_TB_NombreDepto, DEPARTAMENTOS_TB_Sueldo);

                    edit_Depto = true; //para que cuando registre se haga un update en vez de un insert
                    DEPARTAMENTOS_LBL_Edit.Text = "EDITANDO DEPARTAMENTO " + edit_noDepto.ToString();
                    DEPARTAMENTOS_LBL_Edit.Visible = true;
                }
                ///////////////////////////////////////////////////////////////////////
                else if (DB_Cassandra)
                {
                    var linkCassandra = new EnlaceCassandra();
                    DEPARTAMENTOS_LBL_Loading.Visible = true;
                    string[] pkValues = { edit_noDepto.ToString() };
                    Departamentos departamento = linkCassandra.Get_One<Departamentos>(primaryKey,columnas,"DEPARTAMENTOS", pkValues);

                    if (departamento != null) // Verificar que el puesto existe
                    {
                        DEPARTAMENTOS_TB_NombreDepto.Text = departamento.nombreDpto;
                        DEPARTAMENTOS_TB_Sueldo.Text = departamento.sueldoBase.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Departamento no encontrado.");
                    }
                    edit_Depto = true; //para que cuando registre se haga un update en vez de un insert
                    DEPARTAMENTOS_LBL_Edit.Text = "EDITANDO DEPARTAMENTO " + edit_noDepto.ToString();
                    DEPARTAMENTOS_LBL_Edit.Visible = true;
                    DEPARTAMENTOS_LBL_Loading.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }

        /// ******************************************************************************************************************************************************************************************************

        private void DEPARTAMENTOS_BTN_Limpiar_Click(object sender, EventArgs e)
        {
            DEPARTAMENTOS_LBL_Edit.Visible = false; //Se deja de mostrar que se esta editando
            edit_Depto = false;
            edit_noDepto = 0;
            DEPARTAMENTOS_TB_NombreDepto.Clear();
            DEPARTAMENTOS_TB_Sueldo.Clear();
        }

        /// ******************************************************************************************************************************************************************************************************
        
        private void Reload()
        {
            DEPARTAMENTOS_TB_NombreDepto.Clear();
            DEPARTAMENTOS_TB_Sueldo.Clear();
            DEPARTAMENTOS_LBL_Edit.Visible = false;

            ADMIN_DGV_Departamentos.DefaultCellStyle.ForeColor = Color.White;
            ADMIN_DGV_Departamentos.DefaultCellStyle.BackColor = Color.Black;

            //////////////////ENLACE SQL//////////////////////
            if (DB_SQLServer)
            {
                var linkDB = new EnlaceDB(); //enlace temporal con la db
                DataTable TablaDepartamentos = new DataTable(); //se crea una tabla
                TablaDepartamentos = linkDB.GetDepto(); //se acceden a los departamentos de la db y se guardan en la tabla creada
                //ADMIN_DGV_Departamentos.DataSource = TablaDepartamentos;

                ADMIN_DGV_Departamentos.Rows.Clear();

                // Añade cada fila del DataTable al DGV
                foreach (DataRow row in TablaDepartamentos.Rows)
                {
                    // Crea una nueva fila en el DataGridView
                    int rowIndex = ADMIN_DGV_Departamentos.Rows.Add();

                    //Se especifica bien qué columna de la tabla SQL se asigna a qué columna de DGV
                    ADMIN_DGV_Departamentos.Rows[rowIndex].Cells["NoDepto"].Value = row["noDepto"];
                    ADMIN_DGV_Departamentos.Rows[rowIndex].Cells["Nombre"].Value = row["nombreDpto"];
                    ADMIN_DGV_Departamentos.Rows[rowIndex].Cells["SueldoBase"].Value = row["sueldoBase"];
                }
            }
            ////////////////ENLACE CASSANDRA////////////////////
            else if (DB_Cassandra)
            { //q miedo Cassandra, la dama de las bases de datos
                var linkCassandra = new EnlaceCassandra();
                
                string[] columnas = { "noDepto", "nombreDpto", "sueldoBase" };
                List<Departamentos> tabla = linkCassandra.Get_All<Departamentos>(columnas, "DEPARTAMENTOS");
                ADMIN_DGV_Departamentos.Rows.Clear();
                foreach (var item in tabla)
                {
                    ADMIN_DGV_Departamentos.Rows.Add(item.noDepto, item.nombreDpto, item.sueldoBase);
                }
                
                //ADMIN_DGV_Departamentos.DataSource = tabla;
                ADMIN_DGV_Departamentos.Columns["noDepto"].Visible = false;
            }
        }

        /// ******************************************************************************************************************************************************************************************************
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PUESTOS_LBL_Edit_Click(object sender, EventArgs e)
        {

        }

    }
}
