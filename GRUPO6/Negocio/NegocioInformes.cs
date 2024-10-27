using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using System.Data;
namespace Negocio
{
    public class NegocioInformes
    {
        private DatosInformes dat = new DatosInformes();
        public NegocioInformes()
        { }

        public DataTable getTablaMEDxTUR()
        {
            return dat.GetTablaInforme_MédicosConMásTurnos();
        }

        public DataTable getTablaESPxTUR()
        {
            return dat.GetTablaInforme_EspecilidadesConMásTurnos();
        }

    }
}
