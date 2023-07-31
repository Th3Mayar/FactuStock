using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDRol
    {
        private int dIDRol;
        private string dRol, dSiglas;

        public CDRol()
        {

        }

        public CDRol(int pIDRol, string pRol, string pSiglas)
        {
            this.dIDRol = pIDRol;
            this.dRol = pRol;
            this.dSiglas = pSiglas;
        }

        #region

        public int IDRol
        {
            get { return dIDRol; }
            set { dIDRol = value; }
        }

        public string Rol
        {
            get { return dRol; }
            set { dRol = value; }
        }

        public string Siglas
        {
            get { return dSiglas; }
            set { dSiglas = value; }
        }

        #endregion

        public string Insertar(CDRol objRol)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand miparametro = new SqlCommand("RolInsertar", sqlCon);
                miparametro.CommandType = CommandType.StoredProcedure;

                miparametro.Parameters.AddWithValue("@pRol", objRol.Rol);
                miparametro.Parameters.AddWithValue("@pSiglas", objRol.Siglas);

                sqlCon.Open();
                mensaje = miparametro.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
                "No se pudo insertar correctamente los nuevos datos!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }

        public string Actualizar(CDRol objRolAct)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand miparametro = new SqlCommand("RolActualizar", sqlCon);
                miparametro.CommandType = CommandType.StoredProcedure;

                miparametro.Parameters.AddWithValue("@pIDRol", objRolAct.IDRol);
                miparametro.Parameters.AddWithValue("@pRol", objRolAct.Rol);
                miparametro.Parameters.AddWithValue("@pSiglas", objRolAct.Siglas);

                sqlCon.Open();
                mensaje = miparametro.ExecuteNonQuery() == 1 ? "Actualización de datos completada correctamente!" :
                "No se pudo actualizar correctamente los datos!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }

        public DataTable RolConsultar(String miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "RolConsultar"; //Nombre del Proc. Almacenado a usar
                sqlCmd.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro); //Se pasa el valor a buscar
                leerDatos = sqlCmd.ExecuteReader(); //Llenamos el SqlDataReader con los datos resultantes
                dt.Load(leerDatos); //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close(); //Se cierra la conexión
            }
            catch (Exception)
            {
                dt = null; //Si ocurre algun error se anula el DataTable
            }
            return dt; ////Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método MostrarConFiltro
    }

}