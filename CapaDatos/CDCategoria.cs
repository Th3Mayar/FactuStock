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
    public class CDCategoria
    {
        private int dIDCategoria, dIDEstado;
        private string dNombre, dDescripcion;


        public CDCategoria()
        {

        }

        public CDCategoria(int pIDCategoria, string pNombre, string pDescripcion, int pIDEstado)
        {
            this.dIDCategoria = pIDCategoria;
            this.dNombre = pNombre;
            this.dDescripcion = pDescripcion;
            this.dIDEstado = pIDEstado;

        }

        #region
        public int IDCategoria
        {
            get { return dIDCategoria; }
            set { dIDCategoria = value; }
        }
        public int IDEstado
        {
            get { return dIDEstado; }
            set { dIDEstado = value; }
        }
        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }
        #endregion

        public string Insertar(CDCategoria objCategoria)
        {
            string mensaje = "";

            SqlConnection sqlCon = new SqlConnection();

            try
            {

                sqlCon.ConnectionString = Conexion.miconexion;

                SqlCommand micomando = new SqlCommand("CategoriaProductoInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pCategoria", objCategoria.Nombre);
                micomando.Parameters.AddWithValue("@pDescripcion", objCategoria.Descripcion);
                micomando.Parameters.AddWithValue("@pIDEstado", objCategoria.IDEstado);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
                "No se pudo insertar correctamente los nuevos datos!";
            }
            catch (Exception ex) //Si ocurre algún error se captura y se muestra el mensaje
            {
                mensaje = ex.Message;
            }
            finally //Luego de realizar el proceso de forma correcta o no
            {
                //Cierro la conexión si está abierta
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            //Devuelvo el mensaje correspondiente de acuerdo a lo que haya resultado del comando
            return mensaje;
        }
        public string Actualizar(CDCategoria objCategoriaAct)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("CategoriaProductoActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pIDCategoria", objCategoriaAct.IDCategoria);
                micomando.Parameters.AddWithValue("@pNombre", objCategoriaAct.Nombre);
                micomando.Parameters.AddWithValue("@pDescripcion", objCategoriaAct.Descripcion);
                micomando.Parameters.AddWithValue("@pIDEstado", objCategoriaAct.IDEstado);
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
        public DataTable CategoriaProductoConsultar(String miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "CategoriaProductoConsultar"; //Nombre del Proc. Almacenado a usar
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