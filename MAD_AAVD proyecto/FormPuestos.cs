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
    public partial class FormPuestos : Form
    {
        public FormPuestos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPuestos_Load(object sender, EventArgs e)
        {
            ADMIN_DGV_Puestos.DefaultCellStyle.ForeColor = Color.White;
            ADMIN_DGV_Puestos.DefaultCellStyle.BackColor = Color.Black;

            //ADMIN_DGV_Puestos.Rows.Add(001, "Programador Junior","2.0"); //ejemplo
            //ADMIN_DGV_Puestos.Rows.Add(002, "Programador Senior", "4.0");
            //ADMIN_DGV_Puestos.Rows.Add(003, "Interno", "1.5");
            //ADMIN_DGV_Puestos.Rows.Add(004, "Ayudante", "1.3");

            var linkDB = new EnlaceDB();
            DataTable TablaPuestos = new DataTable();
            TablaPuestos = linkDB.get_Puestos();
            ADMIN_DGV_Puestos.DataSource = TablaPuestos;
        }

        private void PUESTOS_BTN_Registrar_Click(object sender, EventArgs e)
        {
            if (PUESTOS_TB_Nombre.Text.Length == 0 || PUESTOS_TB_Nivel.Text.Length == 0) // si los campos estan vacios
                MessageBox.Show("Llene todos los campos");
            else
            {
                var nombrePuesto = PUESTOS_TB_Nombre.Text;
                var nivelPuesto = float.Parse(PUESTOS_TB_Nivel.Text);

                var linkDB = new EnlaceDB();
                bool ok = false;
                ok = linkDB.GestionPuestos("I", 0, nombrePuesto, nivelPuesto);//noPuesto 0 porq no importa

                if (ok)
                    MessageBox.Show("Se guardo en la BD");
                else
                    MessageBox.Show("Error en el guardado");
            }
        }

        private void PUESTOS_BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (ADMIN_DGV_Puestos.CurrentRow != null) //hay fila seleccionada
            {
                Int16 noPuesto = Int16.Parse(ADMIN_DGV_Puestos.CurrentRow.Cells["noPuesto"].Value.ToString());
                //Eliminar de la base de datos
                var linkDB = new EnlaceDB();
                bool ok = false;
                ok = linkDB.GestionPuestos("D", noPuesto, null, 0.0f);

                if (ok)
                    MessageBox.Show("Se elimino de la BD");
                else
                    MessageBox.Show("Error en el proceso");
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.");
            }
        }
    }
}
