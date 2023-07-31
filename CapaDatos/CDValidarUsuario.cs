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
        private int dIDUsuario, dIDRol;
        private string dUsuario, dPass, dToken;


        public CDValidarUsuario()
        {

        }

        public CDValidarUsuario(int pIDUsuario, string pUsuario, string pPass, string pToken, int pIDRol)
        {
            this.dIDUsuario = pIDUsuario;
            this.dUsuario = pUsuario;
            this.dPass = pPass;
            this.dToken = pToken;
            this.dIDRol = pIDRol;
        }

        #region 
        public int IDUsuario
        {
            get { return dIDUsuario; }
            set { dIDUsuario = value; }
        }
        public string Usuario
        {
            get { return dUsuario; }
            set { dUsuario = value; }
        }
        public string Pass
        {
            get { return dPass; }
            set { dPass = value; }
        }
        public string Token
        {
            get { return dToken; }
            set { dToken = value; }
        }
        public int IDRol
        {
            get { return dIDRol; }
            set { dIDRol = value; }
        }

        #endregion

        public DataTable ValidarUsuario(string usuario, string pass)
        {
            SqlConnection sqlCon = new SqlConnection();
            DataTable dtResultado = new DataTable();

            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;

                SqlCommand micomando = new SqlCommand("UsuarioValidar", sqlCon);
                micomando.CommandType = CommandType.StoredProcedure; // Indicar que es un procedimiento almacenado

                // Agregar los parámetros de usuario y contraseña a la consulta
                micomando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario;
                micomando.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass;

                sqlCon.Open();

                // Ejecutar la consulta y obtener el resultado en un DataTable
                SqlDataAdapter da = new SqlDataAdapter(micomando);
                da.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, agregar una columna "Mensaje" al DataTable con el mensaje de error.
                dtResultado.Columns.Add("Mensaje", typeof(string));
                dtResultado.Rows.Add(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return dtResultado;
        }

        public string Insertar(CDValidarUsuario objValidate)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {

                sqlCon.ConnectionString = Conexion.miconexion;

                SqlCommand micomando = new SqlCommand("UsuarioInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pUsuario", objValidate.Usuario);
                micomando.Parameters.AddWithValue("@pPass", objValidate.Pass);
                micomando.Parameters.AddWithValue("@pIDRol", objValidate.IDRol);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
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

        public string Actualizar(CDValidarUsuario objValidate)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("UsuarioActualizar", sqlCon);
                sqlCon.Open();
                micomando.Parameters.AddWithValue("@pIDUsuario", objValidate.IDUsuario);
                micomando.Parameters.AddWithValue("@pUsuario", objValidate.Usuario);
                micomando.Parameters.AddWithValue("@pPass", objValidate.Pass);
                micomando.Parameters.AddWithValue("@pIDRol", objValidate.IDRol);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Datos actualizados correctamente!" :
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
        //Método para consultar datos filtrados de la tabla. Se recibe el valor del parámetro
        public DataTable UsuarioConsultar(String miparametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader

            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "UsuarioConsultar"; //Nombre del Proc. Almacenado a usar
                sqlCmd.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro); //Se pasa el valor a buscar
                leerDatos = sqlCmd.ExecuteReader(); //Llenamos el SqlDataReader con los datos resultantes
                dt.Load(leerDatos); //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close(); //Se cierra la conexión
            }
            catch (Exception ex)
            {
                dt = null; //Si ocurre algun error se anula el DataTable
            }
            return dt; ////Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método MostrarConFiltro
    }
}
