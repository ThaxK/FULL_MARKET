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
    public class CN_FullMarket
    {
        public static bool InsertarFullMarket(FullMarket objFullMarket)
        {
            return DA_FullMarket.InsertarFullMarket(objFullMarket);
        }
        public static DataTable ConsultarFullMarket()
        {
            return DA_FullMarket.ConsultarFullMarket();
        }
        public static bool ActualizarFullMarket(FullMarket objFullMarket)
        {
            return DA_FullMarket.ActualizarFullMarket(objFullMarket);
        }

    }
}
