using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void LOGIN_BTN_login_Click(object sender, EventArgs e)
        {
            if (DB_Cassandra || DB_SQLServer) //si se selecciono una base de datos entra
            {
                bool checker = false; //si existe

                string aux = LOGIN_TB_password.Text;
                string hashPassword;
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    string hash = FormGestionEmpleados.GetHash(sha256Hash, aux);
                    hashPassword = hash;
                }
                hashPassword = $"'{hashPassword}'";

                int auxUser = Int32.Parse(LOGIN_TB_username.Text);

                if (LOGIN_TB_username.Text == adminUser && LOGIN_TB_password.Text == adminPassword) //Para pruebas admin
                {
                    this.Hide();
                    new FormAdmin().ShowDialog();
                    this.Close();
                }
                else
                {
                    if (!DB_Cassandra && DB_SQLServer)
                    {
                        var linkDB = new EnlaceDB();
                        checker = linkDB.CheckDB(hashPassword, auxUser);
                        if (checker == true) //Para pruebas empleado
                        {
                            this.Hide();
                            new FormUsuario().ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        if (DB_Cassandra && !DB_SQLServer)
                        {

                        }
                    }
                }
                if(checker == false)
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
