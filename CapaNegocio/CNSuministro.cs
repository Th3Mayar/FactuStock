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
    public class CNSuministro
    {
        public DataTable ObtenerSuministro(string miparametro)
        {
            CDSuministro objSuministro = new CDSuministro();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objSuministro.SuministroConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }
    }
}
