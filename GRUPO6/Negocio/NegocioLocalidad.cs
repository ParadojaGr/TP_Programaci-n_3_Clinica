using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Dao;

namespace Negocio
{
    public class NegocioLocalidad
    {
        public DataTable CargarDdlLocalidad()
        {
            DatosLocalidad datos = new DatosLocalidad();
            DataTable tabla = datos.CargarDDl();
            return tabla;
        }

        public DataTable getLocalidadParaDDL(string id)
        {
            DatosLocalidad datos = new DatosLocalidad();
            return datos.getLocalidadDDL(id);
        }
    }
}
