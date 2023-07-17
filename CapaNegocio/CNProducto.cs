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
    public class CNProducto
    {
        public static string Insertar(int pCodigoProducto, string pNombre, string pDescripcion, int pCantidad, float pPrecioUnitario, int pIDEstado, int pIDCategoria)
        {
            CDProducto objProducto = new CDProducto();
            objProducto.CodigoProducto = pCodigoProducto;
            objProducto.Nombre = pNombre;
            objProducto.Descripcion = pDescripcion;
            objProducto.Cantidad = pCantidad;
            objProducto.PrecioUnitario = pPrecioUnitario;
            objProducto.IDEstado = pIDEstado;
            objProducto.IDCategoria = pIDCategoria;
            return objProducto.Insertar(objProducto);
        }
        public static string Actualizar(int pCodigoProducto, string pNombre, string pDescripcion, int pCantidad, float pPrecioUnitario, int pIDEstado, int pIDCategoria)
        {
            CDProducto objProducto = new CDProducto();
            objProducto.CodigoProducto = pCodigoProducto;
            objProducto.Nombre = pNombre;
            objProducto.Descripcion = pDescripcion;
            objProducto.Cantidad = pCantidad;
            objProducto.PrecioUnitario = pPrecioUnitario;
            objProducto.IDEstado = pIDEstado;
            objProducto.IDCategoria = pIDCategoria;
            return objProducto.Actualizar(objProducto);
        }

        //Método utilizado para obtener un DataTable con todos los datos de la tabla correspondiente
        public DataTable ObtenerProducto(string miparametro)
        {
            CDProducto objProducto = new CDProducto();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = objProducto.ProductoConsultar(miparametro); //El DataTable se llena con todos los datos devueltos
            return dt; //Se retorna el DataTable con los datos adquiridos
        }
    }
}