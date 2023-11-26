using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cl_capa_datos;
using CL_capa_entidades;
using Org.BouncyCastle.Utilities.Collections;

namespace Cl_capa_datos
{
    public  class DA_Categoria : DA_BASE
    {
        public static bool InsertarCategoriaDA(Categoria objCategoria)
        {
            string codigo = "Insert into categoria (nombre,descripción) values (";
            codigo+="'"+objCategoria.nombre+"',";
            codigo+= "'" + objCategoria.descripcion + "');";

            return RealizarTransaccion(codigo);
        }

        public static DataTable ConsultarCategoriaDA()
        {
            String codigo = "Select * from categoria";
            
            return ConsultarDatos (codigo);
        }

        public static bool ActualizarCategoriaDA(Categoria objCategoria)
        {
            string codigo = "UPDATE categoria SET nombre = '"+objCategoria.nombre+"', descripción = '"+objCategoria.descripcion+"' WHERE `idCategoria` = "+objCategoria.id+";";

            return RealizarTransaccion(codigo);
        }
    }
}
