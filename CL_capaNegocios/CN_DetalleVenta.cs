using CL_capa_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_capaNegocios
{
    public class CN_DetalleVenta
    {
        public static bool RegistrarDetalleVenta(DetalleVenta objDetalleVenta)
        {
            return Cl_capa_datos.DA_DetalleVenta.RegistrarDetalleVentaDA(objDetalleVenta);
        }
    }
}
