using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Dao
{
    class AccesoDatos
    {
        //readonly es para solo lecutura, por si las dudas
        private readonly string rutaBDClinica = "Data Source=DESKTOP-8O9CCQ9\\SQLEXPRESS01;Initial Catalog=PRUEBATPI_SEGUNDA_VERSION;Integrated Security=True";


        public AccesoDatos() { }

        private SqlConnection ObtenerConexion()
        {
            var cn = new SqlConnection(rutaBDClinica);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        ///PARA OBTENER LA CONSULTA DE LA BASE DE DATOS
        private SqlDataAdapter ObtenerAdaptador(string consultaSql, SqlConnection cn)
        {
            try
            {
                return new SqlDataAdapter(consultaSql, cn);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        // Creo estás funciones para que me permitan ejecutar consultas tipo SQLCOMAND
        /*private SqlDataAdapter ObtenerAdaptador(SqlCommand comando) 
        {
            try
            {
                return new SqlDataAdapter(comando);
            }
            catch (Exception ex)
            {
                return null;
            }
        }*/
        //PARA DEVOLVER EN FORMA DE DATATABLE LOS DATOS DE LA BASE A LA QUE QUEREMOS ACCEDER

        public DataTable ObtenerTabla(string nombreTabla, string sql)
        {
            // los usos de var es para no escribir el nombre completo de la variable
            // var declara un dato y deduce que tipo de dato es, no se puede canbiar luego el tipo de dato una 
            // vez declarado. 
            using (var ds = new DataSet())
            using (var conexion = ObtenerConexion())
            {
                var adp = ObtenerAdaptador(sql, conexion);
                adp.Fill(ds, nombreTabla);
                return ds.Tables[nombreTabla];
            }
        }
        // En vez de trabajar con string lo hago con SQLcomand
        /*public DataTable ObtenerTabla(string nombreTabla, SqlCommand comando)
        {
            using (var ds = new DataSet())
            {
                var adp = ObtenerAdaptador(comando);
                adp.Fill(ds, nombreTabla);
                return ds.Tables[nombreTabla];
            }
        }*/

        public int EjecutarProcedimientoAlmacenado(SqlCommand comando, string nombreSP)
        {
            using (var conexion = ObtenerConexion())
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombreSP;
                return comando.ExecuteNonQuery();
            }
        }
        // Devuelve una tabla usando las nuevas funciones 
        /*public DataTable EjecutarProcedimientoAlmacenado(SqlCommand comando, string nombreSP, string nombreTabla)
        {
            using (var conexion = ObtenerConexion())
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombreSP;
                return ObtenerTabla(nombreTabla, comando);
            }
        }*/
        public bool Existe(string consulta)
        {
            using (var conexion = ObtenerConexion())
            using (var cmd = new SqlCommand(consulta, conexion))
            using (var datos = cmd.ExecuteReader())
            {
                return datos.Read();
            }
        }

    }
}
