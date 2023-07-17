using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
//Agregamos la capa de datos para poder comunicarnos con ella
using CapaDatos;

namespace CapaNegocio
{
    public class CNVentaDetalle
    {
        //Preparamos los datos para insertar un nuevo Suplidor. A los parametros recibidos les pongo el prefijo p
        public static string Insertar(int pIDVentaDetalle, int pNumFactura, int pIDProducto, int pCantidad, decimal pPrecioventa)
        {
            CDVentaDetalle objVentaDetalle = new CDVentaDetalle();
            objVentaDetalle.IDVentaDetalle = pIDVentaDetalle;
            objVentaDetalle.NumFactura = pNumFactura;
            objVentaDetalle.IDProducto = pIDProducto;
            objVentaDetalle.Cantidad = pCantidad;
            objVentaDetalle.Precioventa = pPrecioventa;
            return objVentaDetalle.Insertar(objVentaDetalle);
        } //Fin del método Insertar

        public static string Actualizar(int pIDVentaDetalle, int pNumFactura, int pIDProducto, int pCantidad, decimal pPrecioventa)
        {
            CDVentaDetalle objVentaDetalle = new CDVentaDetalle();
            objVentaDetalle.IDVentaDetalle = pIDVentaDetalle;
            objVentaDetalle.NumFactura = pNumFactura;
            objVentaDetalle.IDProducto = pIDProducto;
            objVentaDetalle.Cantidad = pCantidad;
            objVentaDetalle.Precioventa = pPrecioventa;

            return objVentaDetalle.Actualizar(objVentaDetalle);
        }

        /*public static string InsertarActualizar(int accion, int pIDEstado, string pEstado, string pSigla)
        {
            CDEstado objEstado = new CDEstado();
            objEstado.IDEstado = pIDEstado;
            objEstado.IDEstado = pIDEstado;
            objEstado.Estado = pEstado;
            objEstado.Sigla = pSigla;
            return objEstado.InsertarActualizar(objEstado, accion);
        }*/

        public DataTable ObtenerVentaDetalle(string miparametro)
        {
            CDVentaDetalle objVentaDetalle = new CDVentaDetalle();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objVentaDetalle.VentaDetalleConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }
    }
}
