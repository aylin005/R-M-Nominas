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

        public List<Puestos> Get_All()
        {
            string query = "SELECT noPuesto, nombrePuesto, nivelSalarial FROM PUESTOS;";
            conectar();

            IMapper mapper = new Mapper(_session);
            IEnumerable<Puestos> puestos = mapper.Fetch<Puestos>(query);

            desconectar();
            return puestos.ToList();
        }

        public void InsertPuesto(bool edit, int noPuesto, string nombrePuesto, float nivelSalarial)
        {
            try
            {
                conectar();
                string query = "";

                if (!edit)
                {
                    query = "SELECT MAX(noPuesto) FROM PUESTOS;";
                    IMapper mapper = new Mapper(_session);
                    int lastPuestoNumber = mapper.Single<int>(query); // Devuelve el último número de puesto
                    lastPuestoNumber++;

                    query = "insert into PUESTOS(noPuesto, nombrePuesto, nivelSalarial) values({0},'{1}',{2}) IF NOT EXISTS;";
                    query = string.Format(query, lastPuestoNumber, nombrePuesto, nivelSalarial);
                }
                else
                {
                    query = "UPDATE PUESTOS SET nombrePuesto = '{0}', nivelSalarial = {1} WHERE noPuesto={2} IF EXISTS;";
                    query = string.Format(query, nombrePuesto, nivelSalarial, noPuesto);
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
        public void DeletePuesto(int noPuesto)
        {
            try
            {
                conectar();
                string query = "DELETE FROM PUESTOS WHERE noPuesto = {0};";
                query = string.Format(query, noPuesto);

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
        public Puestos Get_One(int noPuesto)
        {
            string query = "SELECT noPuesto, nombrePuesto, nivelSalarial FROM PUESTOS WHERE noPuesto = {0};";
            query = string.Format(query, noPuesto);
            conectar();
            IMapper mapper = new Mapper(_session);
            Puestos puesto = mapper.Single<Puestos>(query); //un solo resultado.
            desconectar();
            return puesto;
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
