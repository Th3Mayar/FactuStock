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
    public class CNUsuario
    {
        private static object accion;

        //Preparamos los datos para insertar un nuevo Suplidor. A los parametros recibidos les pongo el prefijo p
        public static string Insertar(string pUsuario, string pPass, string pToken, int pIDRol)
        {
            CDValidarUsuario objUsuario = new CDValidarUsuario();
            objUsuario.Usuario = pUsuario;
            objUsuario.Pass = pPass;
            objUsuario.Token = pToken;
            objUsuario.IDRol = pIDRol;


            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objUsuario.Insertar(objUsuario);
        } //Fin del método Insertar

        public static string Actualizar(int pIDUsuario, string pUsuario, string pPass, string pToken, int pIDRol)
        {
            CDValidarUsuario objUsuario = new CDValidarUsuario();
            objUsuario.IDUsuario = pIDUsuario;
            objUsuario.Usuario = pUsuario;
            objUsuario.Pass = pPass;
            objUsuario.Token = pToken;
            objUsuario.IDRol = pIDRol;

            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objUsuario.Actualizar(objUsuario);
        } //Fin del método Actualizar


        //Método utilizado para obtener un DataTable con todos los datos de la tabla
        //correspondiente
        public DataTable ObtenerUsuario(string miparametro)
        {
            CDValidarUsuario objUsuario = new CDValidarUsuario();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objUsuario.UsuarioConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }

        public DataTable ValidateUsuario(string usuario, string pass)
        {
            CDValidarUsuario objUsuario = new CDValidarUsuario();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objUsuario.ValidarUsuario(usuario, pass);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }

    }
}
