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
    public class CDEmpresa
    {
        private int dIDEmpresa, dTelefono;
        private string dNombre, dRazon_Social, dEmail, dDireccion, dSlogan, dImagen;
        private decimal dITBIS;

        public CDEmpresa()
        {

        }

        public CDEmpresa(int pIDEmpresa, string pNombre, string pRazon_Social, int pTelefono, string pEmail, string pDireccion, decimal pITBIS, string pSlogan, string pImagen)
        {
            this.dIDEmpresa = pIDEmpresa;
            this.dNombre = pNombre;
            this.dRazon_Social = pRazon_Social;
            this.dTelefono = pTelefono;
            this.dEmail = pEmail;
            this.dDireccion = pDireccion;
            this.dITBIS = pITBIS;
            this.dSlogan = pSlogan;
            this.dImagen = pImagen;
        }

        public int IDEmpresa
        {
            get { return dIDEmpresa; }
            set { dIDEmpresa = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }

        public string Razon_Social
        {
            get { return dRazon_Social; }
            set { dRazon_Social = value; }
        }

        public int Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }

        public string Email
        {
            get { return dEmail; }
            set { dEmail = value; }
        }

        public decimal ITBIS
        {
            get { return dITBIS; }
            set { dITBIS = value; }
        }

        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }

        public string Slogan
        {
            get { return dSlogan; }
            set { dSlogan = value; }
        }

        public string Imagen
        {
            get { return dImagen; }
            set { dImagen = value; }
        }


        public string Insertar(CDEmpresa objEmpresa)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("EmpresaInsertar", sqlCon);
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pNombre", objEmpresa.Nombre);
                micomando.Parameters.AddWithValue("@pRazonSocial", objEmpresa.Razon_Social);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpresa.Telefono);
                micomando.Parameters.AddWithValue("@pEmail", objEmpresa.Email);
                micomando.Parameters.AddWithValue("@pDireccion", objEmpresa.Direccion);
                micomando.Parameters.AddWithValue("@pITBIS", objEmpresa.ITBIS);
                micomando.Parameters.AddWithValue("@pSlogan", objEmpresa.Slogan);
                micomando.Parameters.AddWithValue("@pImage", objEmpresa.Imagen);

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

        public string Actualizar(CDEmpresa objEmpresaAct)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("EmpresaActualizar", sqlCon);
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pIDEmpresa", objEmpresaAct.IDEmpresa);
                micomando.Parameters.AddWithValue("@pNombre", objEmpresaAct.Nombre);
                micomando.Parameters.AddWithValue("@pRazonSocial", objEmpresaAct.Razon_Social);
                micomando.Parameters.AddWithValue("@pTelefono", objEmpresaAct.Telefono);
                micomando.Parameters.AddWithValue("@pEmail", objEmpresaAct.Email);
                micomando.Parameters.AddWithValue("@pDireccion", objEmpresaAct.Direccion);
                micomando.Parameters.AddWithValue("@pITBIS", objEmpresaAct.ITBIS);
                micomando.Parameters.AddWithValue("@pSlogan", objEmpresaAct.Slogan);
                micomando.Parameters.AddWithValue("@pImage", objEmpresaAct.Imagen);

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

        public DataTable EmpresaConsultar(String miparametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlmicomando = new SqlCommand(); //Establecer el comando
                sqlmicomando.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlmicomando.Connection.Open(); //Se abre la conexión
                sqlmicomando.CommandText = "EmpresaConsultar"; //Nombre del Proc. Almacenado a usar
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
