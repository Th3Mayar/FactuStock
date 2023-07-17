using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCliente
    {
        private int dIDCliente, dIDEstado;
        private string dCedula, dNombre, dApellido, dContacto, dDireccion;
        private DateTime dFechaNacimiento;

        public CDCliente()
        {

        }

        public CDCliente(int pIDCliente, string pCedula, string pNombre, string pApellido, string pContacto, string pDireccion, DateTime pFechaNacimiento, int pIDEstado)
        {
            this.dIDCliente = pIDCliente;
            this.dCedula = pCedula;
            this.dNombre = pNombre;
            this.dApellido = pApellido;
            this.dContacto = pContacto;
            this.dDireccion = pDireccion;
            this.dFechaNacimiento = pFechaNacimiento;
            this.dEstado = pEstado;
        }

        #region

        public int IDCliente
        {
            get { return dIDCliente; }
            set { dIDCliente = value; }
        }

        public string RNC
        {
            get { return dRNC; }
            set { dRNC = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }

        public string Apellido
        {
            get { return dApellido; }
            set { dApellido = value; }
        }

        public string Contacto
        {
            get { return dContacto; }
            set { dContacto = value; }
        }

        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return dFechaNacimiento; }
            set { dFechaNacimiento = value; }
        }

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        #endregion

        public string Insertar(CDCliente objCliente)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("ClienteInsertar", sqlCon);
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pRNC", objCliente.RNC);
                micomando.Parameters.AddWithValue("@pNombre", objCliente.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objCliente.Apellido);
                micomando.Parameters.AddWithValue("@pContacto", objCliente.Contacto);
                micomando.Parameters.AddWithValue("@pDireccion", objCliente.Direccion);
                micomando.Parameters.AddWithValue("@pFechaNacimiento", objCliente.FechaNacimiento);
                micomando.Parameters.AddWithValue("@pEstado", objCliente.Estado);

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

        public string Actualizar(CDCliente objClienteAct)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("ClienteActualizar", sqlCon);
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIDCliente", objClienteAct.IDCliente);
                micomando.Parameters.AddWithValue("@pRNC", objClienteAct.RNC);
                micomando.Parameters.AddWithValue("@pNombre", objClienteAct.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objClienteAct.Apellido);
                micomando.Parameters.AddWithValue("@pContacto", objClienteAct.Contacto);
                micomando.Parameters.AddWithValue("@pDireccion", objClienteAct.Direccion);
                micomando.Parameters.AddWithValue("@pFechaNacimiento", objClienteAct.FechaNacimiento);
                micomando.Parameters.AddWithValue("@pEstado", objClienteAct.Estado);

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

        public DataTable ClienteConsultar(String miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlmicomando = new SqlCommand(); //Establecer el comando
                sqlmicomando.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlmicomando.Connection.Open(); //Se abre la conexión
                sqlmicomando.CommandText = "lienteConsultar"; //Nombre del Proc. Almacenado a usar
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
            return dt; ////Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método MostrarConFiltro
    }

}