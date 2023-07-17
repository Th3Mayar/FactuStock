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
    public class CNEntradaInventario
    {
        public static string Insertar(int pIDEntrada, DateTime pFechaEntrada, int pCantidad, int pIDProducto, int pIDEmpleado, string pEstado)
        {
            CDEntradaInventario objEntradaInventarioInsertar = new CDEntradaInventario();
            objEntradaInventarioInsertar.IDEntrada = pIDEntrada;
            objEntradaInventarioInsertar.FechaEntrada = pFechaEntrada;
            objEntradaInventarioInsertar.Cantidad = pCantidad;
            objEntradaInventarioInsertar.IDProducto = pIDProducto;
            objEntradaInventarioInsertar.IDEmpleado = pIDEmpleado;
            objEntradaInventarioInsertar.Estado = pEstado;
            return objEntradaInventarioInsertar.Insertar(objEntradaInventarioInsertar);
        }
        public static string Actualizar(DateTime pFechaEntrada, int pCantidad, int pIDProducto, int pIDEmpleado, string pEstado)
        {
            CDEntradaInventario objEntradaInventarioActualizar = new CDEntradaInventario();
            objEntradaInventarioActualizar.FechaEntrada = pFechaEntrada;
            objEntradaInventarioActualizar.Cantidad = pCantidad;
            objEntradaInventarioActualizar.IDProducto = pIDProducto;
            objEntradaInventarioActualizar.IDEmpleado = pIDEmpleado;
            objEntradaInventarioActualizar.Estado = pEstado;
            return objEntradaInventarioActualizar.Actualizar(objEntradaInventarioActualizar);
        }
        public DataTable ObtenerCDEntradaInventario(string miparametro)
        {
            CDEntradaInventario objEntradaInventarioActualizar = new CDEntradaInventario();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objEntradaInventarioActualizar.EntradaConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos

        }
        //Método utilizado para obtener un DataTable con todos los datos de la tabla
        //correspondiente
    }
}
