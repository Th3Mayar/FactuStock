using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
//Agregamos la capa de datos para poder comunicarnos con ella
using CapaDatos;

namespace CapaNegocio
{
    public class CNVentaCabecera
    {
        //Preparamos los datos para insertar un nuevo Suplidor. A los parametros recibidos les pongo el prefijo p
        public static string Insertar(int pNumFactura, int pIDCliente, int pIDEmpleado, DateTime pFecha, int pCondicion, string pTipoFactura, string pObservaciones, int pEstado)
        {
            CDVentaCabecera objVentaCabecera = new CDVentaCabecera();
            objVentaCabecera.NumFactura = pNumFactura;
            objVentaCabecera.IDCliente = pIDCliente;
            objVentaCabecera.IDEmpleado = pIDEmpleado;
            objVentaCabecera.Fecha = pFecha;
            objVentaCabecera.TipoFactura = pTipoFactura;
            objVentaCabecera.IDEmpleado = pIDEmpleado;
            objVentaCabecera.IDEmpleado = pIDEmpleado;
            objVentaCabecera.IDEmpleado = pIDEmpleado;
            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objVentaCabecera.Insertar(objVentaCabecera);
        }

        public static string Actualizar(int pNumFactura, int pIDCliente, int pIDEmpleado, DateTime pFecha, int pCondicion, string pTipoFactura, string pObservaciones, int pEstado)
        {
            CDVentaCabecera objVentaCabecera = new CDVentaCabecera();
            objVentaCabecera.NumFactura = pNumFactura;
            objVentaCabecera.IDCliente = pIDCliente;
            objVentaCabecera.IDEmpleado = pIDEmpleado;
            objVentaCabecera.Fecha = pFecha;
            objVentaCabecera.TipoFactura = pTipoFactura;
            objVentaCabecera.IDEmpleado = pIDEmpleado;
            objVentaCabecera.IDEmpleado = pIDEmpleado;
            objVentaCabecera.IDEmpleado = pIDEmpleado;
            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objVentaCabecera.Actualizar(objVentaCabecera);
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

        public DataTable ObtenerVentaCabecera(string miparametro)
        {
            CDVentaCabecera objEstado = new CDVentaCabecera();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objEstado.VentaCabeceraConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }
    }
}
