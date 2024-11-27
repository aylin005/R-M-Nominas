using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MAD_AAVD_proyecto.Globals;

namespace MAD_AAVD_proyecto
{
    public partial class FormHeadCounter : Form
    {

        //**** M A N E J A D O R    D E   V E N T A N A
        public FormHeadCounter()
        {
            InitializeComponent();
        }

        private void Reload()
        {
            HDCOUNTER_CB_Departamento.Visible = false;
            label1.Visible = false;

            if (DB_Cassandra)
            {
                
                var linkCassandra = new EnlaceCassandra();

                //Obtener las dos tablas

                //Tabla departamento y puesto
                List<Headcounter> completeList = linkCassandra.GetHeadcounter(HDCOUNTER_DTP_Date.Value, HDCOUNTER_CB_Departamento.Text);
                //Esta lista se divide en dos:

                //Tabla departamento y puesto:
                List<Headcounter> depPuesto = completeList.Where(c => !string.IsNullOrEmpty(c.puesto) && c.puesto != "-1").ToList();
                //Tabla solo de departamento
                List<Headcounter> deptos = completeList.Where(c => !string.IsNullOrEmpty(c.puesto) && c.puesto == "-1").ToList();

                ///////////TABLA DEPARTAMENTOS CON PUESTOS///////////
                ADMIN_DGV_PuestoCant.Rows.Clear();

                // Añadir filas desde la lista
                foreach (var item in depPuesto)
                {
                    if (item.cantEmpMes.ContainsKey((byte)HDCOUNTER_DTP_Date.Value.Month)) // Verificar si el mes existe
                    {
                        ADMIN_DGV_PuestoCant.Rows.Add(
                            item.departamento,
                            item.puesto,
                            item.cantEmpMes[(byte)HDCOUNTER_DTP_Date.Value.Month] // Cantidad de empleados en el mes seleccionado
                        );
                    }
                }

                ///////////TABLA DEPARTAMENTOS///////////
                ADMIN_DGV_DepartamentoCant.Rows.Clear();

                // Añadir filas desde la lista
                foreach (var item in deptos)
                {
                    if (item.cantEmpMes.ContainsKey((byte)HDCOUNTER_DTP_Date.Value.Month)) // Verificar si el mes existe
                    {
                        ADMIN_DGV_DepartamentoCant.Rows.Add(
                            item.departamento,
                            item.cantEmpMes[(byte)HDCOUNTER_DTP_Date.Value.Month] // Cantidad de empleados en el mes seleccionado
                        );
                    }
                }
            }
           
        }
        private void FormHeadCounter_Load(object sender, EventArgs e) 
        {
            ADMIN_DGV_DepartamentoCant.DefaultCellStyle.ForeColor = Color.White;
            ADMIN_DGV_DepartamentoCant.DefaultCellStyle.BackColor = Color.Black;

            ADMIN_DGV_PuestoCant.DefaultCellStyle.ForeColor = Color.White;
            ADMIN_DGV_PuestoCant.DefaultCellStyle.BackColor = Color.Black;

            HDCOUNTER_CB_Departamento.Visible = false;
            label1.Visible = false;

            if (DB_Cassandra)
            {
                var linkCassandra = new EnlaceCassandra();
                //COMBOBOX DEPARTAMENTOS
                string[] columnasDepto = { "noDepto", "nombreDpto" };
                List<Departamentos> listaDepartamentos = linkCassandra.Get_All<Departamentos>(columnasDepto, "DEPARTAMENTOS");
                Departamentos todos = new Departamentos(0, "TODOS", 0);
                listaDepartamentos.Insert(0, todos); //Se inserta la opción de todos los departamentos
                HDCOUNTER_CB_Departamento.DataSource = listaDepartamentos;
                HDCOUNTER_CB_Departamento.DisplayMember = "nombreDpto";
                HDCOUNTER_CB_Departamento.ValueMember = "noDepto";

                Reload();
            }
            
        }
        private void HDCOUNTER_Title_Click(object sender, EventArgs e) { }

        private void HDCOUNTER_ComboBoxDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HDCOUNTER_DTP_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HDCOUNTER_DGV_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void HDCOUNTER_CB_orderOption_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void HDCOUNTER_Filter_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
