using CL_capa_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Cl_capa_datos
{
    public class DA_FullMarket : DA_BASE
    {

        public static bool InsertarFullMarket(FullMarket objFullMarket)
        {
            string strSQL = "Insert into fullmarket (nit,razonSocial,direccion,telefono,correo,direccionWeb) values(";
            strSQL += "'" + objFullMarket.Nit + "',";
            strSQL += "'" + objFullMarket.RazonSocial + "',";
            strSQL += "'" + objFullMarket.Direccion + "',";
            strSQL += "'" + objFullMarket.Telefono + "',";
            strSQL += "'" + objFullMarket.Correo + "',";
            strSQL += "'" + objFullMarket.DireccionWeb + "');";

            return RealizarTransaccion(strSQL);

        }
        public static DataTable ConsultarFullMarket()
        {
            

            String codigo = "Select * from fullmarket where idFullMarket =1;";

            return ConsultarDatos(codigo);
        }
        public static bool ActualizarFullMarket(FullMarket objFullMarket)
        {
            string strSQL = "update fullmarket set correo='"+objFullMarket.Correo+"',direccion='"+objFullMarket.Direccion+"',`direccionWeb`='"+objFullMarket.DireccionWeb+"',nit='"+objFullMarket.Nit+"',`razonSocial`='"+objFullMarket.RazonSocial+"',telefono='"+objFullMarket.Telefono+"' where `idFullMarket`=1";
            
            return RealizarTransaccion(strSQL);
        }
    }
    
}
