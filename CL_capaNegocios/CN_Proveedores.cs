using Cl_capa_datos;
using CL_capa_entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_capaNegocios
{
    public class CN_Proveedores
    {
        public static bool RegistrarProveedor(Proveedor objProveedor)
        {
            return DA_Proveedores.RegistrarProveedor(objProveedor);
        }
        public static DataTable ConsultarProveedores()
        {
            return DA_Proveedores.ConsultarProveedores();
        }
        public static bool ActualizarProveedores(Proveedor objProveedor)
        {
            return DA_Proveedores.ActualizarProveedores(objProveedor);
        }
    }
}
