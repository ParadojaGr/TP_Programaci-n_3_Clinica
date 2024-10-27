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
    public class NegocioProvincia
    {
        DatosProvincia datos = new DatosProvincia();
        public DataTable CargarDdlProvincias()
        {
            DataTable tabla = datos.CargarDDl();
            return tabla;
        }
    }
}
