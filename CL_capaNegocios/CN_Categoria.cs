using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_capa_entidades;
using Cl_capa_datos;
using System.Data;

namespace CL_capaNegocios
{
    public class CN_Categoria
    {
        public static bool InsertarCategoria(Categoria objCategoria)
        {
            return DA_Categoria.InsertarCategoriaDA(objCategoria);
        }

        public static DataTable ConsultarCategoria()
        {
            return DA_Categoria.ConsultarCategoriaDA();
        }

        public static bool ActualizarCategoria(Categoria objCategoria)
        {
            return DA_Categoria.ActualizarCategoriaDA(objCategoria);
        }
    }
}
