using CL_capa_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cl_capa_datos;
using System.Data;

namespace CL_capaNegocios
{
    public class CN_Empleado
    {
        public static bool InsertarEmpleado(Empleado objEmpleado)
        {
            return DA_Empleado.InsertarEmpleadoDA(objEmpleado);
        }

        public static DataTable ConsultarEmpleado()
        {
            return DA_Empleado.ConsultarEmpleadoDA();
        }

        public static bool ActualizarEmpleado(Empleado objEmpleado)
        {
            return DA_Empleado.ActualizarEmpleadoDA(objEmpleado);
        }
    }
}
