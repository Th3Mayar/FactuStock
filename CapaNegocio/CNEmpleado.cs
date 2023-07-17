using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using CapaDatos;

namespace CapaNegocio
{
    public class CNEmpleado
    {
        //Preparamos los datos para insertar un nuevo Suplidor. A los parametros recibidos les pongo el prefijo p
        public static string Insertar(string pCedula, string pNombre, string pApellido, string pContacto, string pDireccion, int pTelefono, DateTime pFechaNacimiento, int pIDEstado, int pIDRol)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            objEmpleado.Cedula = pCedula;
            objEmpleado.Nombre = pNombre;
            objEmpleado.Apellido = pApellido;
            objEmpleado.Contacto = pContacto;
            objEmpleado.Direccion = pDireccion;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.FechaNacimiento = pFechaNacimiento;
            objEmpleado.IDEstado = pIDEstado;
            objEmpleado.IDRol = pIDRol;

            return objEmpleado.Insertar(objEmpleado);
        } //Fin del método Insertar

        public static string Actualizar(int pIDEmpleado, string pCedula, string pNombre, string pApellido, string pContacto, string pDireccion, int pTelefono, DateTime pFechaNacimiento, int pIDEstado, int pIDRol)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            objEmpleado.IDEmpleado = pIDEmpleado;
            objEmpleado.Cedula = pCedula;
            objEmpleado.Nombre = pNombre;
            objEmpleado.Apellido = pApellido;
            objEmpleado.Contacto = pContacto;
            objEmpleado.Direccion = pDireccion;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.FechaNacimiento = pFechaNacimiento;
            objEmpleado.IDEstado = pIDEstado;
            objEmpleado.IDRol = pIDRol;

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

        /*
        public static string InsertarActualizar(int accion, int pIDEmpleado, string pCedula, string pNombre, string pApellido, string pContacto, string pDireccion, int pTelefono, DateTime pFechaNacimiento, int pIDEstado, int pIDRol)
        {
            CDEmpleado objEmpleado = new CDEmpleado();
            objEmpleado.IDEmpleado = pIDEmpleado;
            objEmpleado.Cedula = pCedula;
            objEmpleado.Nombre = pNombre;
            objEmpleado.Apellido = pApellido;
            objEmpleado.Contacto = pContacto;
            objEmpleado.Direccion = pDireccion;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.FechaNacimiento = pFechaNacimiento;
            objEmpleado.IDEstado = pIDEstado;
            objEmpleado.IDRol = pIDRol;
        }*/
    }
}
