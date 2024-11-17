using Cassandra;
using System;
using System.Configuration;
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

        public static bool isUserOnDB = false;

        public static int activeUser = -1;

        //company data
        public static string companyName = ConfigurationManager.AppSettings["RazonSocial"];
        public static string RP = ConfigurationManager.AppSettings["RegistroPatronal"];
        public static string RFC = ConfigurationManager.AppSettings["RFC"];
        public static string DF = ConfigurationManager.AppSettings["DomicilioFiscal"];
        public static string noTel = ConfigurationManager.AppSettings["NumTelefono"];
        public static string email = ConfigurationManager.AppSettings["Email"];
        public static string iniCompanyString = ConfigurationManager.AppSettings["FechaInicio"]; //fecha en string
        public static DateTime iniCompany = DateTime.ParseExact(iniCompanyString, "yyyy-MM-dd", null); //fecha en formato fecha xd

        //admin data
        public static string adminUser = ConfigurationManager.AppSettings["userAdmin"];
        public static string adminPassword = ConfigurationManager.AppSettings["passwordAdmin"];

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
