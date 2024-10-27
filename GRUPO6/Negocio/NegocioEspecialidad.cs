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
   public class NegocioEspecialidad
    {
        DatosEspecialidad datos = new DatosEspecialidad();
        public DataTable CargarDdlEspecialidad()
        {
            DataTable tabla = datos.CargarDDl();
            return tabla;
        }
    }
}
