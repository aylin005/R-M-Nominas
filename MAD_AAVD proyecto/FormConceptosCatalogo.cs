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
    public partial class FormConceptosCatalogo : Form
    {
        public FormConceptosCatalogo()
        {
            InitializeComponent();
        }

        private void FormConceptosCatalogo_Load(object sender, EventArgs e)
        {
            ADMIN_DGV_Conceptos.DefaultCellStyle.ForeColor = Color.Black;
            ADMIN_DGV_Conceptos.Rows.Add(001, "BONO DE ASISTENCIA", "Percepción", "$150.00", "", "No");
            ADMIN_DGV_Conceptos.Rows.Add(002, "FALTA", "Deducción", "$180.00", "", "No");
            ADMIN_DGV_Conceptos.Rows.Add(003, "ISR", "Deducción", "", "10.88%", "Sí");
        }
    }
}
