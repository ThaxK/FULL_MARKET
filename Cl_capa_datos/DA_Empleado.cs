using CL_capa_entidades;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_capa_datos
{
    public class DA_Empleado:DA_BASE
    {
        public static bool InsertarEmpleadoDA(Empleado objEmpleado)
        {
            String codigo= "Insert INTO empleado(identificacion,`tipoDocumento`, nombres, apellidos, correo, clave, telefono,`idFullMarket`) VALUES('"+objEmpleado.identificacion+"', '"+objEmpleado.tipoDocumento+"', '"+objEmpleado.nombres+"', '"+objEmpleado.apellidos+"', '"+objEmpleado.correo+"', '"+objEmpleado.clave+"', '"+objEmpleado.telefono+"', "+objEmpleado.idFullMarket+");";

            return RealizarTransaccion(codigo);
        }

        public static DataTable ConsultarEmpleadoDA()
        {
            String codigo = "Select e.idEmpleado,e.identificacion,e.tipoDocumento,e.nombres,e.apellidos,e.correo,e.clave,e.telefono,f.razonSocial as Tienda from empleado as e inner join fullmarket as f on e.idFullMarket=f.idFullMarket;";

            return ConsultarDatos(codigo);
        }

        public static bool ActualizarEmpleadoDA(Empleado objEmpleado)
        {
            string codigo="update empleado set identificacion='"+objEmpleado.identificacion+"',nombres='"+objEmpleado.nombres+"',apellidos='"+objEmpleado.apellidos+"',correo='"+objEmpleado.correo+"',clave='"+objEmpleado.clave+"',telefono='"+objEmpleado.telefono+"' where idEmpleado="+objEmpleado.idEmpleado+";";

            return RealizarTransaccion(codigo);
        }
    }
}
