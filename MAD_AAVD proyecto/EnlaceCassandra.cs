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

        public void Insert(bool edit, string nombreTabla, string[] primaryKey , string[] pkValues, string[] columns, string[] values)//en values enviar strings entre ''
        {
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
                int cantPrimaryKey = 0;
                foreach (var column in primaryKey)
                {
                    cantPrimaryKey++;
                }

                if (!edit)
                {
                    query = $"SELECT MAX({primaryKey[0]}) FROM {nombreTabla};"; //seria la partition
                    IMapper mapper = new Mapper(_session);
                    // int? para que acepte null en caso de que no haya resultados
                    int? lastNumber = mapper.Single<int?>(query);
                    
                    // Asigna 0 si lastNumber es null
                    if (lastNumber == null)
                        lastNumber = 1;
                    else
                        lastNumber++;

                    query = $"INSERT INTO {nombreTabla}(";
                    foreach (var column in primaryKey)
                    {
                        query += column + ", ";
                    }
                    foreach (var column in columns)
                    {
                        query += column + ", ";
                    }
                    //eliminar el ultimo , 
                    query = query.Remove(query.Length - 2);
                    query = query + ") VALUES(" + lastNumber + ", ";

                    for (int i = 0; i < cantPrimaryKey - 1; i++)
                    {
                        query += pkValues[i + 1] + ", "; // se salta id porque ya se aplico
                    }
                    for (int i = 0; i < cantColumns; i++)
                    {
                        query += values[i] + ", "; // se salta id porque ya se aplico
                    }

                    query = query.Remove(query.Length - 2);
                    query += ") IF NOT EXISTS;"; 
                }
                else
                {
                    query = "UPDATE ";
                    query += nombreTabla + " SET ";
                    
                    for (int i = 0; i < cantColumns; i++)
                    {
                        query += columns[i] + " = " + values[i] + ", "; 
                    }
                    query = query.Remove(query.Length - 2); //quita el ultimo ,
                   
                    query += " WHERE ";
                    for (int i = 0; i < cantPrimaryKey; i++)
                    {
                        query += primaryKey[i] + " = " + pkValues[i] + " AND ";
                    }
                    query = query.Remove(query.Length - 5); //quita el ultimo AND
                    query += ";";
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
        public T Get_One<T>(string[] primaryKey, string[]columnas, string nombreTabla, string[] pkValues, short cantPK = 1) //template
        { //SELECT SIMPLE (solo con =)
            string query = "SELECT ";
            foreach (string column in primaryKey)
            {
                query += column + ", ";
            }
            foreach (string column in columnas)
            {
                query += column + ", ";
            }
            query = query.Remove(query.Length - 2); //quita el ultimo ,
            query += " FROM " + nombreTabla + " WHERE ";
            
            for (int i = 0; i < cantPK; i++)
            {
                query += primaryKey[i] + " = " + pkValues[i] + " AND ";
            }
            query = query.Remove(query.Length - 5); //quita el ultimo ,
            query += ";";

            conectar();
            IMapper mapper = new Mapper(_session);
            T row = mapper.Single<T>(query); //un solo resultado.
            desconectar();
            return row;
        }

        public List<T> FilterDate<T>(string[] columnas, string nombreTabla, string date)
        {
            DateTime date2;
            
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
    }
}
