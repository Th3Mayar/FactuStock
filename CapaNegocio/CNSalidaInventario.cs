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
    public class CNSalidaInventario
    {
        public static string Insertar(int pIDSalida, DateTime pFechaSalida, int pCantidad, int pIDProducto, string pEstado)
        {
            CDSalidaInventario objSalida = new CDSalidaInventario();
            objSalida.IDSalida = pIDSalida;
            objSalida.FechaSalida = pFechaSalida;
            objSalida.Cantidad = pCantidad;
            objSalida.IDProducto = pIDProducto;
            objSalida.Estado = pEstado;
            return objSalida.Insertar(objSalida);
        }
        public static string Actualizar(int pIDSalida, DateTime pFechaSalida, int pCantidad, int pIDProducto, string pEstado)
        {
            CDSalidaInventario objSalidaAct = new CDSalidaInventario();
            objSalidaAct.IDSalida = pIDSalida;
            objSalidaAct.FechaSalida = pFechaSalida;
            objSalidaAct.Cantidad = pCantidad;
            objSalidaAct.IDProducto = pIDProducto;
            objSalidaAct.Estado = pEstado;
            return objSalidaAct.Actualizar(objSalidaAct);
        }
        public DataTable ObtenerCDSalidaInventario(string miparametro)
        {
            CDSalidaInventario objSalidaAct = new CDSalidaInventario();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objSalidaAct.SalidaConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        
        }
        //Método utilizado para obtener un DataTable con todos los datos de la tabla
        //correspondiente
    }
}
