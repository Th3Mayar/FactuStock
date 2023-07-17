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
    public class CNEmpleado
    {
        //Preparamos los datos para insertar un nuevo Suplidor. A los parametros recibidos les pongo el prefijo p
        public static string Insertar(int pIDEmpleado, string pEmpleado, string pDireccion, string pTelefono, string pContacto, string pRol, string pFecha_Nacimiento, string pApellido, string pEstado, string pNombre, string pRNC)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            objEmpleado.IDEmpleado = pIDEmpleado;
            objEmpleado.Empleado = pEmpleado;
            objEmpleado.Direccion = pDireccion;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.Contacto = pContacto;
            objEmpleado.Rol = pRol;
            objEmpleado.Fecha_Nacimiento = pFecha_Nacimiento;
            objEmpleado.Apellido = pApellido;
            objEmpleado.Estado = pEstado;
            objEmpleado.Nombre = pNombre;
            objEmpleado.RNC = pRNC;


            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objEmpleado.Insertar(objEmpleado);
        } //Fin del método Insertar



        public static string Actualizar(int pIDEmpleado, string pEmpleado, string pDireccion, string pTelefono, string pContacto, string pRol, string pFecha_Nacimiento, string pApellido, string pEstado, string pNombre, string pRNC)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            objEmpleado.IDEmpleado = pIDEmpleado;
            objEmpleado.Empleado = pEmpleado;
            objEmpleado.Direccion = pDireccion;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.Contacto = pContacto;
            objEmpleado.Rol = pRol;
            objEmpleado.Fecha_Nacimiento = pFecha_Nacimiento;
            objEmpleado.Apellido = pApellido;
            objEmpleado.Estado = pEstado;
            objEmpleado.Nombre = pNombre;
            objEmpleado.RNC = pRNC;
            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objEmpleado.Actualizar(objEmpleado);
        } //Fin del método Actualizar


        //Método utilizado para obtener un DataTable con todos los datos de la tabla
        //correspondiente
        public DataTable ObtenerEmpleado(string miparametro)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objEmpleado.EmpleadoConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }


        public static string InsertarActualizar(int accion, int pIDEmpleado, string pEmpleado, string pDireccion, string pTelefono, string pRol, string pFecha_Nacimiento, string pContacto, string pApellido, string pEstado, string pNombre, string pRNC)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            objEmpleado.IDEmpleado = pIDEmpleado;
            objEmpleado.Empleado = pEmpleado;
            objEmpleado.Direccion = pDireccion;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.Contacto = pContacto;
            objEmpleado.Rol = pRol;
            objEmpleado.Fecha_Nacimiento = pFecha_Nacimiento;
            objEmpleado.Apellido = pApellido;
            objEmpleado.Estado = pEstado;
            objEmpleado.Nombre = pNombre;
            objEmpleado.RNC = pRNC;






        }
    
}
