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
    public class CDValidarUsuario
    {
        public void ValidarUsuario(CDValidarUsuario objValidate)
        {
            SqlConnection sqlCon = new SqlConnection();

            sqlCon.ConnectionString = Conexion.miconexion;
            string consultaSQL = "SELECT Usuario, Pass FROM Usuario WHERE Usuario = 'Jose'";
            SqlCommand micomando = new SqlCommand(consultaSQL, sqlCon);
            sqlCon.Close();
        }
    }
}
