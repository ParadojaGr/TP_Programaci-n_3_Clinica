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
   public class DatosLocalidad
    {
        AccesoDatos datos = new AccesoDatos();

        public DataTable CargarDDl()
        {
            string consulta = "SELECT IDLocalidad_LOC, Nombre_LOC FROM Localidades";
            DataTable tabla = datos.ObtenerTabla("Localidades", consulta);
            return tabla;
        }

        public DataTable getLocalidadDDL(string id)
        {
            DataTable tabla = datos.ObtenerTabla("Localidades", "SELECT L.IDLocalidad_LOC, L.Nombre_LOC FROM Localidades AS L INNER JOIN Provincias AS P ON L.IDProvincia_LOC = P.IDProvincia_PRO WHERE IDProvincia_LOC = '" + id + "' ");
            return tabla;
        }
    }
}
