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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB_Cassandra = false;
            DB_SQLServer = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void inicioSesion_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_BTN_login_Click(object sender, EventArgs e)
        {
            if (DB_Cassandra || DB_SQLServer) //si se selecciono una base de datos entra
            {
                if (LOGIN_TB_username.Text == adminUser && LOGIN_TB_password.Text == adminPassword) //Para pruebas admin
                {
                    this.Hide();
                    new FormAdmin().ShowDialog();
                    this.Close();
                }
                else if (LOGIN_TB_username.Text == "empleado" && LOGIN_TB_password.Text == "1111") //Para pruebas empleado
                {
                    this.Hide();
                    new FormUsuario().ShowDialog();
                    this.Close();
                    //mandar el usuario validado
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                    LOGIN_TB_username.Clear();
                    LOGIN_TB_password.Clear();
                    LOGIN_TB_username.Focus();
                }
            }
            else//si no se selecciono una base de datos no entra
            {
                MessageBox.Show("Seleccione la base de datos que usará");
            }
        }

        private void LOGIN_BTN_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGIN_BTN_Cassandra_Click(object sender, EventArgs e)
        {
            DB_Cassandra = true;
            DB_SQLServer = false;
            MessageBox.Show("Seleccionó Cassandra como la base de datos");
        }

        private void LOGIN_BTN_Sql_Click(object sender, EventArgs e)
        {
            DB_Cassandra = false;
            DB_SQLServer = true;
            MessageBox.Show("Seleccionó SQL Server como la base de datos");
        }
    }
}
