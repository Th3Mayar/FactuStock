using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public static string miconexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\syscode\FactuStock\CapaDatos\FactuStock.mdf;Integrated Security=True";
        public SqlConnection dbconexion = new SqlConnection(miconexion);
    }
}
