using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
