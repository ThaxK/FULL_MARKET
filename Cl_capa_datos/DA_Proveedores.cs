using CL_capa_entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_capa_datos
{
    public class DA_Proveedores: DA_BASE
    {
        public static bool RegistrarProveedor(Proveedor objProveedor)
        {
            string codigo = "insert into proveedor (nit,`razonSocial`,direccion,telefono,correo,ciudad) VALUES ('" + objProveedor.nit + "','" + objProveedor.razonSocial + "','" + objProveedor.direccion + "','" + objProveedor.telefono + "','" + objProveedor.correo + "','" + objProveedor.ciudad + "');";

            return RealizarTransaccion(codigo);
        }
        
        public static DataTable ConsultarProveedores()
        {
            string strSQL = "select * from proveedor;";

            return ConsultarDatos(strSQL);
        }

        public static bool ActualizarProveedores(CL_capa_entidades.Proveedor objProveedor)
        {
            string strSQL = "UPDATE proveedor SET nit='"+objProveedor.nit+"',`razonSocial`='"+objProveedor.razonSocial+"',direccion='"+objProveedor.direccion+"',telefono='"+objProveedor.telefono+"',correo='"+objProveedor.correo+"',ciudad='"+objProveedor.ciudad+"' WHERE `idProveedor`="+objProveedor.idProveedor+";";

            return RealizarTransaccion(strSQL);
        }
    }
}
