using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_capa_entidades
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int numeroVenta { get; set; }
        public DateTime fechaVenta { get; set; }
        public int iva  { get; set; }
        public int total { get; set; }
        public int idEmpleado { get; set; }
        public int identificacionCliente { get; set; }

    }
}
