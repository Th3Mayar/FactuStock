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
    public class CDEmpleado
    {
        private int dIDEmpleado, dTelefono;
        private string dCedula, dNombre, dApellido, dContacto, dDireccion, dRol;
        private DateTime dFechaNacimiento;
        private string dEstado;

        public CDEmpleado()
        {

        }

        public CDEmpleado(int pIDEmpleado, string pCedula, string pNombre, string pApellido, string pContacto, string pDireccion, DateTime pFechaNacimiento, string pEstado, string pRol, int pTelefono)
        {
            this.dIDEmpleado = pIDEmpleado;
            this.dCedula = pCedula;
            this.dNombre = pNombre;
            this.dApellido = pApellido;
            this.dContacto = pContacto;
            this.dDireccion = pDireccion;
            this.dFechaNacimiento = pFechaNacimiento;
            this.dEstado = pEstado;
            this.dRol = pRol;
            this.dTelefono = pTelefono;
        }

        public int IDEmpleado
        {
            get { return dIDEmpleado; }
            set { dIDEmpleado = value; }
        }

        public string Cedula
        {
            get { return dCedula; }
            set { dCedula = value; }
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

        public string Rol
        {
            get { return dRol; }
            set { dRol = value; }
        }

        public int Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }

        public string Insertar(CDEmpleado objEmpleado)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("EmpleadoInsertar", sqlCon);
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pCedula", objEmpleado.Cedula);
                micomando.Parameters.AddWithValue("@pNombre", objEmpleado.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objEmpleado.Apellido);
                micomando.Parameters.AddWithValue("@pContacto", objEmpleado.Contacto);
                micomando.Parameters.AddWithValue("@pDireccion", objEmpleado.Direccion);
                micomando.Parameters.AddWithValue("@pFechaNacimiento", objEmpleado.FechaNacimiento);
                micomando.Parameters.AddWithValue("@pEstado", objEmpleado.Estado);
                micomando.Parameters.AddWithValue("@pRol", objEmpleado.Rol);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpleado.Telefono);

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

        public string Actualizar(CDEmpleado objEmpleadoAct)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("EmpleadoActualizar", sqlCon);
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIDEmpleado", objEmpleadoAct.IDEmpleado);
                micomando.Parameters.AddWithValue("@pCedula", objEmpleadoAct.Cedula);
                micomando.Parameters.AddWithValue("@pNombre", objEmpleadoAct.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objEmpleadoAct.Apellido);
                micomando.Parameters.AddWithValue("@pContacto", objEmpleadoAct.Contacto);
                micomando.Parameters.AddWithValue("@pDireccion", objEmpleadoAct.Direccion);
                micomando.Parameters.AddWithValue("@pFechaNacimiento", objEmpleadoAct.FechaNacimiento);
                micomando.Parameters.AddWithValue("@pIDEstado", objEmpleadoAct.Estado);
                micomando.Parameters.AddWithValue("@pIDRol", objEmpleadoAct.Rol);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpleadoAct.Telefono);

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
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlmicomando = new SqlCommand(); //Establecer el comando
                sqlmicomando.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlmicomando.Connection.Open(); //Se abre la conexión
                sqlmicomando.CommandText = "EmpleadoConsultar"; //Nombre del Proc. Almacenado a usar
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