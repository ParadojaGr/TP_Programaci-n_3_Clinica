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
    public class NegocioUsuario
    {
        public Boolean BuscarExisteUsuario(string NomUsuario, string Contraseña)
        {
            DatosUsuario datos = new DatosUsuario();
            return datos.existeUsuario(NomUsuario, Contraseña);
        }

        public bool Es_Admin(string NomUsuario, string Contraseña)
        {
            DatosUsuario datos = new DatosUsuario();
            return datos.EsAdmin(NomUsuario, Contraseña);
        }


        //para traer la tabla:
        public DataTable getTablaUsuario()
        {
            DatosUsuario datos = new DatosUsuario();
            return datos.getTabla();
        }


        public bool AgregarUsuario(int Legajo, string Nombre, string Contraseña)
        {
            int cantidadFilas = 0;
            Usuario usu = new Usuario();
            usu.set_Legajo_USU(Legajo);
            usu.set_Usuario_USU(Nombre);
            usu.set_Contraseña_USU(Contraseña);

            DatosUsuario datos = new DatosUsuario();
            if (datos.existeLegajo(Legajo))
            {
                if (datos.existeUsuario(usu.get_Usuario_USU(), usu.get_Contraseña_USU()) == false)
                {
                    cantidadFilas = datos.AgregarUsuario(usu);
                }
                if (cantidadFilas == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public bool ActualizarUsuario(Usuario usuario)
        {
            DatosUsuario datos = new DatosUsuario();
            int cantidadFilas = 0;
            cantidadFilas = datos.ActualizarUsuario(usuario);
            if (cantidadFilas == 1)
            {
                return true;
            }
            else return false;
        }

    }
}
