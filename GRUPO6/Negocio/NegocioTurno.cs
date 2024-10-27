using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao;
using Entidades;

namespace Negocio
{
    public class NegocioTurno
    {
        DatosTurno datos = new DatosTurno();

        public DataTable getTablaTurno()
        {
            return datos.getTabla();
        }

        public DataTable getTablaTurnoIndividual(string Nombre)
        {
            return datos.getTablaIndividual(Nombre);
        }

        public DataTable getRegistroIndividual(string nombre, int id)
        {
            return datos.getRegistroTurnoIndividual(nombre, id);
        }

        public bool ActualizarTurno(Turnos turno)
        {
            DatosTurno datos = new DatosTurno();
            int cantidadFilas = 0;
            cantidadFilas = datos.ActualizarTurnos(turno);
            if (cantidadFilas == 1)
            {
                return true;
            }
            else return false;
        }

        public DataTable getRegistro(int id)
        {
            return datos.getRegistroTurno(id);
        }

        public Boolean BuscarExiste(int ID)
        {
            return datos.existeTurnos(ID);
        }

        public int CargarTurno(Turnos tur)
        {
            return datos.AgregarTurnos(tur);
        }

        public List<string> getTurnosDisponibles(int legajo, string dia)
        {
            List<string> horasDisponibles = new List<string>();
            List<string> horasTurnosOcupados = new List<string>();
            List<string> horasTurnosPosibles = new List<string>();
            List<string> horasEntradaSalida = new List<string>();
            horasTurnosOcupados = datos.getTurnosPorLegajoYDia(legajo, dia);

            horasEntradaSalida = datos.getHorarioEntradaSalida(legajo);

            string horaInicioAtencion = horasEntradaSalida[0];
            string horaFinAtencion = horasEntradaSalida[1];

            string horaIndex = horaInicioAtencion;

            DateTime horaDate = DateTime.ParseExact(horaInicioAtencion, "H:mm", null);

            while (horaIndex != horaFinAtencion)
            {
                horasTurnosPosibles.Add(horaDate.ToString("HH:mm"));

                horaDate = horaDate.AddHours(1);

                horaIndex = horaDate.ToString("HH:mm");
            }


            foreach (var htp in horasTurnosPosibles)
            {
                bool horaLibre = true;
                foreach (var hto in horasTurnosOcupados)
                {
                    if (hto == htp)
                    {
                        horaLibre = false;
                    }
                }
                if (horaLibre)
                {
                    horasDisponibles.Add(htp);
                }
            }

            return horasDisponibles;
        }


    }
}
