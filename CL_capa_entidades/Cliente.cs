using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CL_capa_entidades
{
    public class Cliente
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String documento { get; set; }
        public String tipoDocumento { get; set; }
        public String apellido { get; set; }
        public String correo { get; set; }
        public String telefono { get; set; }
        public String direccion { get; set; }

    }
}
