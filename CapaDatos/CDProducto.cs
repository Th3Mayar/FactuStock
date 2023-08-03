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
    public class CDProducto
    {
        private int dCodigoProducto, dCantidad, dIDEstado, dIDCategoria, dIDCondicion;
        private decimal dPrecioUnitario;
        private string dNombre, dDescripcion, dImagen;


        public CDProducto()
        {

        }

        public CDProducto(int pCodigoProducto, string pNombre, string pDescripcion, string pImagen, int pCantidad, decimal pPrecioUnitario, int pIDEstado, int pIDCategoria, int pIDCondicion)
        {
            this.dCodigoProducto = pCodigoProducto;
            this.dNombre = pNombre;
            this.dDescripcion = pDescripcion;
            this.dImagen = pImagen;
            this.dCantidad = pCantidad;
            this.dPrecioUnitario = pPrecioUnitario;
            this.dIDEstado = pIDEstado;
            this.dIDCategoria = pIDCategoria;
            this.dIDCondicion = pIDCondicion;
        }

        #region
        public int CodigoProducto
        {
            get { return dCodigoProducto; }
            set { dCodigoProducto = value; }
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
        public string Imagen
        {
            get { return dImagen; }
            set { dImagen = value; }
        }
        public int Cantidad
        {
            get { return dCantidad; }
            set { dCantidad = value; }
        }
        public decimal PrecioUnitario
        {
            get { return dPrecioUnitario; }
            set { dPrecioUnitario = value; }
        }
        public int IDEstado
        {
            get { return dIDEstado; }
            set { dIDEstado = value; }
        }
        public int IDCategoria
        {
            get { return dIDCategoria; }
            set { dIDCategoria = value; }
        }
        public int IDCondicion
        {
            get { return dIDCondicion; }
            set { dIDCondicion = value; }
        }

        #endregion

        public string Insertar(CDProducto objProducto)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {

                sqlCon.ConnectionString = Conexion.miconexion;

                SqlCommand micomando = new SqlCommand("ProductoInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre", objProducto.Nombre);
                micomando.Parameters.AddWithValue("@pDescripcion", objProducto.Descripcion);
                micomando.Parameters.AddWithValue("@pImagen", objProducto.Imagen);
                micomando.Parameters.AddWithValue("@pCantidad", objProducto.Cantidad);
                micomando.Parameters.AddWithValue("@pPrecioUnitario", objProducto.PrecioUnitario);
                micomando.Parameters.AddWithValue("@pIDEstado", objProducto.IDEstado);
                micomando.Parameters.AddWithValue("@pIDCategoria", objProducto.IDCategoria);
                micomando.Parameters.AddWithValue("@pIDCondicion", objProducto.IDCondicion);

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

        public string Actualizar(CDProducto objProductoAct)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("ProductoActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pIDProducto", objProductoAct.CodigoProducto);
                micomando.Parameters.AddWithValue("@pNombre", objProductoAct.Nombre);
                micomando.Parameters.AddWithValue("@pDescripcion", objProductoAct.Descripcion);
                micomando.Parameters.AddWithValue("@pImagen", objProductoAct.Imagen);
                micomando.Parameters.AddWithValue("@pCantidad", objProductoAct.Cantidad);
                micomando.Parameters.AddWithValue("@pPrecioUnitario", objProductoAct.PrecioUnitario);
                micomando.Parameters.AddWithValue("@pIDEstado", objProductoAct.IDEstado);
                micomando.Parameters.AddWithValue("@pIDCategoria", objProductoAct.IDCategoria);
                micomando.Parameters.AddWithValue("@pIDCondicion", objProductoAct.IDCondicion);

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
        public DataTable ProductoConsultar(String miparametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "ProductoConsultar"; //Nombre del Proc. Almacenado a usar
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