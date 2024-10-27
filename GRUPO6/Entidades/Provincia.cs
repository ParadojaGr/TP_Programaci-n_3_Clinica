using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Provincia
    {
       
        int IDProvincia_PRO;
        string Nombre_PRO;

        public Provincia() { }

        //id provincia
        public int get_Id_Provincia()
        {
            return IDProvincia_PRO;
        }
        public void set_Id_Provincia(int id)
        {
            this.IDProvincia_PRO = id;
        }

        //descripcion
        public string get_Nombre_Provincia()
        {
            return Nombre_PRO;
        }
        public void set_Nombre_Provincia(string desc)
        {
            this.Nombre_PRO = desc;
        }
    }
}
