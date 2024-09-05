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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            if (LOGIN_TB_username.Text == "admin" && LOGIN_TB_password.Text == "1111") //Para pruebas
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                LOGIN_TB_username.Clear();
                LOGIN_TB_password.Clear();
                LOGIN_TB_username.Focus();
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
    }
}
