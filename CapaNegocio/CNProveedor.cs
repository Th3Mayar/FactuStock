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
    public class CNProveedor
    {
        public static string Insertar(int pIDProveedor, string pNombreEmpresa, DateTime pFechaRegistro, string pContacto, string pTelefono, string pDireccion, string pRepresentante, int IDEstado)
        {
            CDProveedor objProveedor = new CDProveedor();
            objProveedor.IDProveedor = pIDProveedor;
            objProveedor.NombreEmpresa = pNombreEmpresa;
            objProveedor.FechaRegistro = pFechaRegistro;
            objProveedor.Contacto = pContacto;
            objProveedor.Telefono = pTelefono;
            objProveedor.Direccion = pDireccion;
            objProveedor.Representante = pRepresentante;
            objProveedor.IDEstado = IDEstado;
            return objProveedor.Insertar(objProveedor);
        }
        public static string Actualizar(int pIDProveedor, string pNombreEmpresa, DateTime pFechaRegistro, string pContacto, string pTelefono, string pDireccion, string pRepresentante, int IDEstado)
        {
            CDProveedor objProveedor = new CDProveedor();
            objProveedor.IDProveedor = pIDProveedor;
            objProveedor.NombreEmpresa = pNombreEmpresa;
            objProveedor.FechaRegistro = pFechaRegistro;
            objProveedor.Contacto = pContacto;
            objProveedor.Telefono = pTelefono;
            objProveedor.Direccion = pDireccion;
            objProveedor.Representante = pRepresentante;
            objProveedor.IDEstado = IDEstado;
            return objProveedor.Actualizar(objProveedor);
        }

        //Método utilizado para obtener un DataTable con todos los datos de la tabla correspondiente
        public DataTable ObtenerProveedor(string miparametro)
        {
            CDProveedor objProveedor = new CDProveedor();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = objProveedor.ProveedorConsultar(miparametro); //El DataTable se llena con todos los datos devueltos
            return dt; //Se retorna el DataTable con los datos adquiridos
        }
    }
}