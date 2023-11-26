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
    public class CN_Producto
    {
        public static bool InsertarProducto(Producto objProducto)
        {
            return DA_Producto.InsertarProducto(objProducto);
        }

        public static DataTable ConsultarProducto()
        {
            return DA_Producto.ConsultarProducto();
        }

        public static bool ActualizarProducto(Producto objProducto)
        {
            return DA_Producto.ActualizarProducto(objProducto);
        }

        public static DataTable ConsultarPorNombre(String palabra)
        {
            return DA_Producto.ConsultarPorNombre(palabra);
        }

        public static DataTable ConsultarPorCategoria(int idCategoria)
        {
            return DA_Producto.ConsultarPorCategoria(idCategoria);
        }
    }
}
