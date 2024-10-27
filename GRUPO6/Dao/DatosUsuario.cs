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
    public class DatosUsuario
    {

        AccesoDatos datos = new AccesoDatos();

        public Usuario getUsuario(Usuario us)
        {
            DataTable tabla = datos.ObtenerTabla("Usuarios", "SELECT * FROM Usuarios");

            us.set_Legajo_USU(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            us.set_Usuario_USU(tabla.Rows[0][1].ToString());
            us.set_Contraseña_USU(tabla.Rows[0][2].ToString());

            return us;
        }


        //trae toda la tabla:
        public DataTable getTabla()
        {
            DataTable tabla = datos.ObtenerTabla("Usuarios", "SELECT Legajo_USU, Nombre_USU, Contraseña_USU FROM Usuarios");
            return tabla;
        }


        //AGREGAR:
        public int AgregarUsuario(Usuario usuario)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAgregarUsuario(ref comando, usuario);
            return datos.EjecutarProcedimientoAlmacenado(comando, "spAgregarUsuario");
        }

        private void ArmarParametrosAgregarUsuario(ref SqlCommand comando, Usuario usuario)
        {
            SqlParameter sqlParametro = new SqlParameter();
            sqlParametro = comando.Parameters.Add("@Legajo", SqlDbType.Int);
            sqlParametro.Value = usuario.get_Legajo_USU();
            sqlParametro = comando.Parameters.Add("@Nombre", SqlDbType.VarChar);
            sqlParametro.Value = usuario.get_Usuario_USU();
            sqlParametro = comando.Parameters.Add("@Contraseña", SqlDbType.VarChar);
            sqlParametro.Value = usuario.get_Contraseña_USU();
        }

        //ACTUALIZAR:
        public int ActualizarUsuario(Usuario usuario)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosActualizarUsuario(ref comando, usuario);
            return datos.EjecutarProcedimientoAlmacenado(comando, "spActualizarUsuario");
        }
        private void ArmarParametrosActualizarUsuario(ref SqlCommand comando, Usuario usuario)
        {
            SqlParameter sqlParametro = new SqlParameter();
            sqlParametro = comando.Parameters.Add("@Legajo_USU", SqlDbType.Int);
            sqlParametro.Value = usuario.get_Legajo_USU();
            sqlParametro = comando.Parameters.Add("@Nombre_USU", SqlDbType.VarChar);
            sqlParametro.Value = usuario.get_Usuario_USU();
            sqlParametro = comando.Parameters.Add("@Contraseña_USU", SqlDbType.VarChar);
            sqlParametro.Value = usuario.get_Contraseña_USU();
        }

        //buscar si existe por nombre de usuario y contraseña
        public Boolean existeUsuario(string nombreUsuario, string contraseña)
        {
            string consulta = "SELECT * FROM Usuarios where Nombre_USU = '" + nombreUsuario + "' AND Contraseña_USU ='" + contraseña + "'";
            return datos.Existe(consulta);
        }

        //EXISTE POR LEGAJO
        public Boolean existeLegajo(int Legajo)
        {
            string consulta = "SELECT *  FROM Medicos WHERE Estado_MED = 1 AND Legajo_MED = '"+ Legajo + "' ";
            return datos.Existe(consulta);
        }

        //si se encuentra busca si es admin o medico.
        public Boolean EsAdmin(string nombreUsuario, string contraseña)
        {
            string consulta = "SELECT * FROM Usuarios AS U INNER JOIN Administradores AS A ON U.Legajo_USU = A.Legajo_ADM where Nombre_USU = '" + nombreUsuario + "' AND Contraseña_USU = '" + contraseña + "' ";
            return datos.Existe(consulta);
        }
    }
}

