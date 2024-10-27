using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        int Legajo_USU;
        string Usuario_USU;
        string Contraseña_USU;

        public Usuario() { }


        public int get_Legajo_USU()
        {
            return Legajo_USU;
        }
        public void set_Legajo_USU(int Legajo)
        {
            this.Legajo_USU = Legajo;
        }


        public string get_Usuario_USU()
        {
            return Usuario_USU;
        }
        public void set_Usuario_USU(string usu)
        {
            this.Usuario_USU = usu;
        }

        public string get_Contraseña_USU()
        {
            return Contraseña_USU;
        }
        public void set_Contraseña_USU(string c)
        {
            this.Contraseña_USU = c;
        }

    }
}
