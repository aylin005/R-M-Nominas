using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.Data.Common;
using Newtonsoft.Json.Linq;


namespace MAD_AAVD_proyecto
{
    class EnlaceCassandra
    {
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;

        private static void conectar()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();


            _cluster = Cluster.Builder()
                .AddContactPoint(_dbServer)
                .Build();

            _session = _cluster.Connect(_dbKeySpace);
        }


        private static void conectar2()
        {
            // Este solo es un ejemplo, NO hay que hacerlo de esta manera

            _cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .Build();

            _session = _cluster.Connect("keyspace3");
        }

        private static void desconectar()
        {
            _cluster.Dispose();
        }

        public void InsertaDatos(int id, string dato)
        {
            try
            {
                conectar();
                
                string qry = "insert into ejemplo(campo1, campo2) values(";
                qry = qry + id.ToString();
                qry = qry + ",'";
                qry = qry + dato;
                qry = qry + "');";


                string query = "insert into ejemplo(campo1, campo2) values({0}, '{1}');";
                qry = string.Format(query, id, dato);

                _session.Execute(qry);
            }
            catch(Exception e)
            {
                throw e;   
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();
            }
        }

        //public void InsertaHoteles(HotelesXCiudad param)
        //{
        //    try
        //    {
        //        conectar();

        //        string query = "insert into HotelesXCiudad(Ciudad, NombreHotel, Domicilio, Telefono, TotHab) ";
        //        query += "values('{0}', '{1}', '{2}', '{3}', {4});";
        //        var qry = string.Format(query, param.Ciudad, param.NombreHotel, param.Domicilio, param.Telefono, param.TotHab);

        //        _session.Execute(qry);
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally
        //    {
        //        // desconectar o cerrar la conexión
        //        desconectar();
        //    }
        //}


        //public IEnumerable<HotelesXCiudad> Get_One(int dato)
        //{
        //    string query = "SELECT campo1, campo2 FROM ejemplo WHERE campo1 = ?;";
        //    conectar();
        //    IMapper mapper = new Mapper(_session);
        //    IEnumerable<HotelesXCiudad> users = mapper.Fetch<HotelesXCiudad>(query, dato);

        //    desconectar();
        //    return users.ToList();
        //}

        public List<T> Get_All<T>(string[] columnas, string nombreTabla)
        {
            string query = "SELECT ";
            foreach (var columna in columnas)
            {
                query += columna + ", ";
            }
            query = query.Remove(query.Length - 2);
            query += " FROM " + nombreTabla + ";";
            conectar();

            IMapper mapper = new Mapper(_session);
            IEnumerable<T> table = mapper.Fetch<T>(query);

            desconectar();
            return table.ToList();
        }

        public void Insert(bool edit, string nombreTabla, string[] columns, string[] values)//en values enviar strings entre ''
        {//columns 0 debe ser el numero id
            try
            {
                conectar();
                string query = "";
                //contar arreglos
                int cantColumns = 0;
                foreach(var column in columns)
                {
                    cantColumns++;
                }
                if (!edit)
                {
                    query = $"SELECT MAX({columns[0]}) FROM {nombreTabla};";
                    IMapper mapper = new Mapper(_session);
                    // int? para que acepte null en caso de que no haya resultados
                    int? lastNumber = mapper.Single<int?>(query);
                    
                    // Asigna 0 si lastNumber es null
                    if (lastNumber == null)
                        lastNumber = 1;
                    else
                        lastNumber++;

                    query = $"INSERT INTO {nombreTabla}(";
                    foreach (var column in columns)
                    {
                        query = query + column + ", ";
                    }
                    //eliminar el ultimo , 
                    query = query.Remove(query.Length - 2);
                    query = query + ") VALUES(" + lastNumber + ", ";

                    for (int i = 0; i < cantColumns - 1; i++)
                    {
                        query = query + values[i + 1] + ", "; // se salta id porque ya se aplico
                    }

                    query = query.Remove(query.Length - 2);
                    query = query + ") IF NOT EXISTS;";
                }
                else
                {
                    query = "UPDATE ";
                    query = query + nombreTabla + " SET ";
                    
                    for (int i = 0; i < cantColumns - 1; i++)
                    {
                        query = query + columns[i + 1] + " = " + values[i + 1] + ", "; //se salta el id primero
                    }
                    query = query.Remove(query.Length - 2); //quita el ultimo ,
                    query = query + " WHERE " + columns[0] + " = " + values[0] + " IF EXISTS;";
                }

                _session.Execute(query);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }
        public void Delete(string nombreTabla, string [] columnas, int noID)
        {
            try
            {
                conectar();
                string query = $"DELETE FROM {nombreTabla} WHERE {columnas[0]} = {noID};";

                _session.Execute(query);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }
        public T Get_One<T>(string[]columnas, string nombreTabla, int noID) //template
        {
            string query = "SELECT ";
            foreach (string column in columnas)
            {
                query += column + ", ";
            }
            query = query.Remove(query.Length - 2); //quita el ultimo ,
            query += " FROM " + nombreTabla + " WHERE " + columnas[0] + " = " + noID + ";";

            conectar();
            IMapper mapper = new Mapper(_session);
            T row = mapper.Single<T>(query); //un solo resultado.
            desconectar();
            return row;
        }

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }

            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        // Ejemplo de leer row x row
        //public void GetOne()
        //{
        //    conectar();

        //    string query ="SELECT campo1, campo2 FROM ejemplo;";

        //    // Execute a query on a connection synchronously 
        //    var rs = _session.Execute(query);

        //    // Iterate through the RowSet 
        //    foreach (var row in rs)
        //    {
        //        var value = row.GetValue<int>("campo1");
        //        // Do something with the value 
        //        var texto = row.GetValue<string>("campo2");
        //        // Do something with the value 

        //        MessageBox.Show(texto, value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        /*
        RowSet rsUsers = session.Execute(qry);

        ////////////////////////////////////////////////
        var users = new List<UserModel>();
        foreach (var userRow in rsUsers)
        {
            //users.Add(ReflectionTools.GetSingleEntryDynamicFromReader<UserModel>(userRow));
        }

        foreach (UserModel user in users)
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", user.Id, user.FirstName, user.LastName, user.Country, user.IsActive);
        }
        */

        //    }
        //}

    }
}
