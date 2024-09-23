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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private Form activeForm = null; //Guarda la ChildForm que esta abierta
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) //Si hay una form abierta la cerramos
                activeForm.Close();
            activeForm = childForm; // la form activa es la que se pasa por parametro
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            USER_PanelChildForm.Controls.Add(childForm);
            USER_PanelChildForm.Tag = childForm;
            childForm.BringToFront(); //logo
            childForm.Show();
        }

        private void SMUSER_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void USER_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SM_Puestos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEditarUsuario());
        }

        private void SMUSER_Recibo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReciboNomina());
        }
    }
}
