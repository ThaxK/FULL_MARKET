using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_capa_entidades
{
    public class DetalleVenta
    {
        public int idDetalleVenta {get; set;}
        public int numeroVenta { get; set;}
        public int idProducto { get; set;}
        public int subtotal { get; set;}
    }
}
