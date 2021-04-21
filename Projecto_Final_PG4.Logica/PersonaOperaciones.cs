using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projecto_Final_PG4.Entidades;
using Projecto_Final_PG4.AccesoDatos;


namespace Projecto_Final_PG4.Logica
{
    public class PersonaOperaciones
    {
        IUnitOfWork uow = new UnitOfWork();


        public List<Persona> ObtenerTodos()
        {
            return uow.Persona.ObtenerTodos();

        }

        public Persona ObtenerId(string id) //cambie esta variable de int a string
        {
            return uow.Persona.ObtenerId(id);
        }

        public void Modificar(Persona p)
        {
            //Persona personaE = uow.Persona.ObtenerId(p.ID_persona);
            Persona personaE = uow.Persona.ObtenerId(p.cedula);
            if (personaE != null)
            {
                uow.DbContexto.Entry(personaE).CurrentValues.SetValues(p);
                uow.Persona.Modificar(personaE);
            }
        }

        public void Eliminar(int id)
        {
            Persona personaE = uow.Persona.ObtenerId(id);
            if (personaE != null)
            {
                uow.Persona.Eliminar(personaE);
            }
        }

        public void Insertar(Persona p)
        {
            try
            {
                uow.Persona.Insertar(p);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error PersonaOperaciones.Insertar: {exp.Message}");
            }
        }
    }
}
