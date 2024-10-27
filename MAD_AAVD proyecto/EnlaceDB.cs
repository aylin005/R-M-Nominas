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
        private static void desconectar()
        {
            _conexion.Close();
        }

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

                if(_tabla.Rows.Count > 0)
                {
                    isValid = true;
                }

            }
            catch(SqlException e)
            {
                isValid = false;
            }
            finally
            {
                desconectar();
            }

            return isValid;
        }

        //    public DataTable get_Puestos()
        //    {
        //        var msg = "";
        //        DataTable tabla = new DataTable();
        //        try
        //        {
        //            conectar();
        //// Ejemplo de cómo ejecutar un query, 
        //// PERO lo correcto es siempre usar SP para cualquier consulta a la base de datos
        //            string qry = "Select * From PUESTOS";
        //            _comandosql = new SqlCommand(qry, _conexion);
        //            _comandosql.CommandType = CommandType.Text;
        //		// Esta opción solo la podrían utilizar si hacen un EXEC al SP concatenando los parámetros.
        //            _comandosql.CommandTimeout = 1200;

        //            _adaptador.SelectCommand = _comandosql;
        //            _adaptador.Fill(tabla);

        //        }
        //        catch (SqlException e)
        //        {
        //            msg = "Excepción de base de datos: \n";
        //            msg += e.Message;
        //            MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //        }
        //        finally
        //        {
        //            desconectar();
        //        }

        //        return tabla;
        //    }
        public DataTable getTable(string pTableName) // SOLO PARA MOSTRAR LOS DATOS REGISTRADOS -> es decir, si el usuario no ha filtrado nada
        {
            DataTable tabla = new DataTable();
            string msg = "Se han obtenido los datos de la tabla";
            try
            {
                conectar();
                string qry = "SELECT * FROM " + pTableName;
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


        // Ejemplo de método para recibir una consulta en forma de tabla
        // Cuando el SP ejecutará un SELECT
        public DataTable get_Deptos(string opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_Gestiona_Deptos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1);
                parametro1.Value = opc;


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

        // Ejemplo de método para ejecutar un SP que no se espera que regrese información, 
        // solo que ejecute ya sea un INSERT, UPDATE o DELETE
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

    }
}
