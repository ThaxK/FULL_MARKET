using CL_capa_entidades;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_capa_datos
{
    public class DA_Producto : DA_BASE
    {
        public static bool InsertarProducto(Producto objProducto)
        {
            string strSQL = "Insert into producto(`codigoProducto`, nombre, precio, descripcion, stock, idCategoria) values('"+objProducto.codigo+"', '"+objProducto.nombre+"', '"+objProducto.precio+"', '"+objProducto.descripcion+"', '"+objProducto.stock+"', "+objProducto.idCategoria+")";

            return RealizarTransaccion(strSQL);
        }

        public static DataTable ConsultarProducto()
        {
            string strSQL ="SELECT p.idProducto,p.codigoProducto,p.nombre,p.precio,p.descripcion,p.stock,c.nombre as categoria FROM `producto` as p inner JOIN categoria as c on p.idCategoria=c.idCategoria;";

            return ConsultarDatos(strSQL);
        }

        public static bool ActualizarProducto(Producto objProducto)
        {
            string codigo = "UPDATE producto SET `codigoProducto`= '" + objProducto.codigo + "',nombre='" + objProducto.nombre + "',precio='" + objProducto.precio + "',descripcion='" + objProducto.descripcion + "',stock='" + objProducto.stock + "' WHERE `idProducto`=" + objProducto.idProducto + ";";

            return RealizarTransaccion(codigo);
        }

        public static DataTable ConsultarPorNombre(String palabra)
        {
            string strSQL = "SELECT p.idProducto,p.codigoProducto,p.nombre,p.precio,p.descripcion,p.stock,c.nombre as categoria FROM `producto` as p inner JOIN categoria as c on p.idCategoria=c.idCategoria WHERE p.nombre like '%"+palabra+"%';";

            return ConsultarDatos(strSQL);
        }

        public static DataTable ConsultarPorCategoria(int idCategoria)
        {
            string strSQL = "SELECT p.idProducto,p.codigoProducto,p.nombre,p.precio,p.descripcion,p.stock,c.nombre as categoria FROM `producto` as p inner JOIN categoria as c on p.idCategoria=c.idCategoria WHERE p.idCategoria = "+idCategoria+";";

            return ConsultarDatos(strSQL);
        }
    }
}
