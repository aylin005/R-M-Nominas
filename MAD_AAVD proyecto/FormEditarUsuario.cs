using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static MAD_AAVD_proyecto.Globals;

namespace MAD_AAVD_proyecto
{
    public partial class FormEditarUsuario : Form
    {
        int noEmp = activeUser; //Para pruebas, se debe traer variable del usuario activo en la sesion
        Empleados empleado;
        bool datosCargados = false;
        public FormEditarUsuario()
        {
            InitializeComponent();
            //pollito
        }

        private void Reload()
        {
            if (DB_SQLServer)
            {
                var linkDB = new EnlaceDB();

                EDITEMP_TB_Municipio.Visible = false;
                EDITEMP_TB_Estado.Visible = false;
                panel8.Visible = false;
                panel7.Visible = false;

                DataTable TablaEstados = linkDB.GetEstadosBancos(true);
                EDITEMP_CB_Estado.DataSource = TablaEstados;
                EDITEMP_CB_Estado.DisplayMember = "nombreEstado";
                EDITEMP_CB_Estado.ValueMember = "noEstado";

                if (datosCargados)
                {
                    DataTable TablaMunicipios = linkDB.GetMunicipios(EDITEMP_CB_Estado.Text);
                    EDITEMP_CB_Municipio.DataSource = TablaMunicipios;
                    EDITEMP_CB_Municipio.DisplayMember = "nombreMunicipio";
                    EDITEMP_CB_Municipio.ValueMember = "noMunicipio";
                }

                DataTable TablaBancos = linkDB.GetEstadosBancos(false);
                EDITEMP_CB_Banco.DataSource = TablaBancos;
                EDITEMP_CB_Banco.DisplayMember = "nombreBanco";
                EDITEMP_CB_Banco.ValueMember = "IDBanco";

            }
            EDITEMP_LBL_Loading.Visible = true;
            loadDatosEmpleado();
            EDITEMP_LBL_Loading.Visible = false;
        }
        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void loadDatosEmpleado()
        {
            if (DB_SQLServer)
            {
                var linkDB = new EnlaceDB();
                DataTable empleado = linkDB.GetEditarEmpleado(activeUser);

                if (empleado.Rows.Count > 0)
                {
                    //Asignar cada dato a variables
                    DataRow row = empleado.Rows[0];

                    int noEmp = Convert.ToInt32(row["noEmpleado"]);
                    string nombres = row["nombres"].ToString();
                    string apPaterno = row["apellidoP"].ToString();
                    string apMaterno = row["apellidoM"].ToString();
                    string password = row["passwordHash"].ToString();
                    DateTime fechaNacm = Convert.ToDateTime(row["fechaNacimiento"].ToString());
                    string calleNo = row["calleNombre"].ToString();
                    string colonia = row["colonia"].ToString();
                    int Municipio = Convert.ToInt32(row["noMunicipio"]);
                    int Estado = Convert.ToInt32(row["noEstado"]);
                    int cp = Convert.ToInt32(row["codigoPostal"]);
                    int banco = Convert.ToInt32(row["IDBanco"]);
                    int noCuenta = Convert.ToInt32(row["noCuenta"]);
                    string email= row["email"].ToString();
                    string tel1 = row["telefono1"].ToString();
                    string tel2 = row["telefono2"].ToString();


                    // Asignar a los labels
                    EDITEMP_TB_NoEmp.Text = noEmp.ToString();
                    EDITEMP_TB_Nombres.Text = nombres;
                    EDITEMP_TB_ApPaterno.Text = apPaterno;
                    EDITEMP_TB_ApMaterno.Text = apMaterno;
                    EDITEMP_TB_Password.Text = password;
                    EDITEMP_DTP_FechaNacimiento.Value = fechaNacm;
                    EDITEMP_TB_CalleNo.Text = calleNo;
                    EDITEMP_TB_Colonia.Text = colonia;

                    EDITEMP_CB_Estado.SelectedValue = Estado;
                    EDITEMP_TB_Cp.Text = cp.ToString();
                    EDITEMP_CB_Banco.SelectedValue = banco;
                    EDITEMP_TB_NoCuenta.Text = noCuenta.ToString();
                    EDITEMP_TB_Email.Text = email;
                    EDITEMP_TB_Tel1.Text = tel1;
                    EDITEMP_TB_Tel2.Text = tel2;

                    DataTable TablaMunicipios = linkDB.GetMunicipios(EDITEMP_CB_Estado.Text);
                    EDITEMP_CB_Municipio.DataSource = TablaMunicipios;
                    EDITEMP_CB_Municipio.DisplayMember = "nombreMunicipio";
                    EDITEMP_CB_Municipio.ValueMember = "noMunicipio";
                    EDITEMP_CB_Municipio.SelectedValue = Municipio;

                    datosCargados = true;
                }
            }
            else if (DB_Cassandra)
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
        }

        private void EDITEMP_BTN_Guardar_Click(object sender, EventArgs e)
        {
            if(DB_SQLServer)
            {
                var linkDB = new EnlaceDB();
                string contrasena = EDITEMP_TB_Password.Text; // Se guardara como HASH
                string calleNo = EDITEMP_TB_CalleNo.Text;
                string colonia = EDITEMP_TB_Colonia.Text;
                int Estado = (int)EDITEMP_CB_Estado.SelectedValue;
                int cMunicipio = (int)EDITEMP_CB_Municipio.SelectedValue;
                string cp = EDITEMP_TB_Cp.Text;
                int Banco = (int)EDITEMP_CB_Banco.SelectedValue;
                int NoCuenta = int.Parse(EDITEMP_TB_NoCuenta.Text);
                string email = EDITEMP_TB_Email.Text;
                long tel1 = long.Parse(EDITEMP_TB_Tel1.Text);
                long tel2 = long.Parse(EDITEMP_TB_Tel2.Text);

                //Detectar si ya es hash******
                string hashPassword;
                if (!IsSHA256Hash(contrasena)) //Si no es
                {
                    //CONVERTIR CONTRASEÑA A HASH
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        string hash = GetHash(sha256Hash, contrasena);
                        hashPassword = hash;
                        Console.WriteLine($"The SHA256 hash of {contrasena} is: {hashPassword}.");
                    }
                }
                else // si ya es hash la deja igual
                {
                    hashPassword = contrasena;
                }

                linkDB.GestionEmpleados("e", (short)activeUser, "", "", "", hashPassword, calleNo, colonia, cMunicipio, 
                    Estado, cp, Banco, NoCuenta, email, tel1, tel2, "", "", "", 0, 0, DateTime.Now, DateTime.Now);
                loadDatosEmpleado();

            }
            else if (DB_Cassandra)
            {
                EDITEMP_LBL_Loading.Visible = true;
                //Obtiene el ultimo puesto del empleado
                var linkCassandra = new EnlaceCassandra();

                if (empleado != null)
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
                    string[] pkValues = { noEmp.ToString(), $"'{empleado.fechaInicio.ToString()}'", $"'{empleado.departamento}'", $"'{empleado.puesto}'", empleado.salarioDiario.ToString() };
                    string[] columnas = { "contrasena", "calleNo", "colonia", "municipio", "estado", "cp", "banco", "noCuenta", "email", "telefonos" };
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

        public bool IsSHA256Hash(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            // Verificar que tenga exactamente 64 caracteres y sean hexadecimales
            return Regex.IsMatch(input, @"\A\b[0-9a-fA-F]{64}\b\Z");
        }

        public static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            foreach (byte b in data)
            {
                sBuilder.Append(b.ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void EDITEMP_CB_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(datosCargados)
                Reload();
        }
    }

}
