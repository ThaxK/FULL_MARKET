using CL_capa_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_capa_datos
{
    public class DA_Proveedor : DA_BASE
    {
        public static bool InsertarProveedor(Proveedor objProovedor)
        {

            string strSQL = "Insert into categoria (nit, razonSocial, direccion, telefono, correo, ciudad) values(";
            strSQL += "'" + objProovedor.Nit + "',";
            strSQL += "'" + objProovedor.RazonSocial + "',";
            strSQL += "'" + objProovedor.Direccion + "',";
            strSQL += "'" + objProovedor.Telefono + "',";
            strSQL += "'" + objProovedor.Ciudad + "',";

            return RealizarTransaccion(strSQL);


        }
}
