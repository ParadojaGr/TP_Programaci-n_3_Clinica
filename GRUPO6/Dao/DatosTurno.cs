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
    public class DatosTurno
    {
        AccesoDatos datos = new AccesoDatos();

        public Turnos getTurnos(Turnos tur)
        {
            DataTable tabla = datos.ObtenerTabla("Turnos", "SELECT * FROM Turnos");

            tur.set_IdTurno_TUR(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            tur.set_DniPaciente_TUR(tabla.Rows[0][1].ToString());
            tur.set_LegajoMedico_TUR(Convert.ToInt32(tabla.Rows[0][2].ToString()));
            tur.set_Dia_TUR(tabla.Rows[0][3].ToString());
            tur.set_Hora_TUR(tabla.Rows[0][4].ToString());
            tur.set_Asistencia_TUR(Convert.ToInt32(tabla.Rows[0][5].ToString()));
            tur.set_Observaciones_TUR(tabla.Rows[0][6].ToString());

            return tur;
        }

        //buscar si existe por nombre
        public Boolean existeTurnos(int ID)
        {
            string consulta = "Select * from Turnos WHERE IDTurno_TUR = '" + ID + "' ";
            return datos.Existe(consulta);
        }

        //agregar.
        public int AgregarTurnos(Turnos tur)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAgregarTurnos(ref comando, tur);
            return datos.EjecutarProcedimientoAlmacenado(comando, "spAgregarTurno");
        }

        //actualizar.
        public int ActualizarTurnos(Turnos tur)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosActualizarTurnos(ref comando, tur);
            return datos.EjecutarProcedimientoAlmacenado(comando, "spActualizarTurno");
        }

        private void ArmarParametrosAgregarTurnos(ref SqlCommand comando, Turnos tur)
        {
            SqlParameter sqlParametro = new SqlParameter();

            sqlParametro = comando.Parameters.Add("@DniPaciente_TUR", SqlDbType.VarChar);
            sqlParametro.Value = tur.get_DniPaciente_TUR();
            sqlParametro = comando.Parameters.Add("@LegajoMedico_TUR", SqlDbType.VarChar);
            sqlParametro.Value = tur.Get_LegajoMedico_TUR();
            sqlParametro = comando.Parameters.Add("@Dia_TUR", SqlDbType.VarChar);
            sqlParametro.Value = tur.get_Dia_TUR();
            sqlParametro = comando.Parameters.Add("@Hora_TUR", SqlDbType.VarChar);
            sqlParametro.Value = tur.get_Hora_TUR();

        }

        //armar los parametros para editar el paciente
        private void ArmarParametrosActualizarTurnos(ref SqlCommand comando, Turnos tur)
        {
            SqlParameter sqlParametro = new SqlParameter();
            sqlParametro = comando.Parameters.Add("@IDTurno_TUR", SqlDbType.Int);
            sqlParametro.Value = tur.get_IdTurno_TUR();
            //sqlParametro = comando.Parameters.Add("@DniPaciente_TUR", SqlDbType.VarChar);
            //sqlParametro.Value = tur.get_DniPaciente_TUR();
            //sqlParametro = comando.Parameters.Add("@LegajoMedico_TUR", SqlDbType.VarChar);
            //sqlParametro.Value = tur.Get_LegajoMedico_TUR();
            //sqlParametro = comando.Parameters.Add("@Dia_TUR", SqlDbType.Int);
            //sqlParametro.Value = tur.get_Dia_TUR();
            //sqlParametro = comando.Parameters.Add("@Hora_TUR", SqlDbType.Int);
            //sqlParametro.Value = tur.get_Hora_TUR();
            sqlParametro = comando.Parameters.Add("@Asistencia_TUR", SqlDbType.Bit);
            sqlParametro.Value = tur.get_Asistencia_TUR();
            sqlParametro = comando.Parameters.Add("@Observaciones_TUR", SqlDbType.Text);
            sqlParametro.Value = tur.get_Observaciones_TUR();

        }

        //Busca la tabla con inner join para el gridview
        public DataTable getTabla()
        {
            DataTable tabla = datos.ObtenerTabla("Turnos", "SELECT * FROM Turnos");
            return tabla;
        }

        public DataTable getTablaIndividual(string nombre_usuario)
        {
            DataTable tabla = datos.ObtenerTabla("Turnos", "SELECT T.IDTurno_TUR, T.DNIPaciente_TUR, T.LegajoMedico_TUR, T.Dia_TUR, T.Hora_TUR, T.Observaciones_TUR, T.Asistencia_TUR FROM Usuarios AS U INNER JOIN Turnos AS T ON U.Legajo_USU = T.LegajoMedico_TUR WHERE U.Nombre_USU = '"+ nombre_usuario +"' ");
            return tabla;
        }

        public DataTable getRegistroTurnoIndividual(string nombre_usuario,int id)
        {
            DataTable tabla = datos.ObtenerTabla("Turnos", "SELECT T.IDTurno_TUR, T.DNIPaciente_TUR, T.LegajoMedico_TUR, T.Dia_TUR, T.Hora_TUR, T.Observaciones_TUR, T.Asistencia_TUR FROM Usuarios AS U INNER JOIN Turnos AS T ON U.Legajo_USU = T.LegajoMedico_TUR WHERE U.Nombre_USU = '" + nombre_usuario + "' AND T.IDTurno_TUR = '"+ id +"' ");
            return tabla;
        }

        public DataTable getRegistroTurno(int id)
        {
            DataTable tabla = datos.ObtenerTabla("Turnos", "SELECT * FROM Turnos WHERE IDTurno_TUR = '"+ id + "' ");
            return tabla;
        }

        //list string:
        public List<string> getHorarioEntradaSalida(int legajo)
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT HorarioEntrada_MED, HorarioSalida_MED FROM Medicos WHERE Legajo_MED = '" + legajo + "' ");
            List<string> horasEntradaSalida = new List<string>
            {
                tabla.Rows[0][0].ToString(),
                tabla.Rows[0][1].ToString()
            };
            return horasEntradaSalida;
        }


        public List<string> getTurnosPorLegajoYDia(int legajo, string dia)
        {
            DataTable tabla = datos.ObtenerTabla("Turnos", "SELECT Hora_TUR FROM dbo.Turnos AS T INNER JOIN Medicos AS M ON M.Legajo_MED =  T.LegajoMedico_TUR WHERE T.LegajoMedico_TUR = '" + legajo + "' " + "AND T.Dia_TUR ='" + dia + "' ");
            List<string> horasTurnos = new List<string>();
            if (tabla.Rows.Count > 0) 
            {
                int i = 0;

                foreach (var item in tabla.Rows)
                {
                    horasTurnos.Add(tabla.Rows[i][0].ToString());
                    i++;
                }
            }

            return horasTurnos;
        }
    }

}
