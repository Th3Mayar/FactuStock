using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using CapaDatos;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNCliente
    {
        private static object accion;

        //Preparamos los datos para insertar un nuevo Suplidor. A los parametros recibidos les pongo el prefijo p
        public static string Insertar(int pIDCliente, string pCliente, string pDireccion, string pContacto, DateTime pFecha_Nacimiento, string pApellido, int pEstado, string pNombre, string pRNC)
        {
            CDCliente objCliente = new CDCliente();
            objCliente.IDCliente = pIDCliente;
            objCliente.Nombre = pCliente;
            objCliente.Direccion = pDireccion;
            objCliente.Contacto = pContacto;
            objCliente.FechaNacimiento = pFecha_Nacimiento;
            objCliente.Apellido = pApellido;
            objCliente.IDEstado = pEstado;
            objCliente.Nombre = pNombre;
            objCliente.Cedula = pRNC;


            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objCliente.Insertar(objCliente);
        } //Fin del método Insertar



        public static string Actualizar(int pIDCliente, string pCliente, string pDireccion, string pContacto, DateTime pFecha_Nacimiento, string pApellido, int pEstado, string pNombre, string pRNC)
        {
            CDCliente objCliente = new CDCliente();
            objCliente.IDCliente = pIDCliente;
            objCliente.Nombre = pCliente;
            objCliente.Direccion = pDireccion;
            objCliente.Contacto = pContacto;
            objCliente.FechaNacimiento = pFecha_Nacimiento;
            objCliente.Apellido = pApellido;
            objCliente.IDEstado = pEstado;
            objCliente.Nombre = pNombre;
            objCliente.Cedula = pRNC;
            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objCliente.Actualizar(objCliente);
        } //Fin del método Actualizar


        //Método utilizado para obtener un DataTable con todos los datos de la tabla
        //correspondiente
        public DataTable ObtenerCliente(string miparametro)
        {
            CDCliente objCliente = new CDCliente();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objCliente.ClienteConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }

    }

}
