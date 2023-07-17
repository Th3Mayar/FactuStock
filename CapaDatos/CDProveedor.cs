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
    public class CDProveedor
    {
        private int dIDProveedor, dCantidad, dIDEstado;
        private DateTime dFechaRegistro;
        private string dNombreEmpresa, dContacto, dTelefono, dDireccion, dRepresentante;


        public CDProveedor()
        {

        }

        public CDProveedor(int pIDProveedor, int pCantidad, int pIDEstado, DateTime pFechaRegistro, string pNombreEmpresa, string pContacto, string pTelefono, string pDireccion, string pRepresentante)
        {
            this.dIDProveedor = pIDProveedor;
            this.dCantidad = pCantidad;
            this.dIDEstado = pIDEstado;
            this.dFechaRegistro = pFechaRegistro;
            this.dNombreEmpresa = pNombreEmpresa;
            this.dContacto = pContacto;
            this.dTelefono = pTelefono;
            this.dDireccion = pDireccion;
            this.dRepresentante = pRepresentante;
        }

        #region
        public int IDProveedor
        {
            get { return dIDProveedor; }
            set { dIDProveedor = value; }
        }
        public int Cantidad
        {
            get { return dCantidad; }
            set { dCantidad = value; }
        }
        public int IDEstado
        {
            get { return dIDEstado; }
            set { dIDEstado = value; }
        }
        public DateTime FechaRegistro
        {
            get { return dFechaRegistro; }
            set { dFechaRegistro = value; }
        }
        public string NombreEmpresa
        {
            get { return dNombreEmpresa; }
            set { dNombreEmpresa = value; }
        }
        public string Contacto
        {
            get { return dContacto; }
            set { dContacto = value; }
        }
        public string Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }
        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }
        public string Representante
        {
            get { return dRepresentante; }
            set { dRepresentante = value; }
        }
        #endregion
        public string Insertar(CDProveedor objProveedor)
        {
            string mensaje = "";

            SqlConnection sqlCon = new SqlConnection();

            try
            {

                sqlCon.ConnectionString = Conexion.miconexion;

                SqlCommand micomando = new SqlCommand("ProveedorInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pIDProveedor", objProveedor.IDProveedor);
                micomando.Parameters.AddWithValue("@pCantidad", objProveedor.Cantidad);
                micomando.Parameters.AddWithValue("@pIDEstado", objProveedor.IDEstado);
                micomando.Parameters.AddWithValue("@pFechaRegistro", objProveedor.FechaRegistro);
                micomando.Parameters.AddWithValue("@pNombreEmpresa", objProveedor.NombreEmpresa);
                micomando.Parameters.AddWithValue("@pContacto", objProveedor.Contacto);
                micomando.Parameters.AddWithValue("@pTelefono", objProveedor.Telefono);
                micomando.Parameters.AddWithValue("@pDireccion", objProveedor.Direccion);
                micomando.Parameters.AddWithValue("@pRepresentante", objProveedor.Representante);


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

        public string Actualizar(CDProveedor objProveedor)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("ProveedorActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pIDProveedor", objProveedor.IDProveedor);
                micomando.Parameters.AddWithValue("@pCantidad", objProveedor.Cantidad);
                micomando.Parameters.AddWithValue("@pIDEstado", objProveedor.IDEstado);
                micomando.Parameters.AddWithValue("@pFechaRegistro", objProveedor.FechaRegistro);
                micomando.Parameters.AddWithValue("@pNombreEmpresa", objProveedor.NombreEmpresa);
                micomando.Parameters.AddWithValue("@pContacto", objProveedor.Contacto);
                micomando.Parameters.AddWithValue("@pTelefono", objProveedor.Telefono);
                micomando.Parameters.AddWithValue("@pDireccion", objProveedor.Direccion);
                micomando.Parameters.AddWithValue("@pRepresentante", objProveedor.Representante);

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
        public DataTable ProveedorConsultar(String miparametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "ProveedorConsultar"; //Nombre del Proc. Almacenado a usar
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