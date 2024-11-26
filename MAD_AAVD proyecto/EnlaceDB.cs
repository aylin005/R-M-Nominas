/*
Autor: Alejandro Villarreal
LMAD
PARA EL PROYECTO ES OBLIGATORIO EL USO DE ESTA CLASE, EN EL SENTIDO DE QUE LOS DATOS DE CONEXION AL SERVIDOR ESTAN DEFINIDOS EN EL App.Config Y NO TENER ESOS DATOS EN CODIGO DURO DEL PROYECTO.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Globalization;

namespace MAD_AAVD_proyecto
{
    public class EnlaceDB
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }

        /// ******************************************************************************************************************************************************************************************************

        private static void conectar()
        {
            /*
			Para que funcione el ConfigurationManager
			en la sección de "Referencias" de su proyecto, en el "Solution Explorer"
			dar clic al botón derecho del mouse y dar clic a "Add Reference"
			Luego elegir la opción System.Configuration
			
			tal como lo vimos en clase.
			*/
            string cnn = ConfigurationManager.ConnectionStrings["MAD"].ToString();
            _conexion = new SqlConnection(cnn);
            _conexion.Open();
        }

        /// ******************************************************************************************************************************************************************************************************
        private static void desconectar()
        {
            _conexion.Close();
        }

        /// ******************************************************************************************************************************************************************************************************
        public bool Autentificar(string us, string ps)
        {
            bool isValid = false;
            try
            {
                conectar();
                string qry = "SP_ValidaUser";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@u", SqlDbType.Char, 20);
                parametro1.Value = us;
                var parametro2 = _comandosql.Parameters.Add("@p", SqlDbType.Char, 20);
                parametro2.Value = ps;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    isValid = true;
                }

            }
            catch (SqlException e)
            {
                isValid = false;
            }
            finally
            {
                desconectar();
            }

            return isValid;
        }

     
        public DataTable getTable(string pTableName) // SOLO PARA MOSTRAR LOS DATOS REGISTRADOS -> es decir, si el usuario no ha filtrado nada
        {//NO podemos usar esta funcion porque seria hardcode, hay que hacerlo desde el sp
            string msg = "Se han obtenido los datos de la tabla";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry;
                if (pTableName != "EMPLEADOS")
                {
                    qry = "SELECT * FROM " + pTableName;
                }
                else
                {
                     qry = @" 
                      SELECT noEmpleado, 
                      CONCAT(nombres, ' ', apellidoP, ' ', apellidoM) AS nombre,  nombreDpto, nombrePuesto, activo
                      FROM HISTORIA_EMPLEOS
                      JOIN EMPLEADOS ON EMPLEADOS.noEmpleado = HISTORIA_EMPLEOS.empleado
                      JOIN DEPARTAMENTOS ON DEPARTAMENTOS.noDepto = HISTORIA_EMPLEOS.departamento
                      JOIN PUESTOS ON PUESTOS.noPuesto = HISTORIA_EMPLEOS.puesto
                      WHERE HISTORIA_EMPLEOS.fechaFin IS NULL;"; //esto estaba en un procedure, pero me trajo problemas de parametros y mejor lo quite aaa

                }
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.Text;
                 _comandosql.CommandTimeout = 1200;
                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);


                MessageBox.Show(msg, "(!)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                msg = "(!) Hubo un error en la base de datos: \n" + e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        /// ******************************************************************************************************************************************************************************************************

        // Ejemplo de método para recibir una consulta en forma de tabla
        // Cuando el SP ejecutará un SELECT
        //public DataTable get_Deptos(string opc)
        //{
        //    var msg = "";
        //    DataTable tabla = new DataTable();
        //    try
        //    {
        //        conectar();
        //        string qry = "sp_Gestiona_Deptos";
        //        _comandosql = new SqlCommand(qry, _conexion);
        //        _comandosql.CommandType = CommandType.StoredProcedure;
        //        _comandosql.CommandTimeout = 1200;

        //        var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1);
        //        parametro1.Value = opc;


        //        _adaptador.SelectCommand = _comandosql;
        //        _adaptador.Fill(tabla);
        //        // la ejecución del SP espera que regrese datos en formato tabla

        //    }
        //    catch (SqlException e)
        //    {
        //        msg = "Excepción de base de datos: \n";
        //        msg += e.Message;
        //        MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    }
        //    finally
        //    {
        //        desconectar();
        //    }

        //    return tabla;
        //}

        // Ejemplo de método para ejecutar un SP que no se espera que regrese información, 
        // solo que ejecute ya sea un INSERT, UPDATE o DELETE

        /// ******************************************************************************************************************************************************************************************************

        public bool GestionPuestos(string accion, Int16 noPuesto, string nombrePuesto, float nivelSalarial)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "sp_PUESTOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                // Parámetro obligatorio
                var parameter1 = _comandosql.Parameters.Add("@Action", SqlDbType.Char, 1);
                parameter1.Value = accion;

                // Solo agregar estos parámetros si la acción es "Insertar"
                if (accion == "I" || accion == "U")
                {
                    var parameter2 = _comandosql.Parameters.Add("@NombrePuesto", SqlDbType.VarChar, 40);
                    parameter2.Value = nombrePuesto ?? (object)DBNull.Value;  // Manejo de nulos

                    var parameter3 = _comandosql.Parameters.Add("@NivelSalarial", SqlDbType.Decimal, 5);
                    parameter3.Value = nivelSalarial;
                }

                if (accion == "D" || accion == "U")
                {
                    var parameter4 = _comandosql.Parameters.Add("@NoPuesto", SqlDbType.SmallInt, 1);
                    parameter4.Value = noPuesto;
                }

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        /// ******************************************************************************************************************************************************************************************************

        public bool GestionDeptos(string pOpcion, Int16 pNoDepto, string pNombreDepto, decimal pSueldoBase)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "sp_DEPARTAMENTOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                // Parámetro obligatorio
                var parameter1 = _comandosql.Parameters.Add("@Action", SqlDbType.Char, 1);
                parameter1.Value = pOpcion;

                // Solo agregar estos parámetros si la acción es "Insertar"
                if (pOpcion == "I" || pOpcion == "U")
                {
                    var parameter2 = _comandosql.Parameters.Add("@NombreDepto", SqlDbType.VarChar, 40);
                    parameter2.Value = pNombreDepto ?? (object)DBNull.Value;  // Manejo de nulos

                    var parameter3 = _comandosql.Parameters.Add("@SueldoBase", SqlDbType.Decimal, 5);
                    parameter3.Value = pSueldoBase;
                }

                if (pOpcion == "D" || pOpcion == "U")
                {
                    var parameter4 = _comandosql.Parameters.Add("@NoDepto", SqlDbType.SmallInt, 1);
                    parameter4.Value = pNoDepto;
                }

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }

        /// ******************************************************************************************************************************************************************************************************

        public bool GestionConceptos(string pOpcion, Int16 pNoConcepto, string pNombre, decimal pCuota, decimal pPorcentaje, bool pTipo, bool pFijo)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "sp_CONCEPTOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parameter1 = _comandosql.Parameters.Add("@pAction", SqlDbType.Char, 1); //action representa que haremos en el procedure
                parameter1.Value = pOpcion;

                if (pOpcion == "I" || pOpcion == "U")
                {
                    var parameter2 = _comandosql.Parameters.Add("@pNombreConcepto", SqlDbType.VarChar, 50);
                    parameter2.Value = pNombre ?? (object)DBNull.Value;  // Manejo de nulos

                    var parameter3 = _comandosql.Parameters.Add("@pCuota", SqlDbType.Decimal, 5);
                    if (pCuota == 0)
                        parameter3.Value = DBNull.Value; //para cuando lleve un nulo
                    else
                        parameter3.Value = pCuota;

                    var parameter4 = _comandosql.Parameters.Add("@pPorcentaje", SqlDbType.Decimal, 5);
                    if (pPorcentaje == 0)
                        parameter4.Value = DBNull.Value;
                    else
                        parameter4.Value = pPorcentaje;

                    var parameter6 = _comandosql.Parameters.Add("@pFijo", SqlDbType.Bit, 1);
                    parameter6.Value = pFijo;

                    var parameter7 = _comandosql.Parameters.Add("@pPercepcion", SqlDbType.Bit, 1);
                    parameter7.Value = pTipo;
                }

                if (pOpcion == "D" || pOpcion == "U")
                {
                    var parameter5 = _comandosql.Parameters.Add("@pNoConcepto", SqlDbType.SmallInt, 1);
                    parameter5.Value = pNoConcepto;
                }

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }

        /// ******************************************************************************************************************************************************************************************************
        public bool GestionEmpleados(string pOpcion, Int16 noEmp, string pNom, string pApP, string pApM, string pPassword, string pCalleNo, string pCol,
            int pMun, int pEst, string pCP, int pBanco, int pNoC, string pEmail, Int64 pT1, Int64 pT2, string pCURP, string pNSS, string pRFC,
            int pDep, int pPuesto, DateTime pNac, DateTime pFecha)//DateTime pFiltro)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "sp_EMPLEADOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parameter1 = _comandosql.Parameters.Add("@pAction", SqlDbType.Char, 1); //action representa que haremos en el procedure
                parameter1.Value = pOpcion;

                if (pOpcion == "I")
                {
                    var parameter2 = _comandosql.Parameters.Add("@pNombres", SqlDbType.VarChar, 30);
                    parameter2.Value = pNom;
                    var parameter3 = _comandosql.Parameters.Add("@pApellidoP", SqlDbType.VarChar, 30);
                    parameter3.Value = pApP;
                    var parameter4 = _comandosql.Parameters.Add("@pApellidoM", SqlDbType.VarChar, 30);
                    parameter4.Value = pApM;
                    var parameter5 = _comandosql.Parameters.Add("@pPasswordHash", SqlDbType.VarChar, 255);
                    parameter5.Value = pPassword;
                    var parameter6 = _comandosql.Parameters.Add("@pIdDepartamento", SqlDbType.SmallInt, 4);
                    parameter6.Value = pDep;
                    var parameter7 = _comandosql.Parameters.Add("@pIdPuesto", SqlDbType.Int, 8);
                    parameter7.Value = pPuesto;
                    var parameter8 = _comandosql.Parameters.Add("@pFechaNacimiento", SqlDbType.Date, 3);
                    parameter8.Value = pNac;
                    var parameter9 = _comandosql.Parameters.Add("@pCURP", SqlDbType.VarChar, 20);
                    parameter9.Value = pCURP;
                    var parameter10 = _comandosql.Parameters.Add("@pNss", SqlDbType.VarChar, 15);
                    parameter10.Value = pNSS;
                    var parameter11 = _comandosql.Parameters.Add("@pRfc", SqlDbType.VarChar, 15);
                    parameter11.Value = pRFC;
                    var parameter12 = _comandosql.Parameters.Add("@pCalleNombre", SqlDbType.VarChar, 30);
                    parameter12.Value = pCalleNo;
                    var parameter13 = _comandosql.Parameters.Add("@pColonia", SqlDbType.VarChar, 30);
                    parameter13.Value = pCol;
                    var parameter14 = _comandosql.Parameters.Add("@pIdMunicipio", SqlDbType.Int, 8);
                    parameter14.Value = pMun;
                    var parameter15 = _comandosql.Parameters.Add("@pIdEstado", SqlDbType.Int, 8);
                    parameter15.Value = pEst;
                    var parameter16 = _comandosql.Parameters.Add("@pIdBanco", SqlDbType.Int, 8);
                    parameter16.Value = pBanco;
                    var parameter17 = _comandosql.Parameters.Add("@pNoCuenta", SqlDbType.Int, 8);
                    parameter17.Value = pNoC;
                    var parameter18 = _comandosql.Parameters.Add("@pCodPostal", SqlDbType.VarChar, 6);
                    parameter18.Value = pCP;
                    var parameter19 = _comandosql.Parameters.Add("@pEmail", SqlDbType.VarChar, 100);
                    if (pEmail == "No registrado")
                        parameter19.Value = DBNull.Value;
                    else
                        parameter19.Value = pEmail;
                    var parameter20 = _comandosql.Parameters.Add("@pTelefono1", SqlDbType.BigInt, 8);
                    parameter20.Value = pT1;
                    var parameter21 = _comandosql.Parameters.Add("@pTelefono2", SqlDbType.BigInt, 8);
                    parameter21.Value = pT2;

                    var parameter22 = _comandosql.Parameters.Add("@pFechaIngreso", SqlDbType.Date, 3);
                    parameter22.Value = pFecha.Date;
                }
                if (pOpcion == "U")
                {
                    var parameter2 = _comandosql.Parameters.Add("@pNombres", SqlDbType.VarChar, 30);
                    parameter2.Value = pNom;
                    var parameter3 = _comandosql.Parameters.Add("@pApellidoP", SqlDbType.VarChar, 30);
                    parameter3.Value = pApP;
                    var parameter4 = _comandosql.Parameters.Add("@pApellidoM", SqlDbType.VarChar, 30);
                    parameter4.Value = pApM;
                    var parameter5 = _comandosql.Parameters.Add("@pPasswordHash", SqlDbType.VarChar, 255);
                    parameter5.Value = pPassword;
                    var parameter6 = _comandosql.Parameters.Add("@pIdDepartamento", SqlDbType.SmallInt, 4);
                    parameter6.Value = pDep;
                    var parameter7 = _comandosql.Parameters.Add("@pIdPuesto", SqlDbType.Int, 8);
                    parameter7.Value = pPuesto;
                    var parameter8 = _comandosql.Parameters.Add("@pFechaNacimiento", SqlDbType.Date, 3);
                    parameter8.Value = pNac;
                    var parameter9 = _comandosql.Parameters.Add("@pCURP", SqlDbType.VarChar, 20);
                    parameter9.Value = pCURP;
                    var parameter10 = _comandosql.Parameters.Add("@pNss", SqlDbType.VarChar, 15);
                    parameter10.Value = pNSS;
                    var parameter11 = _comandosql.Parameters.Add("@pRfc", SqlDbType.VarChar, 15);
                    parameter11.Value = pRFC;
                    var parameter12 = _comandosql.Parameters.Add("@pCalleNombre", SqlDbType.VarChar, 30);
                    parameter12.Value = pCalleNo;
                    var parameter13 = _comandosql.Parameters.Add("@pColonia", SqlDbType.VarChar, 30);
                    parameter13.Value = pCol;
                    var parameter14 = _comandosql.Parameters.Add("@pIdMunicipio", SqlDbType.Int, 8);
                    parameter14.Value = pMun;
                    var parameter15 = _comandosql.Parameters.Add("@pIdEstado", SqlDbType.Int, 8);
                    parameter15.Value = pEst;
                    var parameter16 = _comandosql.Parameters.Add("@pIdBanco", SqlDbType.Int, 8);
                    parameter16.Value = pBanco;
                    var parameter17 = _comandosql.Parameters.Add("@pNoCuenta", SqlDbType.Int, 8);
                    parameter17.Value = pNoC;
                    var parameter18 = _comandosql.Parameters.Add("@pCodPostal", SqlDbType.VarChar, 6);
                    parameter18.Value = pCP;
                    var parameter19 = _comandosql.Parameters.Add("@pEmail", SqlDbType.VarChar, 100);
                    if (pEmail == "No registrado")
                        parameter19.Value = DBNull.Value;
                    else
                        parameter19.Value = pEmail;
                    var parameter20 = _comandosql.Parameters.Add("@pTelefono1", SqlDbType.BigInt, 8);
                    parameter20.Value = pT1;
                    var parameter21 = _comandosql.Parameters.Add("@pTelefono2", SqlDbType.BigInt, 8);
                    parameter21.Value = pT2;

                    var parameter22 = _comandosql.Parameters.Add("@pFechaInicio", SqlDbType.Date, 3);
                    parameter22.Value = pFecha.Date;
                    var parameter23 = _comandosql.Parameters.Add("@pNoEmpleado", SqlDbType.SmallInt, 1);
                    parameter23.Value = noEmp;
                }

                if (pOpcion == "B")
                {
                    var parameter2 = _comandosql.Parameters.Add("@pNoEmpleado", SqlDbType.SmallInt, 1);
                    parameter2.Value = noEmp;
                    var parameter3 = _comandosql.Parameters.Add("@pFechaBaja", SqlDbType.Date, 3);
                    parameter3.Value = pFecha.Date;
                }

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }

        //////////////////////
        public bool insertConcepto(bool isDepto, int concepto, DateTime fecha, int noEmp = 0, int noDepto = 0)
        {
            var msg = "";
            var add = true;

            char pOpcion;

            if (isDepto)
                pOpcion = 'd';
            else
                pOpcion = 'c';

            try
            {
                conectar();
                string qry = "sp_RECIBOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parameter1 = _comandosql.Parameters.Add("@pAction", SqlDbType.Char, 1); //action representa que haremos en el procedure
                parameter1.Value = pOpcion;

                var parameter2 = _comandosql.Parameters.Add("@concepto", SqlDbType.Int);
                parameter2.Value = concepto;  // Manejo de nulos

                var parameter3 = _comandosql.Parameters.Add("@fecha", SqlDbType.Date);
                parameter3.Value = fecha.Date; //para cuando lleve un nulo

                if (pOpcion == 'd') //Se esta aplicando a departamento
                {
                    var parameter4 = _comandosql.Parameters.Add("@departamento", SqlDbType.Int);
                        parameter4.Value = noDepto;
                }

                if (pOpcion == 'c') //Se esta aplicando a un empleado en especifico
                {
                    var parameter5 = _comandosql.Parameters.Add("@noEmpleado", SqlDbType.Int);
                    parameter5.Value = noEmp;
                }

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }


        //******************* P A R A     S E L E C T S
        public void GetPuesto(Int16 noPuesto, TextBox txtNombrePuesto, TextBox txtNivelSalarial)
        {
            try
            {
                conectar(); // Asegúrate de que esta función establezca la conexión a la base de datos

                string qry = "sp_PUESTOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                // Parámetros del procedimiento almacenado
                var parameter1 = _comandosql.Parameters.Add("@Action", SqlDbType.Char, 1);
                parameter1.Value = 'S';  // Acción 'S' para seleccionar
                var parameter2 = _comandosql.Parameters.Add("@NoPuesto", SqlDbType.SmallInt);
                parameter2.Value = noPuesto;

                // Ejecutamos el comando y obtenemos los resultados
                SqlDataReader reader = _comandosql.ExecuteReader();

                if (reader.Read()) // Si hay datos, llenamos los TextBox
                {
                    txtNombrePuesto.Text = reader["nombrePuesto"].ToString();
                    txtNivelSalarial.Text = reader["nivelSalarial"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el puesto especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close(); // Cerramos el lector
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable GetPuesto()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_PUESTOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Action", SqlDbType.Char, 1);
                parametro1.Value = 'G';

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        /// ******************************************************************************************************************************************************************************************************

        public void GetDepto(Int16 noDepto, TextBox txtNombreDepto, TextBox txtSueldoBase)
        {
            try
            {
                conectar(); // Asegúrate de que esta función establezca la conexión a la base de datos

                string qry = "sp_DEPARTAMENTOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                // Parámetros del procedimiento almacenado
                var parameter1 = _comandosql.Parameters.Add("@Action", SqlDbType.Char, 1);
                parameter1.Value = 'S';  // Acción 'S' para seleccionar
                var parameter2 = _comandosql.Parameters.Add("@NoDepto", SqlDbType.SmallInt);
                parameter2.Value = noDepto;

                // Ejecutamos el comando y obtenemos los resultados
                SqlDataReader reader = _comandosql.ExecuteReader();

                if (reader.Read()) // Si hay datos, llenamos los TextBox
                {
                    txtNombreDepto.Text = reader["nombreDpto"].ToString();
                    txtSueldoBase.Text = reader["sueldoBase"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el departamento especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close(); // Cerramos el lector
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
        }
        public DataTable GetDepto()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_DEPARTAMENTOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Action", SqlDbType.Char, 1);
                parametro1.Value = 'G';

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        /// ******************************************************************************************************************************************************************************************************

        public void GetConceptos(Int16 noConcepto, TextBox txtNombreConcepto, TextBox txtCuota, TextBox txtPorcentaje, ComboBox cbEsFijo, ComboBox cbEsTipo)
        {
            try
            {
                conectar();
                string qry = "sp_CONCEPTOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parameter1 = _comandosql.Parameters.Add("@pAction", SqlDbType.Char, 1);
                parameter1.Value = 'S';
                var parameter2 = _comandosql.Parameters.Add("@pNoConcepto", SqlDbType.SmallInt);
                parameter2.Value = noConcepto;

                SqlDataReader reader = _comandosql.ExecuteReader();

                if (reader.Read())
                {
                    txtNombreConcepto.Text = reader["nombreConcepto"].ToString();
                    ////////
                    bool esFijo = Convert.ToBoolean(reader["fijo"]);
                    if (esFijo)
                        cbEsFijo.SelectedIndex = 0;
                    else
                        cbEsFijo.SelectedIndex = 1; //Seleccionamos en el CB la opcion que se guardó en la BD
                    ////////
                    if (reader["cuota"] == DBNull.Value) //si es nulo
                        txtCuota.Text = "N/A";
                    else
                        txtCuota.Text = reader["cuota"].ToString();
                    ////////
                    if (reader["porcentaje"] == DBNull.Value) //si es nulo
                        txtPorcentaje.Text = "N/A";
                    else
                        txtPorcentaje.Text = (float.Parse(reader["porcentaje"].ToString(), CultureInfo.InvariantCulture) * 100).ToString(); //se traduce a numeros entendibless
                    ////////
                    bool esTipo = Convert.ToBoolean(reader["percepcion"]);
                    if (esTipo)
                        cbEsTipo.SelectedIndex = 0;
                    else
                        cbEsTipo.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el concepto especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
        }
        public DataTable GetConceptos(char pAction = 'G') //'G' toda la tabla 'f' conceptos no fijos
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_CONCEPTOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@pAction", SqlDbType.Char, 1);
                parametro1.Value = pAction;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        /// ******************************************************************************************************************************************************************************************************

        public void GetEmpleados(Int16 noEmpleado, TextBox txtNum, TextBox txtNom, TextBox txtApP, TextBox txtApM, TextBox txtContrasena, TextBox txtCalleNo, TextBox txtCol,
            TextBox txtCP, TextBox txtNoC, TextBox txtEmail, TextBox txtT1, TextBox txtT2,
            TextBox txtCURP, TextBox txtNSS, TextBox txtRFC,
            ComboBox cbDep, ComboBox cbPuesto, ComboBox cbBanco, ComboBox cbMun, ComboBox cbEst,
            DateTimePicker dtpNac, DateTimePicker dtpIni)
        {
            try
            {
                conectar();
                string qry = "sp_EMPLEADOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parameter1 = _comandosql.Parameters.Add("@pAction", SqlDbType.Char, 1);
                parameter1.Value = 'S';
                var parameter2 = _comandosql.Parameters.Add("@pNoEmpleado", SqlDbType.SmallInt, 2);
                parameter2.Value = noEmpleado;

                SqlDataReader reader = _comandosql.ExecuteReader();

                if (reader.Read())
                {
                    txtNom.Text = reader["noEmpleado"].ToString();
                    txtNom.Text = reader["nombres"].ToString();
                    txtApP.Text = reader["apellidoP"].ToString();
                    txtApM.Text = reader["apellidoM"].ToString();
                    txtContrasena.Text = reader["passwordHash"].ToString();
                    txtCalleNo.Text = reader["calleNombre"].ToString();
                    txtCol.Text = reader["colonia"].ToString();
                    if (reader["codigoPostal"] == DBNull.Value) //si es nulo
                        txtCP.Text = "No registrado";
                    else
                        txtCP.Text = reader["codigoPostal"].ToString();

                    txtNoC.Text = reader["noCuenta"].ToString();

                    if (reader["email"] == DBNull.Value) //si es nulo
                        txtEmail.Text = "No registrado";
                    else 
                        txtEmail.Text = reader["email"].ToString();

                    txtT1.Text = reader["telefono1"].ToString();

                    if (reader["telefono2"] == DBNull.Value) //si es nulo
                        txtT2.Text = "No registrado";
                    else
                        txtT2.Text = reader["telefono2"].ToString();

                    txtCURP.Text = reader["curp"].ToString();
                    txtNSS.Text = reader["nss"].ToString();
                    txtRFC.Text = reader["rfc"].ToString();
                    cbDep.SelectedValue = Convert.ToInt16(reader["idDepartamento"]); //aqui se usa value para relacionarlo al dato con que se guardo en el cb
                    cbPuesto.SelectedValue = Convert.ToInt16(reader["idPuesto"]);
                    cbMun.SelectedValue = Convert.ToInt16(reader["idMunicipio"].ToString());
                    cbEst.SelectedValue = Convert.ToInt16(reader["idEstado"].ToString());
                    cbBanco.SelectedValue = Convert.ToInt16(reader["idBanco"].ToString());


                    dtpNac.Value = Convert.ToDateTime(reader["fechaNacimiento"]); //no sé si vaya a ocasionar problemas
                    dtpIni.Value = Convert.ToDateTime(reader["fechaInicio"]);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el empleado especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable GetEmpleados(char pAction = 'G', int noDepto = 0, int noPuesto = 0, DateTime fechaInicio = default(DateTime))
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_EMPLEADOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@pAction", SqlDbType.Char, 1);
                parametro1.Value = pAction;

                if (pAction == 'H') //Pantalla aplicar conceptos para ver los emp en cierto puesto y departamento
                {
                    var parameter2 = _comandosql.Parameters.Add("@pIdDepartamento", SqlDbType.SmallInt, 4);
                    parameter2.Value = noDepto;
                    var parameter3 = _comandosql.Parameters.Add("@pIdPuesto", SqlDbType.Int, 8);
                    parameter3.Value = noPuesto;
                    var parameter4 = _comandosql.Parameters.Add("@pFechaInicio", SqlDbType.Date, 3);
                    parameter4.Value = fechaInicio.Date;
                }
                

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        ///************************************************************+
        public DataTable GetEstadosBancos(bool estados)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry;
                if (estados)
                    qry = "sp_ESTADOS";
                else
                    qry = "sp_BANCOS";

                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@pAction", SqlDbType.Char, 1);
                parametro1.Value = 'G';

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable GetMunicipios(string estado)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_MUNICIPIOS";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@pAction", SqlDbType.Char, 1);
                parametro1.Value = 'G';
                var parametro2 = _comandosql.Parameters.Add("@pEstado", SqlDbType.VarChar, 50);
                parametro2.Value = estado;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        /// ******* L O G     I N ***********************************************************************************************************************************************************************

        public bool CheckDB(string pPassword, int pUser)
        {
            bool resultado = false;
            try
            {
                conectar();

                string qry = "sp_CheckLogIn";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parameter1 = _comandosql.Parameters.Add("@pUser", SqlDbType.Int, 4);
                parameter1.Value = pUser;
                var parameter2 = _comandosql.Parameters.Add("@pPassword", SqlDbType.VarChar, 255);
                parameter2.Value = pPassword;

                SqlDataReader reader = _comandosql.ExecuteReader();

                if (reader.Read())
                    resultado = (bool)reader["isConnected"];
                else
                    resultado = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
            return resultado;
        }

        public bool GenerarNomina()
        {
            //bool resultado = false;
            //try
            //{
            //    conectar();

            //    string qry = "sp_CheckLogIn";
            //    _comandosql = new SqlCommand(qry, _conexion);
            //    _comandosql.CommandType = CommandType.StoredProcedure;
            //    _comandosql.CommandTimeout = 1200;

            //    var parameter1 = _comandosql.Parameters.Add("@pUser", SqlDbType.Int, 4);
            //    parameter1.Value = pUser;
            //    var parameter2 = _comandosql.Parameters.Add("@pPassword", SqlDbType.VarChar, 255);
            //    parameter2.Value = pPassword;

            //    SqlDataReader reader = _comandosql.ExecuteReader();

            //    if (reader.Read())
            //        resultado = (bool)reader["isConnected"];
            //    else
            //        resultado = false;
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    desconectar();
            //}
            //return resultado;

        }
    }
}
