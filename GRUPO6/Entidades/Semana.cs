using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Semana
    {
        public int Lunes { get; set; }
        public int Martes { get; set; }
        public int Miercoles { get; set; }
        public int Jueves { get; set; }
        public int Viernes { get; set; }
        public int Sabado { get; set; }
        public int Domingo { get; set; }



        public List<string> Get_ListadoStringDias()
        {
            var lista = new List<string>();

            if (Lunes == 1)
            {
                lista.Add("Lunes");
            }
            if (Martes == 1)
            {
                lista.Add("Martes");
            }
            if (Miercoles == 1)
            {
                lista.Add("Miercoles");
            }
            if (Jueves == 1)
            {
                lista.Add("Jueves");
            }
            if (Viernes == 1)
            {
                lista.Add("Viernes");
            }
            if (Sabado == 1)
            {
                lista.Add("Sabado");
            }
            if (Domingo == 1)
            {
                lista.Add("Domingo");
            }

            return lista;
        } 
    }
}
