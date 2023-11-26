using Cl_capa_datos;
using CL_capa_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_capaNegocios
{
    public class CN_Proveedor
    {
        public static bool InsertarProveedor(Proveedor objProveedor)
        {
            return DA_Proveedor.InsertarProveedor(objProveedor);
        }



    }
}
