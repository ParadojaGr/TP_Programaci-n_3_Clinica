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
    public class DatosEspecialidad
    {
        AccesoDatos datos = new AccesoDatos();

        //obtener una especialidad
        public Especialidad getEspecialidad(Especialidad ES)
        {
            DataTable tabla = datos.ObtenerTabla("Especialidades", "SELECT * FROM Especialidades");

            ES.set_IDEspecialidad_ES(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            ES.set_Nombre_ES(tabla.Rows[0][1].ToString());

            return ES;
        }

        //funcion para cargar el ddl:
        public DataTable CargarDDl()
        {
            string consulta = "SELECT IDEspecialidad_ES, Nombre_ES FROM Especialidades";
            DataTable tabla = datos.ObtenerTabla("Especialidades", consulta);
            return tabla;
        }

        public bool ExisteEspecialidad(int IDEspecialidad)
        {
            string consulta = "Select * from Especialidades WHERE IDEspecialidad_ES =" + IDEspecialidad;
            return datos.Existe(consulta);
        }
            
    }
}
