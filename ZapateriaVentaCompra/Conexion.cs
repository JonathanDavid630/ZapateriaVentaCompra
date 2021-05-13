using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra
{
    public static class Conexion
    {

        public static IDbConnection conectar()
        {
            IDbConnection connection;
            var cadena = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            connection = new SqlConnection(cadena);
            return connection;
        }

    }
}
