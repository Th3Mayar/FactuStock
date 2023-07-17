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
    public class CNEstado
    {
        //Preparamos los datos para insertar un nuevo Estado. A los parametros recibidos les pongo el prefijo p
        public static string Insertar(string pEstado, string pSigla)
        {
            CDEstado objEstado = new CDEstado();
            objEstado.Estado = pEstado;
            objEstado.Sigla = pSigla;
            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objEstado.Insertar(objEstado);
        } //Fin del método Insertar

        public static string Actualizar(int pIDEstado, string pEstado, string pSigla)
        {
            CDEstado objEstado = new CDEstado();
            objEstado.IDEstado = pIDEstado;
            objEstado.IDEstado = pIDEstado;
            objEstado.Estado = pEstado;
            objEstado.Sigla = pSigla;
            //Llamamos al método insertar del Estado pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objEstado.Actualizar(objEstado);
        } //Fin del método Actualizar
          //Método utilizado para obtener un DataTable con todos los datos de la tabla
          //correspondiente

        /*public static string InsertarActualizar(int accion, int pIDEstado, string pEstado, string pSigla)
        {
            CDEstado objEstado = new CDEstado();
            objEstado.IDEstado = pIDEstado;
            objEstado.IDEstado = pIDEstado;
            objEstado.Estado = pEstado;
            objEstado.Sigla = pSigla;
            return objEstado.InsertarActualizar(objEstado, accion);
        }*/

        public DataTable ObtenerEstado(string miparametro)
        {
            CDEstado objEstado = new CDEstado();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objEstado.EstadoConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }
    }
}
