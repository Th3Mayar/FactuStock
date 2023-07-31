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
    class CNCondicionProducto
    {
        public static string Insertar(string pDescripcion, string pSigla)
        {
            CDCondicionProducto objCondicionProducto = new CDCondicionProducto();
            objCondicionProducto.Descripcion = pDescripcion;
            objCondicionProducto.Sigla = pSigla;
            return objCondicionProducto.Insertar(objCondicionProducto);
        } //Fin del método Insertar

        public static string Actualizar(int pIDCondicion, string pDescripcion, string pSigla)
        {
            CDCondicionProducto objCondicionProducto = new CDCondicionProducto();
            objCondicionProducto.IDCondicion = pIDCondicion;
            objCondicionProducto.Descripcion = pDescripcion;
            objCondicionProducto.Sigla = pSigla;
            return objCondicionProducto.Actualizar(objCondicionProducto);
        }

        public DataTable ObtenerCondicionProducto(string miparametro)
        {
            CDCondicionProducto objCondicionProducto = new CDCondicionProducto();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objCondicionProducto.CondicionConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }
    }
}
