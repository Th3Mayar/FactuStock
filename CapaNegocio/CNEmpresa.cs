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
    class CNEmpresa
    {
        public static string Insertar(string pNombre, string pRazon_Social, int pTelefono, string pEmail, string pDireccion, decimal pITBIS, string pSlogan, string pImagen)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            objEmpresa.Nombre = pNombre;
            objEmpresa.Nombre = pNombre;
            objEmpresa.Email = pEmail;
            objEmpresa.Direccion = pDireccion;
            objEmpresa.ITBIS = pITBIS;
            objEmpresa.Slogan = pSlogan;
            objEmpresa.Imagen = pImagen;

            return objEmpresa.Insertar(objEmpresa);
        }

        public static string Actualizar(int pIDEmpresa, string pNombre, string pRazon_Social, int pTelefono, string pEmail, string pDireccion, decimal pITBIS, string pSlogan, string pImagen)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            objEmpresa.IDEmpresa = pIDEmpresa;
            objEmpresa.Nombre = pNombre;
            objEmpresa.Nombre = pNombre;
            objEmpresa.Email = pEmail;
            objEmpresa.Direccion = pDireccion;
            objEmpresa.ITBIS = pITBIS;
            objEmpresa.Slogan = pSlogan;
            objEmpresa.Imagen = pImagen;
            
            return objEmpresa.Actualizar(objEmpresa);
        }

        /*public static string InsertarActualizar(int accion, int pIDEmpresa, string pNombre, string pRazon_Social, int pTelefono, string pEmail, string pDireccion, decimal pITBIS, string pSlogan, string pImagen)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            objEmpresa.IDEmpresa = pIDEmpresa;
            objEmpresa.Nombre = pNombre;
            objEmpresa.Nombre = pNombre;
            objEmpresa.Email = pEmail;
            objEmpresa.Direccion = pDireccion;
            objEmpresa.ITBIS = pITBIS;
            objEmpresa.Slogan = pSlogan;
            objEmpresa.Imagen = pImagen;

            return objEmpresa.InsertarActualizar(objEmpresa, accion);
        }*/

        public DataTable ObtenerEmpresa(string miparametro)
        {
            CDEmpresa objEmpresa = new CDEmpresa();
            DataTable dt = new DataTable();
                                           
            dt = objEmpresa.EmpresaConsultar(miparametro);
            return dt; 
        }
    }
}
