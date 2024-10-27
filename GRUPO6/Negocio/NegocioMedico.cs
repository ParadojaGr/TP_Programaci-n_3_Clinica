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
    public class NegocioMedico
    {
        //obtener la tabla Medicos completa con sus respectivos joins.
        public DataTable getTablaMedico()
        {
            DatosMedico datos = new DatosMedico();
            return datos.getTabla();
        }

        //Traer los medicos para el ddl:
        public DataTable getMedicosParaDDL(string especialidad)
        {
            DatosMedico datos = new DatosMedico();
            return datos.getMedicosDDL(especialidad);
        }

        //traer la tabla sin joins.
        public DataTable getTablaSinJoins()
        {
            DatosMedico datos = new DatosMedico();
            return datos.getTablaMedicosNormal();
        }

        //obtiene un registro especifico mediante un legajo
        public DataTable getRegistroMedico(int legajo)
        {
            DatosMedico datos = new DatosMedico();
            return datos.getTablaJoinMedicos(legajo);
        }

        //Obtiene los dias en los que trabaja un medico:



        //busca si existe el registro mediante un legajo
        public Boolean buscarExiste(int legajo)
        {
            DatosMedico datos = new DatosMedico();
            return datos.existeMedico(legajo);
        }

        //
        public Medico get(int legajo)
        {
            DatosMedico datos = new DatosMedico();
            Medico med = new Medico();
            med.set_Legajo(legajo);
            return datos.getMedico(med);
        }

        // Get Dias en los que trabaja el Medico para el DDL:
        public Semana getDiasParaDDL(string legajo)
        {
            DatosMedico datos = new DatosMedico();
            return datos.getDiasMedico(legajo);
        }
        

        //Eliminar Medico. (llama a DatosMedicos)
        public int EliminarMedico(int legajo)
        {
            DatosMedico datos = new DatosMedico();
            Medico med = new Medico();
            med.set_Legajo(legajo);
            if (datos.existeMedico(med.get_Legajo()) == true)
            {
                int op = datos.EliminarMedico(med);
                if(op == 1)
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
        
        //agregar Medico. (llama a DatosMedicos)
        public bool AgregarMedico(int legajo, string Nombre, string DNI, string Apellido, string Sexo, string Nacionalidad, string Nacimiento, string Direccion, string Especialidad, bool Lunes, bool Martes, bool Miercoles, bool Jueves, bool Viernes, bool Sabado, bool Domingo, string HorarioEntrada, string HorarioSalida, int Provincia, int Localidad, string Email, string Telefono)
        {
            int cantidadFilas = 0;
            Medico med = new Medico();
            med.set_Legajo(legajo);
            med.set_Nombre(Nombre);
            med.set_DNI(DNI);
            med.set_Apellido(Apellido);
            med.set_Sexo(Sexo);
            med.set_Nacionalidad(Nacionalidad);
            med.set_FechaNacimiento(Nacimiento);
            med.set_Direccion(Direccion);
            med.set_Especialidad(Especialidad);
            med.set_Lunes(Lunes);
            med.set_Martes(Martes);
            med.set_Miercoles(Miercoles);
            med.set_Jueves(Jueves);
            med.set_Viernes(Viernes);
            med.set_Sabado(Sabado);
            med.set_Domingo(Domingo);
            med.set_HorarioEntrada(HorarioEntrada);
            med.set_HorarioSalida(HorarioSalida);
            med.set_Provincia(Provincia);
            med.set_Localidad(Localidad);
            med.set_Email(Email);
            med.set_Telefono(Telefono);

            DatosMedico datos = new DatosMedico();
            if(datos.existeMedico(med.get_Legajo()) == false)
            {
                med.set_Estado(true);
                cantidadFilas = datos.AgregarMedico(med);
            }
            if(cantidadFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Actulizar Medico:
        public bool ActualizarMedico(Medico medico)
        {
            DatosMedico datos = new DatosMedico();
            int cantidadFilas = 0;
            cantidadFilas = datos.ActualizarMedico(medico);
            if (cantidadFilas == 1)
            {
                return true;
            }
            else return false;
        }


        //FILTROS:
        public DataTable Filtro_Nombre()
        {
            DatosMedico datos = new DatosMedico();
            return datos.Filtro_Nombre();
        }
        //filtro 2: 
        public DataTable Filtro_Apellido()
        {
            DatosMedico datos = new DatosMedico();
            return datos.Filtro_Apellido();
        }
        //filtro 3: 
        public DataTable Filtro_Sexo()
        {
            DatosMedico datos = new DatosMedico();
            return datos.Filtro_Sexo();
        }
        //filtro 4: 
        public DataTable Filtro_Sexo_Descendiente()
        {
            DatosMedico datos = new DatosMedico();
            return datos.Filtro_Sexo_Descendiente();
        }
        //filtro 5: 
        public DataTable Filtro_Especialidad()
        {
            DatosMedico datos = new DatosMedico();
            return datos.Filtro_Especialidad();
        }
    }
}
