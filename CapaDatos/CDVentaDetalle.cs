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
    public class CDVentaDetalle
    {
        private int dIDVentaDetalle, dNumFactura, dIDProducto, dCantidad;
        private decimal dPrecioventa;

        public CDVentaDetalle()
        {

        }

        public CDVentaDetalle(int pIDVentaDetalle, int pNumFactura, int pIDProducto, int pCantidad, decimal pPrecioventa)
        {
            this.dIDVentaDetalle = pIDVentaDetalle ;
            this.dNumFactura = pNumFactura;
            this.dIDProducto = pIDProducto;
            this.dCantidad = pCantidad;
        }

        #region

        public int IDVentaDetalle
        {
            get { return dIDVentaDetalle; }
            set { dIDVentaDetalle = value; }
        }
        public int NumFactura
        {
            get { return dNumFactura; }
            set { dNumFactura = value; }
        }
        public int IDProducto
        {
            get { return dIDProducto; }
            set { dIDProducto = value; }
        }
        public int Cantidad
        {
            get { return dCantidad; }
            set { dCantidad = value; }
        }
        public decimal Precioventa
        {
            get { return dPrecioventa; }
            set { dPrecioventa = value; }
        }
        
        #endregion

        // método para insertar una nueva venta. Recibirá el objeto objVentaDetalle como parámetro
        public string Insertar(CDVentaDetalle objVentaDetalle)
        {
            string mensaje = "";
            // creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            // trataremos de hacer algunas operaciones con la tabla
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("VentaDetalleInsertar", sqlCon);
                sqlCon.Open(); // Abro la conexión
                               // indico que se ejecutara un procedimiento almacenado

                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pNumFactura", objVentaDetalle.NumFactura);
                micomando.Parameters.AddWithValue("@pIDProducto", objVentaDetalle.IDProducto);
                micomando.Parameters.AddWithValue("@pCantidad", objVentaDetalle.Cantidad);
                micomando.Parameters.AddWithValue("@pPrecioVenta", objVentaDetalle.Precioventa);

                // hasta aquí el pase de parámetros

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
                      "No se pudo insertar correctamente los nuevos datos!";
            }
            catch (Exception ex) // Si ocurre algún error se captura y se muestra el mensaje
            {
                mensaje = ex.Message;
            }
            finally // Luego de realizar el proceso de forma correcta o no
            {
                // Cierro la conexión si está abierta
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            // Devuelvo el mensaje correspondiente de acuerdo a lo que haya resultado del comando
            return mensaje;
        }

        // método para actualizar los datos del Suplidor. Recibirá el objeto objSuplidor como parámetro
        public string Actualizar(CDVentaDetalle objVentaDetalle)
        {
            string mensaje = "";
            // creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            // trataremos de hacer algunas operaciones con la tabla
            try
            {
                // asignamos a sqlCon la conexión con las base de datos a traves de la clase que creamos
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("VentaDetalleActualizar", sqlCon);
                sqlCon.Open(); // Abro la conexión
                               // indico que se ejecutara un procedimiento almacenado

                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIDVentaDetalle", objVentaDetalle.IDVentaDetalle);
                micomando.Parameters.AddWithValue("@pNumFactura", objVentaDetalle.NumFactura);
                micomando.Parameters.AddWithValue("@pIDProducto", objVentaDetalle.IDProducto);
                micomando.Parameters.AddWithValue("@pCantidad", objVentaDetalle.Cantidad);
                micomando.Parameters.AddWithValue("@pPrecioVenta", objVentaDetalle.Precioventa);

                // hasta aquí el pase de parámetros

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

        // Método para consultar datos filtrados de la tabla. Se recibe el valor del parámetro
        public DataTable VentaDetalleConsultar(String miparametro)
        {
            DataTable dt = new DataTable(); // Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; // Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); // Establecer el comando
                sqlCmd.Connection = new Conexion().dbconexion; // Conexión que va a usar el comando
                sqlCmd.Connection.Open(); // Se abre la conexión
                sqlCmd.CommandText = "VentaDetalleConsultar"; // Nombre del Proc. Almacenado a usar
                sqlCmd.CommandType = CommandType.StoredProcedure; // Se trata de un proc. almacenado
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro); // Se pasa el valor a buscar
                leerDatos = sqlCmd.ExecuteReader(); // Llenamos el SqlDataReader con los datos resultantes
                dt.Load(leerDatos); // Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close(); // Se cierra la conexión
            }
            catch (Exception ex)
            {
                dt = null; // Si ocurre algun error se anula el DataTable
            }
            return dt; //// Se retorna el DataTable segun lo ocurrido arriba

        } // Fin del método MostrarConFiltro
    }
}
