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
    public class CDEntradaInventario
    {
        private int dIDEntrada, dCantidad, dIDProducto, dIDEmpleado, dIDEstado;
        private DateTime dFechaEntrada;

        public CDEntradaInventario()
        {

        }

        public CDEntradaInventario(int pIDEntrada, DateTime pFechaEntrada, int pCantidad, int pIDProducto, int pIDEmpleado, int pIDEstado)
        {
            this.dIDEntrada = pIDEntrada;
            this.dFechaEntrada = pFechaEntrada;
            this.dCantidad = pCantidad;
            this.dIDProducto = pIDProducto;
            this.dIDEmpleado = pIDEmpleado;
            this.dIDEstado = pIDEstado;
        }

        #region

        public int IDEntrada
        {
            get { return dIDEntrada; }
            set { dIDEntrada = value; }
        }
        public DateTime FechaEntrada
        {
            get { return dFechaEntrada; }
            set { dFechaEntrada = value; }
        }
        public int Cantidad
        {
            get { return dCantidad; }
            set { dCantidad = value; }
        }
        public int IDProducto
        {
            get { return dIDProducto; }
            set { dIDProducto = value; }
        }
        public int IDEmpleado
        {
            get { return dIDEmpleado; }
            set { dIDEmpleado = value; }
        }
        public int IDEstado
        {
            get { return dIDEstado; }
            set { dIDEstado = value; }
        }

        #endregion

        public string Insertar(CDEntradaInventario objEntradaInventario)
        {
            string mensaje = "";
            //creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            //trataremos de hacer algunas operaciones con la tabla
            try
            {
                //asignamos a sqlCon la conexión con las base de datos a traves de la clase que creamos
                sqlCon.ConnectionString = Conexion.miconexion;

                SqlCommand micomando = new SqlCommand("EntradaInventarioInsertar", sqlCon);
                sqlCon.Open(); //Abro la conexión
                               //indico que se ejecutara un procedimiento almacenado
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pFechaEntrada", objEntradaInventario.FechaEntrada);
                micomando.Parameters.AddWithValue("@pCantidad", objEntradaInventario.Cantidad);
                micomando.Parameters.AddWithValue("@pIDProducto", objEntradaInventario.IDProducto);
                micomando.Parameters.AddWithValue("@pIDEmpleado", objEntradaInventario.IDEmpleado);
                micomando.Parameters.AddWithValue("@pIDEstado", objEntradaInventario.IDEstado);

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


        public string Actualizar(CDEntradaInventario objEntradaInventarioAct)
        {
            string mensaje = "";
            //creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            //trataremos de hacer algunas operaciones con la tabla
            try
            {
                //asignamos a sqlCon la conexión con las base de datos a traves de la clase que creamos
                sqlCon.ConnectionString = Conexion.miconexion;

                SqlCommand micomando = new SqlCommand("EntradaInventarioActualizar", sqlCon);
                sqlCon.Open(); //Abro la conexión
                               //indico que se ejecutara un procedimiento almacenado
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIDEntrada", objEntradaInventarioAct.IDEntrada);
                micomando.Parameters.AddWithValue("@pFechaEntrada", objEntradaInventarioAct.FechaEntrada);
                micomando.Parameters.AddWithValue("@pCantidad", objEntradaInventarioAct.Cantidad);
                micomando.Parameters.AddWithValue("@pIDProducto", objEntradaInventarioAct.IDProducto);
                micomando.Parameters.AddWithValue("@pIDEmpleado", objEntradaInventarioAct.IDEmpleado);
                micomando.Parameters.AddWithValue("@pIDEstado", objEntradaInventarioAct.IDEstado);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
                "No se pudo actualizar correctamente los nuevos datos!";
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

        //Método para consultar datos filtrados de la tabla. Se recibe el valor del parámetro
        public DataTable EntradaConsultar(String miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "EntradaInventarioConsultar"; //Nombre del Proc. Almacenado a usar
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

    } //fin
}
