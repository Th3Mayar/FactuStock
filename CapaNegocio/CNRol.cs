using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using CapaDatos;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNRol
    {
        ///private object objRol;

        //Preparamos los datos para insertar un nuevo Suplidor. A los parametros recibidos les pongo el prefijo p
        public static string Insertar(int pIDRol, string pRol, string pSiglas)
        {
            CDRol objRol = new CDRol();
            objRol.IDRol = pIDRol;
            objRol.Rol = pRol;
            objRol.Siglas = pSiglas;
            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objRol.Insertar(objRol);
        } //Fin del método Insertar



        public static string Actualizar(int pIDRol, string pRol, string pSiglas)
        {
            CDRol objRol = new CDRol();
            objRol.IDRol = pIDRol;
            objRol.Rol = pRol;
            objRol.Siglas = pSiglas;
            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objRol.Actualizar(objRol);
        } //Fin del método Actualizar



        //Método utilizado para obtener un DataTable con todos los datos de la tabla
        //correspondiente
        public DataTable ObtenerRol(string miparametro)
        {
            CDRol objRol = new CDRol();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objRol.RolConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }



    }


}

