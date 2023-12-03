using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_capa_datos
{
    public class DA_Venta:DA_BASE
    {
        public static bool RegistrarVentaDA(CL_capa_entidades.Venta objVenta)
        {
            string codigo = "insert into venta (`numeroVenta`,`fechaVenta`,iva,total,`idEmpleado`,`identificacionCliente`) values (@NumeroVenta,@Fecha,@Iva,@Total,1,@IdentificacionCliente);";

            // Crear una lista para almacenar los parámetros
            List<MySqlParameter> parametros = new List<MySqlParameter>();

            // Agregar parámetros a la lista
            parametros.Add(new MySqlParameter("@NumeroVenta", MySqlDbType.Int64) { Value = objVenta.numeroVenta });
            parametros.Add(new MySqlParameter("@Fecha", MySqlDbType.DateTime) { Value = objVenta.fechaVenta});
            parametros.Add(new MySqlParameter("@Iva", MySqlDbType.Int64) { Value = objVenta.iva });
            parametros.Add(new MySqlParameter("@Total", MySqlDbType.Int64) { Value = objVenta.total });
            parametros.Add(new MySqlParameter("@IdEmpleado", MySqlDbType.Int64) { Value = objVenta.idEmpleado });
            parametros.Add(new MySqlParameter("@IdentificacionCliente", MySqlDbType.Int64) { Value = objVenta.identificacionCliente });
            // Llamar al método RealizarTransaccion con la consulta y la lista de parámetros
            return RealizarTransaccion2(codigo, parametros);
        }

        public static DataTable ConsultarVentaDA()
        {
            string codigo = "Select idVenta from venta";

            return ConsultarDatos(codigo);
        }
    }
}
