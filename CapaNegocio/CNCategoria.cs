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
    public class CNCategoria
    {
        public static string Insertar(int pIDCategoria, string pNombre, string pDescripcion, int IDEstado)
        {
            CDCategoria objCategoria = new CDCategoria();
            objCategoria.IDCategoria = pIDCategoria;
            objCategoria.Nombre = pNombre;
            objCategoria.Descripcion = pDescripcion;
            objCategoria.IDEstado = IDEstado;
            return objCategoria.Insertar(objCategoria);
        }
        public static string Actualizar(int pIDCategoria, string pNombre, string pDescripcion, int IDEstado)
        {
            CDCategoria objCategoria = new CDCategoria();
            objCategoria.IDCategoria = pIDCategoria;
            objCategoria.Nombre = pNombre;
            objCategoria.Descripcion = pDescripcion;
            objCategoria.IDEstado = IDEstado;
            return objCategoria.Actualizar(objCategoria);
        }
        /*public static string InsertarActualizar(int accion, int pIDCategoria, string pNombre, string pDescripcion, int IDEstado)
        {
            CDCategoria objCategoria = new CDCategoria();
            objCategoria.IDCategoria = pIDCategoria;
            objCategoria.Nombre = pNombre;
            objCategoria.Descripcion = pDescripcion;
            objCategoria.IDEstado = IDEstado;
            return objCategoria.InsertarActualizar(objCategoria, accion);
        }*/
        //Método utilizado para obtener un DataTable con todos los datos de la tabla correspondiente
        public DataTable ObtenerCategoria(string miparametro)
        {
            CDCategoria objCategoria = new CDCategoria();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = objCategoria.CategoriaProductoConsultar(miparametro); //El DataTable se llena con todos los datos devueltos
            return dt; //Se retorna el DataTable con los datos adquiridos
        }
    }
}