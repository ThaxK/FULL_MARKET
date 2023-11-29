using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_capa_datos
{
    public class DA_Venta:DA_BASE
    {
        public static bool RegistrarVentaDA(CL_capa_entidades.Venta objVenta)
        {
            string codigo = "insert into venta (`numeroVenta`,`fechaVenta`,iva,total,`idEmpleado`,`identificacionCliente`) values ("+objVenta.numeroVenta+",'"+objVenta.fechaVenta+"',"+objVenta.iva+","+objVenta.total+",1,"+objVenta.identificacionCliente+");";

            return RealizarTransaccion(codigo);
        }

        public static DataTable ConsultarVentaDA()
        {
            string codigo = "Select * from venta";

            return ConsultarDatos(codigo);
        }
    }
}
