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
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
