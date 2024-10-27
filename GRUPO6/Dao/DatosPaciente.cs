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
    public class DatosPaciente
    {
        AccesoDatos datos = new AccesoDatos();

        public Paciente getPaciente(Paciente pac)
        {
            DataTable tabla = datos.ObtenerTabla("Pacientes", "SELECT * FROM Pacientes");

            pac.set_DNI(tabla.Rows[0][0].ToString());
            pac.set_Nombre(tabla.Rows[0][1].ToString());
            pac.set_Apellido(tabla.Rows[0][2].ToString());
            pac.set_Sexo(tabla.Rows[0][3].ToString());
            pac.set_Nacionalidad(tabla.Rows[0][4].ToString());
            pac.set_FechaNacimiento(tabla.Rows[0][5].ToString());
            pac.set_Direccion(tabla.Rows[0][6].ToString());
            pac.set_Provincia(Convert.ToInt32(tabla.Rows[0][7].ToString()));
            pac.set_Localidad(Convert.ToInt32(tabla.Rows[0][8].ToString()));
            pac.set_Email(tabla.Rows[0][9].ToString());
            pac.set_Telefono(tabla.Rows[0][10].ToString());
            return pac;
        }

        //buscar si existe por nombre
        public Boolean existePaciente(string dni)
        {
            string consulta = "Select * from Pacientes WHERE Estado_PAC = 1 AND DNI_PAC LIKE'%" + dni + "%'";
            return datos.Existe(consulta);
        }

        //eliminar.
        public int EliminarPaciente(Paciente paciente)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosEliminarPaciente(ref comando, paciente);
            return datos.EjecutarProcedimientoAlmacenado(comando, "spEliminarPaciente"); 
        }

        //agregar.
        public int AgregarPaciente(Paciente paciente)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAgregarPaciente(ref comando, paciente);
            return datos.EjecutarProcedimientoAlmacenado(comando, "spAgregarPaciente");
        }

        //actualizar.
        public int ActualizarPaciente(Paciente paciente)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosActualizarPaciente(ref comando, paciente);
            return datos.EjecutarProcedimientoAlmacenado(comando, "spActualizarPaciente");
        }

        //arma los parametros para eliminar la sucursal.
        private void ArmarParametrosEliminarPaciente(ref SqlCommand comando, Paciente paciente)
        {
            SqlParameter sqlParametro = new SqlParameter();
            sqlParametro = comando.Parameters.Add("@DNI", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_DNI();
        }

        //arma los parametros para agregar la sucursal.
        private void ArmarParametrosAgregarPaciente(ref SqlCommand comando, Paciente paciente)
        {
            SqlParameter sqlParametro = new SqlParameter();


            sqlParametro = comando.Parameters.Add("@DNI_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_DNI();
            sqlParametro = comando.Parameters.Add("@Nombre_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Nombre();            
            sqlParametro = comando.Parameters.Add("@Apellido_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Apellido();
            sqlParametro = comando.Parameters.Add("@Sexo_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Sexo();
            sqlParametro = comando.Parameters.Add("@Nacionalidad_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Nacionalidad();
            sqlParametro = comando.Parameters.Add("@FechaNacimiento_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_FechaNacimiento();
            sqlParametro = comando.Parameters.Add("@Direccion_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Direccion();
            sqlParametro = comando.Parameters.Add("@Provincia_PAC", SqlDbType.Int);
            sqlParametro.Value = paciente.get_Provincia();
            sqlParametro = comando.Parameters.Add("@Localidad_PAC", SqlDbType.Int);
            sqlParametro.Value = paciente.get_Localidad();
            sqlParametro = comando.Parameters.Add("@Email_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Email();
            sqlParametro = comando.Parameters.Add("@Telefono_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Telefono();
            sqlParametro = comando.Parameters.Add("@Estado_PAC", SqlDbType.Bit);
            sqlParametro.Value = paciente.get_Estado();

        }

        //armar los parametros para editar el paciente
        private void ArmarParametrosActualizarPaciente(ref SqlCommand comando, Paciente paciente)
        {
            SqlParameter sqlParametro = new SqlParameter();
            sqlParametro = comando.Parameters.Add("@DNI_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_DNI();
            sqlParametro = comando.Parameters.Add("@Nombre_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Nombre();
            sqlParametro = comando.Parameters.Add("@Apellido_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Apellido();
            sqlParametro = comando.Parameters.Add("@Sexo_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Sexo();
            sqlParametro = comando.Parameters.Add("@Nacionalidad_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Nacionalidad();
            sqlParametro = comando.Parameters.Add("@FechaNacimiento_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_FechaNacimiento();
            sqlParametro = comando.Parameters.Add("@Direccion_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Direccion();
            sqlParametro = comando.Parameters.Add("@Provincia_PAC", SqlDbType.Int);
            sqlParametro.Value = paciente.get_Provincia();
            sqlParametro = comando.Parameters.Add("@Localidad_PAC", SqlDbType.Int);
            sqlParametro.Value = paciente.get_Localidad();
            sqlParametro = comando.Parameters.Add("@Email_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Email();
            sqlParametro = comando.Parameters.Add("@Telefono_PAC", SqlDbType.VarChar);
            sqlParametro.Value = paciente.get_Telefono();
        }


        //Busca la tabla con inner join para el gridview
        public DataTable getTabla()
        {
            DataTable tabla = datos.ObtenerTabla("Pacientes", "SELECT  P.DNI_PAC AS DNI, P.Nombre_PAC AS NOMBRE, P.Apellido_PAC AS APELLIDO, P.Sexo_PAC AS SEXO, P.Nacionalidad_PAC AS NACIONALIDAD, P.FechaNacimiento_PAC AS[FECHA DE NACIMIENTO], P.Direccion_PAC AS DIRECCION, PRO.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, P.Email_PAC AS EMAIL, P.Telefono_PAC AS TELEFONO FROM Pacientes AS P INNER JOIN Localidades AS L ON L.IDLocalidad_LOC = P.Localidad_PAC INNER JOIN Provincias AS PRO ON PRO.IDProvincia_PRO = L.IDProvincia_LOC WHERE P.Estado_PAC = 1");
            return tabla;
        }

        //tabla sin joins:
        public DataTable getTablaPacientesNormal()
        {
            DataTable tabla = datos.ObtenerTabla("Pacientes", "SELECT * FROM Pacientes WHERE Estado_PAC = 1");
            return tabla;
        }

        //busca la tabla con el inner join pero solo el Paciente a buscar
        public DataTable getTablaJoinPacientes(string DNI)
        {
            DataTable tabla = datos.ObtenerTabla("Pacientes", "SELECT  P.DNI_PAC AS DNI, P.Nombre_PAC AS NOMBRE, P.Apellido_PAC AS APELLIDO, P.Sexo_PAC AS SEXO, P.Nacionalidad_PAC AS NACIONALIDAD, P.FechaNacimiento_PAC AS[FECHA DE NACIMIENTO], P.Direccion_PAC AS DIRECCION, PRO.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, P.Email_PAC AS EMAIL, P.Telefono_PAC AS TELEFONO FROM Pacientes AS P INNER JOIN Localidades AS L ON L.IDLocalidad_LOC = P.Localidad_PAC INNER JOIN Provincias AS PRO ON PRO.IDProvincia_PRO = L.IDProvincia_LOC WHERE P.Estado_PAC = 1 AND P.DNI_PAC LIKE '%"+ DNI +"%' ");
            return tabla;
        }

        //FILTROSSSSSS:
        //filtro 1:
        public DataTable Filtro_Nombre()
        {
            DataTable tabla = datos.ObtenerTabla("Pacientes", "SELECT  P.DNI_PAC AS DNI, P.Nombre_PAC AS NOMBRE, P.Apellido_PAC AS APELLIDO, P.Sexo_PAC AS SEXO, P.Nacionalidad_PAC AS NACIONALIDAD, P.FechaNacimiento_PAC AS[FECHA DE NACIMIENTO], P.Direccion_PAC AS DIRECCION, PRO.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, P.Email_PAC AS EMAIL, P.Telefono_PAC AS TELEFONO FROM Pacientes AS P INNER JOIN Localidades AS L ON L.IDLocalidad_LOC = P.Localidad_PAC INNER JOIN Provincias AS PRO ON PRO.IDProvincia_PRO = L.IDProvincia_LOC WHERE P.Estado_PAC = 1 ORDER BY P.Nombre_PAC");
            return tabla;
        }
        //filtro 2: 
        public DataTable Filtro_Apellido()
        {
            DataTable tabla = datos.ObtenerTabla("Pacientes", "SELECT  P.DNI_PAC AS DNI, P.Nombre_PAC AS NOMBRE, P.Apellido_PAC AS APELLIDO, P.Sexo_PAC AS SEXO, P.Nacionalidad_PAC AS NACIONALIDAD, P.FechaNacimiento_PAC AS[FECHA DE NACIMIENTO], P.Direccion_PAC AS DIRECCION, PRO.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, P.Email_PAC AS EMAIL, P.Telefono_PAC AS TELEFONO FROM Pacientes AS P INNER JOIN Localidades AS L ON L.IDLocalidad_LOC = P.Localidad_PAC INNER JOIN Provincias AS PRO ON PRO.IDProvincia_PRO = L.IDProvincia_LOC WHERE P.Estado_PAC = 1 ORDER BY P.Apellido_PAC");
            return tabla;
        }
        //filtro 3: 
        public DataTable Filtro_Sexo()
        {
            DataTable tabla = datos.ObtenerTabla("Pacientes", "SELECT  P.DNI_PAC AS DNI, P.Nombre_PAC AS NOMBRE, P.Apellido_PAC AS APELLIDO, P.Sexo_PAC AS SEXO, P.Nacionalidad_PAC AS NACIONALIDAD, P.FechaNacimiento_PAC AS[FECHA DE NACIMIENTO], P.Direccion_PAC AS DIRECCION, PRO.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, P.Email_PAC AS EMAIL, P.Telefono_PAC AS TELEFONO FROM Pacientes AS P INNER JOIN Localidades AS L ON L.IDLocalidad_LOC = P.Localidad_PAC INNER JOIN Provincias AS PRO ON PRO.IDProvincia_PRO = L.IDProvincia_LOC WHERE P.Estado_PAC = 1 ORDER BY P.Sexo_PAC");
            return tabla;
        }
        //filtro 4: 
        public DataTable Filtro_Sexo_Descendiente()
        {
            DataTable tabla = datos.ObtenerTabla("Pacientes", "SELECT  P.DNI_PAC AS DNI, P.Nombre_PAC AS NOMBRE, P.Apellido_PAC AS APELLIDO, P.Sexo_PAC AS SEXO, P.Nacionalidad_PAC AS NACIONALIDAD, P.FechaNacimiento_PAC AS[FECHA DE NACIMIENTO], P.Direccion_PAC AS DIRECCION, PRO.Nombre_PRO AS PROVINCIA, L.Nombre_LOC AS LOCALIDAD, P.Email_PAC AS EMAIL, P.Telefono_PAC AS TELEFONO FROM Pacientes AS P INNER JOIN Localidades AS L ON L.IDLocalidad_LOC = P.Localidad_PAC INNER JOIN Provincias AS PRO ON PRO.IDProvincia_PRO = L.IDProvincia_LOC WHERE P.Estado_PAC = 1 ORDER BY P.Sexo_PAC DESC");
            return tabla;
        }
    }

}
