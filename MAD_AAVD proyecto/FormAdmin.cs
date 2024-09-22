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
    public partial class FormAdmin : Form
    {
        FormGestionEmpleados GestionEmpleados;

        public FormAdmin()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            SM_Panel_SubMenuNomina.Visible = false;
            SM_Panel_SubMenuConceptos.Visible = false;
            SM_Panel_SubMenuEmpleados.Visible = false;
        }

        private void HideBtnSubMenu(Panel panel) //cierra el submenu de cierto boton
        {
            if(panel.Visible)
                panel.Visible = false;
        }

        private void HideAllSubMenus() //cierra todos los submenus
        {
            HideBtnSubMenu(SM_Panel_SubMenuNomina);
            HideBtnSubMenu(SM_Panel_SubMenuConceptos);
            HideBtnSubMenu(SM_Panel_SubMenuEmpleados);
        }

        private void ShowSubMenu(Panel panel) //limpia los submenus abiertos
        {
            if(!panel.Visible)
            {
                HideAllSubMenus();
                panel.Visible = true;
            }
            else
            {
                HideBtnSubMenu(panel);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void SM_Empleados_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SM_Panel_SubMenuEmpleados);
        }

        private void SM_Conceptos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SM_Panel_SubMenuConceptos);
        }

        private void SM_Nomina_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SM_Panel_SubMenuNomina);
        }

        private void SM_Empleados_Gestion_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
            OpenChildForm(new FormGestionEmpleados());
        }

        private void SM_Empleados_Lista_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
            OpenChildForm(new FormListaEmpleados());
        }

        private void SM_Conceptos_Catalogo_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
            OpenChildForm(new FormConceptosCatalogo());
        }

        private void SM_Conceptos_Aplicar_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
            OpenChildForm(new FormConceptosAplicar());
        }

        private void SM_Nomina_Generar_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
            OpenChildForm(new FormNominaGenerar());
        }

        private void SM_Nomina_Reporte_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
            OpenChildForm(new FormNominaReporte());
        }

        private void SM_Headcounter_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
            OpenChildForm(new FormHeadCounter());
        }

        private void ADMIN_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null; //Guarda la ChildForm que esta abierta
        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null) //Si hay una form abierta la cerramos
                activeForm.Close();
            activeForm = childForm; // la form activa es la que se pasa por parametro
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ADMIN_PanelChildForm.Controls.Add(childForm);
            ADMIN_PanelChildForm.Tag = childForm;
            childForm.BringToFront(); //logo
            childForm.Show();
        }

        private void SM_Puestos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPuestos());
        }

        private void SM_Departamentos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDepartamentos());
        }

        private void SM_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void ADMIN_PanelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
