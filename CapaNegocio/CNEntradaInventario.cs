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
        public static string Insertar(int pIDEntrada, DateTime pFechaEntrada, int pCantidad, int pIDProducto, int pIDEmpleado, int pIDEstado)
        {
            CDEntradaInventario objEntradaInventario = new CDEntradaInventario();
            objEntradaInventario.IDEntrada = pIDEntrada;
            objEntradaInventario.FechaEntrada = pFechaEntrada;
            objEntradaInventario.Cantidad = pCantidad;
            objEntradaInventario.IDProducto = pIDProducto;
            objEntradaInventario.IDEmpleado = pIDEmpleado;
            objEntradaInventario.IDEstado = pIDEstado;
            return objEntradaInventario.Insertar(objEntradaInventario);
        }
        public static string Actualizar(DateTime pFechaEntrada, int pCantidad, int pIDProducto, int pIDEmpleado, int pIDEstado)
        {
            CDEntradaInventario objEntradaInventarioAct = new CDEntradaInventario();
            objEntradaInventarioAct.FechaEntrada = pFechaEntrada;
            objEntradaInventarioAct.Cantidad = pCantidad;
            objEntradaInventarioAct.IDProducto = pIDProducto;
            objEntradaInventarioAct.IDEmpleado = pIDEmpleado;
            objEntradaInventarioAct.IDEstado = pIDEstado;
            return objEntradaInventarioAct.Actualizar(objEntradaInventarioAct);
        }
        public DataTable ObtenerEntradaInventario(string miparametro)
        {
            CDEntradaInventario objEntradaInventario = new CDEntradaInventario();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objEntradaInventario.EntradaConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos

        }
        //Método utilizado para obtener un DataTable con todos los datos de la tabla
        //correspondiente
    }
}
