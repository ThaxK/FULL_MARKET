using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_capa_datos
{
    public class DA_DetalleVenta:DA_BASE
    {
        public static bool RegistrarDetalleVentaDA(CL_capa_entidades.DetalleVenta objDetalleVenta)
        {
            string codigo = "insert into detalleventa (`numeroVenta`,`idProducto`,subtotal) VALUES ("+objDetalleVenta.numeroVenta+","+objDetalleVenta.idProducto+","+objDetalleVenta.subtotal+");";

            return RealizarTransaccion(codigo);
        }
    }
}
