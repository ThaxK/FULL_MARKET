using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_capa_entidades
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string nit { get; set; }
        public string razonSocial { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string ciudad { get; set; }
    }
}
