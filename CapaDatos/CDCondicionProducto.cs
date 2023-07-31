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
    public class CDCondicionProducto
    {
        private int dIDCondicion;
        private string dDescripcion, dSigla;

        public CDCondicionProducto()
        {

        }

        public CDCondicionProducto(int pIDCondicion, string pDescripcion, string pSigla)
        {
            this.dIDCondicion = pIDCondicion;
            this.dDescripcion = pDescripcion;
            this.dSigla = pSigla;
        }

        #region

        public int IDCondicion
        {
            get { return dIDCondicion; }
            set { dIDCondicion = value; }
        }

        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }

        public string Sigla
        {
            get { return dSigla; }
            set { dSigla = value; }
        }

        #endregion

        public string Insertar(CDCondicionProducto objCondicion)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("CondicionProductoInsertar", sqlCon);
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pDescripcion", objCondicion.dDescripcion);
                micomando.Parameters.AddWithValue("@pSigla", objCondicion.Sigla);

                sqlCon.Open();
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

        public string Actualizar(CDCondicionProducto objCondicionAct)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("CondicionProductoActualizar", sqlCon);
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIDCondicion", objCondicionAct.IDCondicion);
                micomando.Parameters.AddWithValue("@pDescripcion", objCondicionAct.Descripcion);
                micomando.Parameters.AddWithValue("@pSigla", objCondicionAct.Sigla);

                sqlCon.Open();
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Actualización de datos completada correctamente!" :
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

        public DataTable CondicionConsultar(String miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlmicomando = new SqlCommand(); //Establecer el comando
                sqlmicomando.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlmicomando.Connection.Open(); //Se abre la conexión
                sqlmicomando.CommandText = "CondicionProductoConsultar"; //Nombre del Proc. Almacenado a usar
                sqlmicomando.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado
                sqlmicomando.Parameters.AddWithValue("@pvalor", miparametro); //Se pasa el valor a buscar
                leerDatos = sqlmicomando.ExecuteReader(); //Llenamos el SqlDataReader con los datos resultantes
                dt.Load(leerDatos); //Se cargan los registros devueltos al DataTable
                sqlmicomando.Connection.Close(); //Se cierra la conexión
            }
            catch (Exception)
            {
                dt = null; //Si ocurre algun error se anula el DataTable
            }
            return dt; //Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método MostrarConFiltro
    }
}
