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
    public class NegocioPaciente
    {
        //obtener la tabla Paciente completa con sus respectivos joins.
        public DataTable getTablaPaciente()
        {
            DatosPaciente datos = new DatosPaciente();
            return datos.getTabla();
        }

        //obtiene la tabla sin joins para su modificacion:
        public DataTable getTablaSinJoins()
        {
            DatosPaciente datos = new DatosPaciente();
            return datos.getTablaPacientesNormal();
        }

        //obtiene un registro especifico mediante un dni
        public DataTable getRegistroPaciente(string dni)
        {
            DatosPaciente datos = new DatosPaciente();
            return datos.getTablaJoinPacientes(dni);
        }

        //busca si existe el registro mediante un dni
        public Boolean buscarExiste(string dni)
        {
            DatosPaciente datos = new DatosPaciente();
            return datos.existePaciente(dni);
        }

        //
        public Paciente get(string dni)
        {
            DatosPaciente datos = new DatosPaciente();
            Paciente pac = new Paciente();
            pac.set_DNI(dni);
            return datos.getPaciente(pac);
        }

        //eliminar Paciente. (llama a DatosPaciente)
        public int EliminarPaciente(string dni)
        {
            DatosPaciente datos = new DatosPaciente();
            Paciente pac = new Paciente();
            pac.set_DNI(dni);
            if (datos.existePaciente(pac.get_DNI()) == true)
            {
                int op = datos.EliminarPaciente(pac);
                if (op == 1)
                {
                    return 1; //si devuelve 1 es porque funciono.
                }
                else
                {
                    return 0; //si devuelve 0 es porque no funciono.
                }
            }
            else
            {
                return 2; //si devuelve 2 es porque no lo encontro.
            }
        }

        //agregar Paciente. (llama a DatosPaciente)
        public bool AgregarPaciente(string Nombre, string DNI, string Apellido, string Sexo, string Nacionalidad, string Nacimiento, string Direccion, int Provincia, int Localidad, string Email, string Telefono)
        {
            int cantidadFilas = 0;
            Paciente pac = new Paciente();
            pac.set_DNI(DNI);
            pac.set_Nombre(Nombre);
            pac.set_Apellido(Apellido);
            pac.set_Sexo(Sexo);
            pac.set_Nacionalidad(Nacionalidad);
            pac.set_FechaNacimiento(Nacimiento);
            pac.set_Direccion(Direccion);
            pac.set_Provincia(Provincia);
            pac.set_Localidad(Localidad);
            pac.set_Email(Email);
            pac.set_Telefono(Telefono);


            DatosPaciente datos = new DatosPaciente();
            if(datos.existePaciente(pac.get_DNI()) == false)
            {
                pac.set_Estado(true);
                cantidadFilas = datos.AgregarPaciente(pac);
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

        //Actulizar Paciente:
        public bool ActualizarPaciente(Paciente paciente)
        {
            DatosPaciente datos = new DatosPaciente();
            int cantidadFilas = 0;
            cantidadFilas = datos.ActualizarPaciente(paciente);
            if (cantidadFilas == 1)
            {
                return true;
            }
            else return false;
        }

        //FILTROS:
        public DataTable Filtro_Nombre()
        {
            DatosPaciente datos = new DatosPaciente();
            return datos.Filtro_Nombre();
        }
        //filtro 2: 
        public DataTable Filtro_Apellido()
        {
            DatosPaciente datos = new DatosPaciente();
            return datos.Filtro_Apellido();
        }
        //filtro 3: 
        public DataTable Filtro_Sexo()
        {
            DatosPaciente datos = new DatosPaciente();
            return datos.Filtro_Sexo();
        }
        //filtro 4: 
        public DataTable Filtro_Sexo_Descendiente()
        {
            DatosPaciente datos = new DatosPaciente();
            return datos.Filtro_Sexo_Descendiente();
        }

    }
}
