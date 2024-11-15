using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MAD_AAVD_proyecto
{
    public partial class FormEditarUsuario : Form
    {
        int noEmp = 1; //Para pruebas, se debe traer variable del usuario activo en la sesion
        Empleados empleado;
        public FormEditarUsuario()
        {
            InitializeComponent();
            //pollito
        }

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            EDITEMP_LBL_Loading.Visible = true;
            loadDatosEmpleado();
            EDITEMP_LBL_Loading.Visible = false;
        }

        private void loadDatosEmpleado()
        {
            var linkCassandra = new EnlaceCassandra();

            string[] columnas = { "noEmpleado", "nombres", "apPaterno", "apMaterno", "contrasena", "fechaNacimiento", "departamento", "puesto", 
                "curp", "rfc", "nss", "calleNo", "colonia", "municipio", "estado", "cp", "banco", "noCuenta", "email", "telefonos", "salarioDiario", "fechaInicio" };
            empleado = linkCassandra.LastPuesto<Empleados>(columnas, noEmp.ToString());

            //Asignacion de valores a los TextBox
            EDITEMP_TB_NoEmp.Text = empleado.noEmpleado.ToString();
            EDITEMP_TB_Nombres.Text = empleado.nombres;
            EDITEMP_TB_ApPaterno.Text = empleado.apPaterno;
            EDITEMP_TB_ApMaterno.Text = empleado.apMaterno;
            EDITEMP_DTP_FechaNacimiento.Text = empleado.fechaNacimiento.ToString();
            EDITEMP_TB_Estado.Text = empleado.estado;
            EDITEMP_TB_Municipio.Text = empleado.municipio;
            EDITEMP_TB_CalleNo.Text = empleado.calleNo;
            EDITEMP_TB_Colonia.Text = empleado.colonia;
            EDITEMP_TB_Cp.Text = empleado.cp;
            EDITEMP_TB_Banco.Text = empleado.banco;
            EDITEMP_TB_NoCuenta.Text = empleado.noCuenta.ToString();
            EDITEMP_TB_Email.Text = empleado.email;

            List<string> telefonosList = empleado.telefonos.ToList();
            EDITEMP_TB_Tel1.Text = telefonosList[0].ToString();
            if (telefonosList.Count > 1)
                EDITEMP_TB_Tel2.Text = telefonosList[1].ToString();

            //EMP_TB_Curp.Text = empleado.curp;
            //EMP_TB_Nss.Text = empleado.nss;
            //EMP_TB_Rfc.Text = empleado.rfc;

            EDITEMP_TB_Password.Text = empleado.contrasena;

        }

        private void EDITEMP_BTN_Guardar_Click(object sender, EventArgs e)
        {
            EDITEMP_LBL_Loading.Visible = true;
            //Obtiene el ultimo puesto del empleado
            var linkCassandra = new EnlaceCassandra();
            
            if(empleado != null)
            {
                string contrasena = EDITEMP_TB_Password.Text; // Se guardara como HASH
                string calleNo = $"'{EDITEMP_TB_CalleNo.Text}'";
                string colonia = $"'{EDITEMP_TB_Colonia.Text}'";
                string cEstado = $"'{EDITEMP_TB_Estado.Text}'";
                string cMunicipio = $"'{EDITEMP_TB_Municipio.Text}'";
                string cp = $"'{EDITEMP_TB_Cp.Text}'";
                string cBanco = $"'{EDITEMP_TB_Banco.Text}'";
                string cNoCuenta = EDITEMP_TB_NoCuenta.Text;
                string email = $"'{EDITEMP_TB_Email.Text}'";

                //CONVERTIR CONTRASEÑA A HASH
                string hashPassword;
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    string hash = FormGestionEmpleados.GetHash(sha256Hash, contrasena);
                    hashPassword = hash;
                    Console.WriteLine($"The SHA256 hash of {contrasena} is: {hashPassword}.");
                }
                hashPassword = $"'{hashPassword}'";

                string telefono1 = EDITEMP_TB_Tel1.Text;
                string telefono2 = EDITEMP_TB_Tel2.Text;

                string telefonos;
                if (telefono2 != "")
                    telefonos = "{'" + telefono1 + "', '" + telefono2 + "'}";
                else
                    telefonos = "{'" + telefono1 + "'}";

                ////////INSERTAR TODO EN LA TABLA////////////
                string[] primaryKey = { "noEmpleado", "fechaInicio", "departamento", "puesto", "salarioDiario" };
                string[] pkValues = { noEmp.ToString(), $"'{empleado.fechaInicio.ToString()}'", $"'{ empleado.departamento }'", $"'{empleado.puesto }'", empleado.salarioDiario.ToString() };
                string[] columnas = {"contrasena", "calleNo", "colonia", "municipio", "estado", "cp", "banco", "noCuenta", "email", "telefonos" };
                string[] values = { hashPassword, calleNo, colonia, cMunicipio, cEstado, cp, cBanco, cNoCuenta, email, telefonos };
                linkCassandra.Insert(true, "EMPLEADOS", primaryKey, pkValues, columnas, values);
                MessageBox.Show("Cambios guardados exitosamente!");
            }
            else
            {
                MessageBox.Show("No se puedo guardar la información", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            EDITEMP_LBL_Loading.Visible = false;
        }
    }

}
