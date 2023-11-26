using Cl_capa_datos;
using CL_capa_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CL_capaNegocios
{
    public class CN_Cliente
    {
        public static bool RegistarCliente(CL_capa_entidades.Cliente objCliente)
        {
            return DA_Cliente.RegistrarClienteDA(objCliente);
        }
    }
}
