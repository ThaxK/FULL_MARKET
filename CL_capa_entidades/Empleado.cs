using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_capa_entidades
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public String nombres { get; set; }
        public String tipoDocumento { get; set; }
        public String identificacion { get; set; }
        public String apellidos { get; set; }
        public String correo { get; set; }
        public String telefono { get; set; }
        public String clave { get; set; }
        public int idFullMarket { get; set; }
    }
}
