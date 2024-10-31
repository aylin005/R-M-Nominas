using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MAD_AAVD_proyecto.EnlaceCassandra;


namespace MAD_AAVD_proyecto
{
    ///////////VARIABLES GLOBALES////////////
    public static class Globals
    {
        public static bool DB_Cassandra {get;set;}
        public static bool DB_SQLServer {get;set;}
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
