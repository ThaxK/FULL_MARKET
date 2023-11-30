using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Cl_capa_datos;
using CL_capa_entidades;

namespace Cl_capa_datos
{
    public class DA_Cliente : DA_BASE
    {
        public static bool RegistrarClienteDA(CL_capa_entidades.Cliente objCliente)
        {
            string codigo = "Insert into cliente (identificacion,tipoDocumento, nombres, apellidos, correo, direccion, telefono) values (";
            codigo += "'" + objCliente.documento + "',";
            codigo += "'" + objCliente.tipoDocumento + "',";
            codigo += "'" + objCliente.nombre + "',";
            codigo += "'" + objCliente.apellido + "',";
            codigo += "'" + objCliente.correo + "',";
            codigo += "'" + objCliente.direccion + "',";
            codigo += "'" + objCliente.telefono + "');";

            return RealizarTransaccion(codigo);
        }
        public static DataTable ConsultarClienteDA()
        {
            String codigo = "Select * from cliente";

            return ConsultarDatos(codigo);
        }
        public static bool ActualizarCliente(Cliente objCliente)
        {
            string codigo = "UPDATE cliente set nombres='" + objCliente.nombre + "',apellidos='" + objCliente.apellido + "',correo='" + objCliente.correo + "',telefono='" + objCliente.telefono + "' where idCliente=" + objCliente.id + ";";

            return RealizarTransaccion(codigo);
        }

        
    }
}
