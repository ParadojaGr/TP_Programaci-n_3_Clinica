using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Localidad
    {
        
        int IDLocalidad_LOC;
        string Nombre_LOC;

        public Localidad() { }

        //id provincia
        public int get_Id_Localidad()
        {
            return IDLocalidad_LOC;
        }
        public void set_Id_Localidad(int id)
        {
            this.IDLocalidad_LOC = id;
        }

        //descripcion
        public string get_Nombre_Localidad()
        {
            return Nombre_LOC;
        }
        public void set_Nombre_Localidad(string desc)
        {
            this.Nombre_LOC = desc;
        }
    
    
    }
}
