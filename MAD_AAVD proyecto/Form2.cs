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
    public partial class Form2 : Form
    {
        public Form2()
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
        }

        private void SM_Empleados_Lista_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
        }

        private void SM_Conceptos_Catalogo_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
        }

        private void SM_Conceptos_Aplicar_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
        }

        private void SM_Nomina_Generar_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
        }

        private void SM_Nomina_Reporte_Click(object sender, EventArgs e)
        {
            HideAllSubMenus();
        }
    }
}
