using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Projecto_Final_PG4.Entidades;
using Projecto_Final_PG4.Logica;

namespace Projecto_Final_PG4.Comunicacion
{
    public class Service1 : IService1
    {
        public PersonaDTO BuscarPersona(int id)
        {

            PersonaOperaciones personaOperaciones = new PersonaOperaciones();
            Persona persona = personaOperaciones.ObtenerId(id);

            //Crear Mapper
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Persona, PersonaDTO>());
            var mapper = config.CreateMapper();

            //Realizar el Mapeo
            PersonaDTO dto = mapper.Map<PersonaDTO>(persona);
            return dto;
        }

        public void InsertarPersona(PersonaDTO persona)
        {
            //Creando Automapper
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PersonaDTO, Persona>());
            var mapper = config.CreateMapper();
            Persona dto = mapper.Map<Persona>(persona);
        }

        public ListaPersonaDTO TodasPersonas()
        {
            throw new NotImplementedException();
        }
    }
}
