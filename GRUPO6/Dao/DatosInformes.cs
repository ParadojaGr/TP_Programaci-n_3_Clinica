using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Dao
{
    public class DatosInformes
    {
        AccesoDatos Dat = new AccesoDatos();
        public DatosInformes() { }
        public DataTable GetTablaInforme_MédicosConMásTurnos()
        {
            string Consulta = "SELECT M.Legajo_MED AS Legajo, Nombre_Completo = (M.Nombre_MED + ' ' + M.Apellido_MED), Cantidad_Turnos = COUNT(T.IDturno_TUR) FROM Medicos AS M INNER JOIN Turnos AS T ON M.Legajo_MED = T.LegajoMedico_TUR GROUP BY M.Legajo_MED, M.Nombre_MED, M.Apellido_MED ORDER BY Cantidad_Turnos DESC";
            return Dat.ObtenerTabla("Medicos", Consulta);
        }
        public DataTable GetTablaInforme_EspecilidadesConMásTurnos()
        {
            string Consulta = "SELECT E.Nombre_ES AS [Nombre Especialidad], COUNT (T.IDturno_TUR) AS Cantidad_Turnos FROM Especialidades AS E INNER JOIN Medicos M ON E.IDEspecialidad_ES = M.Especialidad_MED INNER JOIN Turnos T ON M.Legajo_MED = T.LegajoMedico_TUR GROUP BY E.Nombre_ES ORDER BY Cantidad_Turnos DESC";
            return Dat.ObtenerTabla("Medicos", Consulta);
        }
        /*public DataTable GetTablaInforme_MédicosConMásTurnos_SP()
        {
            var Com = new SqlCommand();
            return Dat.EjecutarProcedimientoAlmacenado(Com ,"MedicosConMasTurnos","Informe1");
        }
        public DataTable GetTablaInforme_EspecialidadesConMásTurnos_SP()
        {
            var Com = new SqlCommand();
            return Dat.EjecutarProcedimientoAlmacenado(Com, "EspecialidadesConMasTurnos", "Informe2");
        }*/
    }
}
