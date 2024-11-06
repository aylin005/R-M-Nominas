using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MAD_AAVD_proyecto
{
    public class Puestos
    {
        public short noPuesto { get; set; }
        public string nombrePuesto { get; set; }
        public float nivelSalarial { get; set; }

    }

    public class Departamentos
    {
        public int noDepto { get; set; }
        public string nombreDpto { get; set; } 
        public float  sueldoBase { get; set; }
    }

    public class Conceptos
    {
        public int noConcepto { get; set; }
        public string nombreConcepto { get; set; }
        public float cuota { get; set; }
        public float porcentaje { get; set; }
        public bool fijo { get; set; }
        public bool percepcion { get; set; }
    }

    public class  Empleados
    {
        public int noEmpleado { get; set; }
        public string nombres { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public string contrasena { get; set; }
        public Cassandra.LocalDate fechaNacimiento { get; set; }
        public string departamento { get; set; }
        public string puesto { get; set; }
        public string curp { get; set; }
        public string rfc { get; set; }
        public string nss { get; set; }
        public string calleNo { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public string estado { get; set; }
        public string cp { get; set; }
        public string banco { get; set; }
        public int noCuenta { get; set; }
        public string email { get; set; }
        public HashSet<int> telefonos { get; set; }
        public Cassandra.LocalDate fechaInicio { get; set; }
        public decimal salarioDiario { get; set; }
        public Cassandra.LocalDate fechaBaja { get; set; }
    }
}
