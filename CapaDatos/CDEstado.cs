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
    public class CDEstado
    {
        private int dIDEstado;
        private string dEstado, dSigla;

        public CDEstado()
        {

        }

        public CDEstado(int pIDEstado, string pEstado, string pSigla)
        {
            this.dIDEstado = pIDEstado;
            this.dEstado = pEstado;
            this.dSigla = pSigla;
        }

        #region
        public int IDEstado
        {
            get { return dIDEstado; }
            set { dIDEstado = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        public string Sigla
        {
            get { return dSigla; }
            set { dSigla = value; }
        }

        #endregion

        //método para insertar un nuevo Suplidor. Recibirá el objeto objSuplidor como parámetro
        public string Insertar(CDEstado objEstado)
        {
            string mensaje = "";
            //creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            //trataremos de hacer algunas operaciones con la tabla
            try
            {
                //asignamos a sqlCon la conexión con las base de datos a traves de la clase que creamos
                sqlCon.ConnectionString = Conexion.miconexion;

                SqlCommand micomando = new SqlCommand("EstadoInsertar", sqlCon);
                sqlCon.Open(); //Abro la conexión
                               //indico que se ejecutara un procedimiento almacenado
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pEstado", objEstado.Estado);
                micomando.Parameters.AddWithValue("@pSigla", objEstado.Sigla);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
                      "No se pudo insertar correctamente los nuevos datos!";
            }
            catch (Exception ex) //Si ocurre algún error se captura y se muestra el mensaje
            {
                mensaje = ex.Message;
            }
            finally // Luego de realizar el proceso de forma correcta o no
            {
                //Cierro la conexión si está abierta
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            //Devuelvo el mensaje correspondiente de acuerdo a lo que haya resultado del comando
            return mensaje;
        }

        public string Actualizar(CDEstado objEstadoAct)
        {
            string mensaje = "";
            //creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            //trataremos de hacer algunas operaciones con la tabla
            try
            {
                //asignamos a sqlCon la conexión con las base de datos a traves de la clase que creamos
                sqlCon.ConnectionString = Conexion.miconexion;

                SqlCommand micomando = new SqlCommand("EstadoActualizar", sqlCon);
                sqlCon.Open(); //Abro la conexión
                               //indico que se ejecutara un procedimiento almacenado
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIDEstado", objEstadoAct.IDEstado);
                micomando.Parameters.AddWithValue("@pEstado", objEstadoAct.Estado);
                micomando.Parameters.AddWithValue("@pSigla", objEstadoAct.Sigla);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Actualización de datos completada correctamente!" :
                      "No se pudo actualizar correctamente los nuevos datos!";
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

        /*public string InsertarActualizar(CDEstado objEstado, int accion)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando;

                if (accion == Accion.Insertar)
                {
                    micomando = new SqlCommand("EstadoInsertar", sqlCon);
                }
                else if (accion == Accion.Actualizar)
                {
                    micomando = new SqlCommand("EstadoActualizar", sqlCon);
                }
                else
                {
                    return "Acción no válida. Debe ser Insertar o Actualizar.";
                }

                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIDEstado", objEstado.IDEstado);
                micomando.Parameters.AddWithValue("@pEstado", objEstado.Estado);
                micomando.Parameters.AddWithValue("@pSigla", objEstado.Sigla);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Operación completada correctamente!" :
                      "No se pudo realizar correctamente la operación.";

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
        }*/

        //Método para consultar datos filtrados de la tabla. Se recibe el valor del parámetro
        public DataTable EstadoConsultar(String miparametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "EstadoConsultar"; //Nombre del Proc. Almacenado a usar
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

