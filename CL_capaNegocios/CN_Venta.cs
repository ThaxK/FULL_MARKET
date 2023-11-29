using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cl_capa_datos;

namespace CL_capaNegocios
{
    public class CN_Venta
    {
        public static bool RegistrarVenta(CL_capa_entidades.Venta objVenta)
        {
            return DA_Venta.RegistrarVentaDA(objVenta);
        }

        public static DataTable ConsultarVenta()
        {
            return DA_Venta.ConsultarVentaDA();
        }
    }
}
