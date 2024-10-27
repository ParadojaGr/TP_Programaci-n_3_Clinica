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
    public class DatosMedico
    {
        AccesoDatos datos = new AccesoDatos();

        public Medico getMedico(Medico med)
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT * FROM Medicos");

            med.set_Legajo(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            med.set_Nombre(tabla.Rows[0][1].ToString());
            med.set_DNI(tabla.Rows[0][2].ToString());
            med.set_Apellido(tabla.Rows[0][3].ToString());
            med.set_Sexo(tabla.Rows[0][4].ToString());
            med.set_Nacionalidad(tabla.Rows[0][5].ToString());
            med.set_FechaNacimiento(tabla.Rows[0][6].ToString());
            med.set_Direccion(tabla.Rows[0][7].ToString());
            med.set_Especialidad(tabla.Rows[0][8].ToString());
            med.set_Lunes(Convert.ToBoolean(tabla.Rows[0][9].ToString()));
            med.set_Martes(Convert.ToBoolean(tabla.Rows[0][10].ToString()));
            med.set_Miercoles(Convert.ToBoolean(tabla.Rows[0][11].ToString()));
            med.set_Jueves(Convert.ToBoolean(tabla.Rows[0][12].ToString()));
            med.set_Viernes(Convert.ToBoolean(tabla.Rows[0][13].ToString()));
            med.set_Sabado(Convert.ToBoolean(tabla.Rows[0][14].ToString()));
            med.set_Domingo(Convert.ToBoolean(tabla.Rows[0][15].ToString()));
            med.set_HorarioEntrada(tabla.Rows[0][16].ToString());
            med.set_HorarioSalida(tabla.Rows[0][17].ToString());
            med.set_Provincia(Convert.ToInt32(tabla.Rows[0][18].ToString()));
            med.set_Localidad(Convert.ToInt32(tabla.Rows[0][19].ToString()));
            med.set_Email(tabla.Rows[0][20].ToString());
            med.set_Telefono(tabla.Rows[0][21].ToString());
            return med;
        }

        //GET DIAS DE MEDICOS:
        public Semana getDiasMedico(string legajo)
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT Dia_MED_1, Dia_MED_2, Dia_MED_3, Dia_MED_4, Dia_MED_5, Dia_MED_6, Dia_MED_7 FROM Medicos WHERE Estado_MED = 1 AND Legajo_MED = '"+ legajo +"' ");
            Semana semana = new Semana();

            semana.Lunes = SettearDias(Convert.ToBoolean((tabla.Rows[0][0])));
            semana.Martes = SettearDias(Convert.ToBoolean((tabla.Rows[0][1])));
            semana.Miercoles = SettearDias(Convert.ToBoolean((tabla.Rows[0][2])));
            semana.Jueves = SettearDias(Convert.ToBoolean((tabla.Rows[0][3])));
            semana.Viernes = SettearDias(Convert.ToBoolean((tabla.Rows[0][4])));
            semana.Sabado = SettearDias(Convert.ToBoolean((tabla.Rows[0][5])));
            semana.Domingo = SettearDias(Convert.ToBoolean((tabla.Rows[0][6])));
            return semana;
        }

        public int SettearDias(Boolean booleano)
        {
            var boolint = 0;
            if (booleano)
            {
                boolint = 1;
            }
            return boolint;
        }

        //buscar si existe por nombre
        public Boolean existeMedico(int legajo)
        {
            string consulta = "Select * from Medicos where Estado_MED = 1 AND Legajo_MED =" + legajo;
            return datos.Existe(consulta);
        }

        //eliminar.
        public int EliminarMedico(Medico medico)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosEliminarMedico(ref comando, medico);
            return datos.EjecutarProcedimientoAlmacenado(comando, "spEliminarMedico");
        }

        //agregar.
        public int AgregarMedico(Medico medico)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAgregarMedico(ref comando, medico);
            return datos.EjecutarProcedimientoAlmacenado(comando, "spAgregarMedico");
        }

        //modificar.
        public int ActualizarMedico(Medico medico)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosActualizarMedico(ref comando, medico);
            return datos.EjecutarProcedimientoAlmacenado(comando, "spActualizarMedico");
        }

        //arma los parametros para eliminar Medico.
        private void ArmarParametrosEliminarMedico(ref SqlCommand comando, Medico medico)
        {
            SqlParameter sqlParametro = new SqlParameter();
            sqlParametro = comando.Parameters.Add("@LEGAJO", SqlDbType.Int);
            sqlParametro.Value = medico.get_Legajo();
        }

        //arma los parametros para agregar Medico.
        private void ArmarParametrosAgregarMedico(ref SqlCommand comando, Medico medico)
        {
            SqlParameter sqlParametro = new SqlParameter();
            sqlParametro = comando.Parameters.Add("@Legajo_MED", SqlDbType.Int);
            sqlParametro.Value = medico.get_Legajo();
            sqlParametro = comando.Parameters.Add("@Nombre_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Nombre();
            sqlParametro = comando.Parameters.Add("@DNI_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_DNI();
            sqlParametro = comando.Parameters.Add("@Apellido_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Apellido();
            sqlParametro = comando.Parameters.Add("@Sexo_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Sexo();
            sqlParametro = comando.Parameters.Add("@Nacionalidad_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Nacionalidad();
            sqlParametro = comando.Parameters.Add("@FechaNacimiento_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_FechaNacimiento();
            sqlParametro = comando.Parameters.Add("@Direccion_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Direccion();
            sqlParametro = comando.Parameters.Add("@Especialidad_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Especialidad();
            sqlParametro = comando.Parameters.Add("@Dia_MED_1", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Lunes();
            sqlParametro = comando.Parameters.Add("@Dia_MED_2", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Martes();
            sqlParametro = comando.Parameters.Add("@Dia_MED_3", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Miercoles();
            sqlParametro = comando.Parameters.Add("@Dia_MED_4", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Jueves();
            sqlParametro = comando.Parameters.Add("@Dia_MED_5", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Viernes();
            sqlParametro = comando.Parameters.Add("@Dia_MED_6", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Sabado();
            sqlParametro = comando.Parameters.Add("@Dia_MED_7", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Domingo();
            sqlParametro = comando.Parameters.Add("@HorarioEntrada_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_HorarioEntrada();
            sqlParametro = comando.Parameters.Add("@HorarioSalida_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_HorarioSalida();
            sqlParametro = comando.Parameters.Add("@Provincia_MED", SqlDbType.Int);
            sqlParametro.Value = medico.get_Provincia();
            sqlParametro = comando.Parameters.Add("@Localidad_MED", SqlDbType.Int);
            sqlParametro.Value = medico.get_Localidad();
            sqlParametro = comando.Parameters.Add("@Email_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Email();
            sqlParametro = comando.Parameters.Add("@Telefono_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Telefono();
            sqlParametro = comando.Parameters.Add("@Estado_MED", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Estado();
        }

        //arma parametros para actualizar el medico:
        private void ArmarParametrosActualizarMedico(ref SqlCommand comando, Medico medico)
        {
            SqlParameter sqlParametro = new SqlParameter();
            sqlParametro = comando.Parameters.Add("@Legajo_MED", SqlDbType.Int);
            sqlParametro.Value = medico.get_Legajo();
            sqlParametro = comando.Parameters.Add("@Nombre_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Nombre();
            sqlParametro = comando.Parameters.Add("@DNI_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_DNI();
            sqlParametro = comando.Parameters.Add("@Apellido_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Apellido();
            sqlParametro = comando.Parameters.Add("@Sexo_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Sexo();
            sqlParametro = comando.Parameters.Add("@Nacionalidad_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Nacionalidad();
            sqlParametro = comando.Parameters.Add("@FechaNacimiento_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_FechaNacimiento();
            sqlParametro = comando.Parameters.Add("@Direccion_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Direccion();
            sqlParametro = comando.Parameters.Add("@Especialidad_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Especialidad();
            sqlParametro = comando.Parameters.Add("@Dia_MED_1", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Lunes();
            sqlParametro = comando.Parameters.Add("@Dia_MED_2", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Martes();
            sqlParametro = comando.Parameters.Add("@Dia_MED_3", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Miercoles();
            sqlParametro = comando.Parameters.Add("@Dia_MED_4", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Jueves();
            sqlParametro = comando.Parameters.Add("@Dia_MED_5", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Viernes();
            sqlParametro = comando.Parameters.Add("@Dia_MED_6", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Sabado();
            sqlParametro = comando.Parameters.Add("@Dia_MED_7", SqlDbType.Bit);
            sqlParametro.Value = medico.get_Domingo();
            sqlParametro = comando.Parameters.Add("@HorarioEntrada_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_HorarioEntrada();
            sqlParametro = comando.Parameters.Add("@HorarioSalida_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_HorarioSalida();
            sqlParametro = comando.Parameters.Add("@Provincia_MED", SqlDbType.Int);
            sqlParametro.Value = medico.get_Provincia();
            sqlParametro = comando.Parameters.Add("@Localidad_MED", SqlDbType.Int);
            sqlParametro.Value = medico.get_Localidad();
            sqlParametro = comando.Parameters.Add("@Email_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Email();
            sqlParametro = comando.Parameters.Add("@Telefono_MED", SqlDbType.VarChar);
            sqlParametro.Value = medico.get_Telefono();
        }

        //Busca la tabla con inner join para el gridview
        public DataTable getTabla()
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT M.Legajo_MED AS LEGAJO,  M.Nombre_MED AS NOMBRE, M.Apellido_MED AS APELLIDO, M.DNI_MED AS DNI, M.Sexo_MED AS SEXO, M.Nacionalidad_MED AS NACIONALIDAD, M.FechaNacimiento_MED AS[FECHA NACIMIENTO], M.Direccion_MED AS DIRECCION, E.Nombre_ES AS ESPECIALIDAD, P.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, M.Dia_MED_1 AS LUNES, M.Dia_MED_2 AS MARTES, M.Dia_MED_3 AS MIERCOLES, M.Dia_MED_4 AS JUEVES, M.Dia_MED_5 AS VIERNES, M.Dia_MED_6 AS SABADO, M.Dia_MED_7 AS DOMINGO, M.HorarioEntrada_MED AS[HORARIO DE ENTRADA], M.HorarioSalida_MED AS[HORARIO DE SALIDA], M.Email_MED AS EMAIL, M.Telefono_MED AS TELEFONO FROM Medicos AS M INNER JOIN Localidades AS L ON M.Localidad_MED = L.IDLocalidad_LOC INNER JOIN Provincias AS P ON P.IDProvincia_PRO = L.IDProvincia_LOC INNER JOIN Especialidades AS E ON M.Especialidad_MED = E.IDEspecialidad_ES WHERE M.Estado_MED = 1");
            return tabla;
        }

        public DataTable getTablaMedicosNormal()
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT * FROM Medicos WHERE Estado_MED = 1");
            return tabla;
        }

        //busca la tabla con el inner join pero solo el Medico a buscar
        public DataTable getTablaJoinMedicos(int Legajo)
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT M.Legajo_MED AS LEGAJO,  M.Nombre_MED AS NOMBRE, M.Apellido_MED AS APELLIDO, M.DNI_MED AS DNI, M.Sexo_MED AS SEXO, M.Nacionalidad_MED AS NACIONALIDAD, M.FechaNacimiento_MED AS[FECHA NACIMIENTO], M.Direccion_MED AS DIRECCION, E.Nombre_ES AS ESPECIALIDAD, P.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, M.Dia_MED_1 AS LUNES, M.Dia_MED_2 AS MARTES, M.Dia_MED_3 AS MIERCOLES, M.Dia_MED_4 AS JUEVES, M.Dia_MED_5 AS VIERNES, M.Dia_MED_6 AS SABADO, M.Dia_MED_7 AS DOMINGO, M.HorarioEntrada_MED AS[HORARIO DE ENTRADA], M.HorarioSalida_MED AS[HORARIO DE SALIDA], M.Email_MED AS EMAIL, M.Telefono_MED AS TELEFONO FROM Medicos AS M INNER JOIN Localidades AS L ON M.Localidad_MED = L.IDLocalidad_LOC INNER JOIN Provincias AS P ON P.IDProvincia_PRO = L.IDProvincia_LOC INNER JOIN Especialidades AS E ON M.Especialidad_MED = E.IDEspecialidad_ES WHERE M.Estado_MED = 1 AND M.Legajo_MED LIKE '%" + Legajo +"%' ");
            return tabla;
        }

        public DataTable getMedicosDDL(string Esp)
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT (Nombre_MED + ' ' + Apellido_MED) AS Nombre_Completo, Legajo_MED FROM Medicos AS M INNER JOIN Especialidades AS E ON M.Especialidad_MED = E.IDEspecialidad_ES WHERE M.Estado_MED = 1 AND M.Especialidad_MED = '" + Esp + "' ");
            return tabla;
        }

        //FILTROSSSSSS:
        //filtro 1:
        public DataTable Filtro_Nombre()
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT  M.Legajo_MED AS LEGAJO, M.Nombre_MED AS NOMBRE, M.Apellido_MED AS APELLIDO, M.DNI_MED AS DNI, M.Sexo_MED AS SEXO, M.Nacionalidad_MED AS NACIONALIDAD, M.FechaNacimiento_MED AS[FECHA NACIMIENTO], M.Direccion_MED AS DIRECCION, E.Nombre_ES AS ESPECIALIDAD, P.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, M.Dia_MED_1 AS LUNES, M.Dia_MED_2 AS MARTES, M.Dia_MED_3 AS MIERCOLES, M.Dia_MED_4 AS JUEVES, M.Dia_MED_5 AS VIERNES, M.Dia_MED_6 AS SABADO, M.Dia_MED_7 AS DOMINGO, M.HorarioEntrada_MED AS[HORARIO DE ENTRADA], M.HorarioSalida_MED AS[HORARIO DE SALIDA], M.Email_MED AS EMAIL, M.Telefono_MED AS TELEFONO FROM Medicos AS M INNER JOIN Localidades AS L ON M.Localidad_MED = L.IDLocalidad_LOC INNER JOIN Provincias AS P ON P.IDProvincia_PRO = L.IDProvincia_LOC INNER JOIN Especialidades AS E ON M.Especialidad_MED = E.IDEspecialidad_ES WHERE M.Estado_MED = 1 ORDER BY M.Nombre_MED");
            return tabla;
        }
        //filtro 2: 
        public DataTable Filtro_Apellido()
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT  M.Legajo_MED AS LEGAJO, M.Nombre_MED AS NOMBRE, M.Apellido_MED AS APELLIDO, M.DNI_MED AS DNI, M.Sexo_MED AS SEXO, M.Nacionalidad_MED AS NACIONALIDAD, M.FechaNacimiento_MED AS[FECHA NACIMIENTO], M.Direccion_MED AS DIRECCION, E.Nombre_ES AS ESPECIALIDAD, P.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, M.Dia_MED_1 AS LUNES, M.Dia_MED_2 AS MARTES, M.Dia_MED_3 AS MIERCOLES, M.Dia_MED_4 AS JUEVES, M.Dia_MED_5 AS VIERNES, M.Dia_MED_6 AS SABADO, M.Dia_MED_7 AS DOMINGO, M.HorarioEntrada_MED AS[HORARIO DE ENTRADA], M.HorarioSalida_MED AS[HORARIO DE SALIDA], M.Email_MED AS EMAIL, M.Telefono_MED AS TELEFONO FROM Medicos AS M INNER JOIN Localidades AS L ON M.Localidad_MED = L.IDLocalidad_LOC INNER JOIN Provincias AS P ON P.IDProvincia_PRO = L.IDProvincia_LOC INNER JOIN Especialidades AS E ON M.Especialidad_MED = E.IDEspecialidad_ES WHERE M.Estado_MED = 1 ORDER BY M.Apellido_MED");
            return tabla;
        }
        //filtro 3: 
        public DataTable Filtro_Sexo()
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT  M.Legajo_MED AS LEGAJO, M.Nombre_MED AS NOMBRE, M.Apellido_MED AS APELLIDO, M.DNI_MED AS DNI, M.Sexo_MED AS SEXO, M.Nacionalidad_MED AS NACIONALIDAD, M.FechaNacimiento_MED AS[FECHA NACIMIENTO], M.Direccion_MED AS DIRECCION, E.Nombre_ES AS ESPECIALIDAD, P.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, M.Dia_MED_1 AS LUNES, M.Dia_MED_2 AS MARTES, M.Dia_MED_3 AS MIERCOLES, M.Dia_MED_4 AS JUEVES, M.Dia_MED_5 AS VIERNES, M.Dia_MED_6 AS SABADO, M.Dia_MED_7 AS DOMINGO, M.HorarioEntrada_MED AS[HORARIO DE ENTRADA], M.HorarioSalida_MED AS[HORARIO DE SALIDA], M.Email_MED AS EMAIL, M.Telefono_MED AS TELEFONO FROM Medicos AS M INNER JOIN Localidades AS L ON M.Localidad_MED = L.IDLocalidad_LOC INNER JOIN Provincias AS P ON P.IDProvincia_PRO = L.IDProvincia_LOC INNER JOIN Especialidades AS E ON M.Especialidad_MED = E.IDEspecialidad_ES WHERE M.Estado_MED = 1 ORDER BY M.Sexo_MED");
            return tabla;
        }
        //filtro 4: 
        public DataTable Filtro_Sexo_Descendiente()
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT  M.Legajo_MED AS LEGAJO, M.Nombre_MED AS NOMBRE, M.Apellido_MED AS APELLIDO, M.DNI_MED AS DNI, M.Sexo_MED AS SEXO, M.Nacionalidad_MED AS NACIONALIDAD, M.FechaNacimiento_MED AS[FECHA NACIMIENTO], M.Direccion_MED AS DIRECCION, E.Nombre_ES AS ESPECIALIDAD, P.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, M.Dia_MED_1 AS LUNES, M.Dia_MED_2 AS MARTES, M.Dia_MED_3 AS MIERCOLES, M.Dia_MED_4 AS JUEVES, M.Dia_MED_5 AS VIERNES, M.Dia_MED_6 AS SABADO, M.Dia_MED_7 AS DOMINGO, M.HorarioEntrada_MED AS[HORARIO DE ENTRADA], M.HorarioSalida_MED AS[HORARIO DE SALIDA], M.Email_MED AS EMAIL, M.Telefono_MED AS TELEFONO FROM Medicos AS M INNER JOIN Localidades AS L ON M.Localidad_MED = L.IDLocalidad_LOC INNER JOIN Provincias AS P ON P.IDProvincia_PRO = L.IDProvincia_LOC INNER JOIN Especialidades AS E ON M.Especialidad_MED = E.IDEspecialidad_ES WHERE M.Estado_MED = 1 ORDER BY M.Sexo_MED DESC");
            return tabla;
        }
        //filtro 5: 
        public DataTable Filtro_Especialidad()
        {
            DataTable tabla = datos.ObtenerTabla("Medicos", "SELECT  M.Legajo_MED AS LEGAJO, M.Nombre_MED AS NOMBRE, M.Apellido_MED AS APELLIDO, M.DNI_MED AS DNI, M.Sexo_MED AS SEXO, M.Nacionalidad_MED AS NACIONALIDAD, M.FechaNacimiento_MED AS[FECHA NACIMIENTO], M.Direccion_MED AS DIRECCION, E.Nombre_ES AS ESPECIALIDAD, P.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, M.Dia_MED_1 AS LUNES, M.Dia_MED_2 AS MARTES, M.Dia_MED_3 AS MIERCOLES, M.Dia_MED_4 AS JUEVES, M.Dia_MED_5 AS VIERNES, M.Dia_MED_6 AS SABADO, M.Dia_MED_7 AS DOMINGO, M.HorarioEntrada_MED AS[HORARIO DE ENTRADA], M.HorarioSalida_MED AS[HORARIO DE SALIDA], M.Email_MED AS EMAIL, M.Telefono_MED AS TELEFONO FROM Medicos AS M INNER JOIN Localidades AS L ON M.Localidad_MED = L.IDLocalidad_LOC INNER JOIN Provincias AS P ON P.IDProvincia_PRO = L.IDProvincia_LOC INNER JOIN Especialidades AS E ON M.Especialidad_MED = E.IDEspecialidad_ES WHERE M.Estado_MED = 1 ORDER BY E.Nombre_ES");
            return tabla;
        }
    }
}
