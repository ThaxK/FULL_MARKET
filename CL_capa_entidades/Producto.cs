using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_capa_entidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string precio { get; set; }
        public string descripcion { get; set; }
        public string stock { get; set; }
        public int idCategoria { get; set; }
    }
}
