using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Dao
{
   public class DatosProvincia
    {
        AccesoDatos datos = new AccesoDatos();

        public DataTable CargarDDl()
        {
            string consulta = "SELECT IDProvincia_PRO, Nombre_PRO FROM Provincias";
            DataTable tabla = datos.ObtenerTabla("Provincias", consulta);
            return tabla;
        }
    }
}
