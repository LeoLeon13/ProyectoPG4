using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projecto_Final_PG4.Entidades;
using Projecto_Final_PG4.AccesoDatos;

namespace Projecto_Final_PG4.Logica
{
    public class ServiciosOperaciones
    {
        IUnitOfWork uow = new UnitOfWork();

        public List<Servicios> ObtenerTodos()
        {
            return uow.Servicios.ObtenerTodos();

        }

        public Servicios ObtenerId(int id)//cambie la variable de int a string
        {
            return uow.Servicios.ObtenerId(id);
        }

        public void Modificar(Servicios s)
        {
            Servicios serviciosE = uow.Servicios.ObtenerId(s.cedula);
            if (serviciosE != null)
            {
                uow.DbContexto.Entry(serviciosE).CurrentValues.SetValues(s);
                uow.Servicios.Modificar(serviciosE);
            }
        }

        public void Eliminar(int id)
        {
            Servicios serviciosE = uow.Servicios.ObtenerId(id);
            if (serviciosE != null)
            {
                uow.Servicios.Eliminar(serviciosE);
            }
        }

        public void Insertar(Servicios s)
        {
            try
            {
                uow.Servicios.Insertar(s);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error ServiciosOperaciones.Insertar: {exp.Message}");
            }
        }
    }
}
