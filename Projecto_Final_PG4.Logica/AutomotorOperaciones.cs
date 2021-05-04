using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projecto_Final_PG4.Entidades;
using Projecto_Final_PG4.AccesoDatos;

namespace Projecto_Final_PG4.Logica
{
    public class AutomotorOperaciones
    {
        IUnitOfWork uow = new UnitOfWork();


        public List<Automotores> ObtenerTodos()
        {
            return uow.Automotores.ObtenerTodos();
        }

        public Automotores ObtenerId(int id) //cambie esta variable de int a string y la devolvi a string
        {
            return uow.Automotores.ObtenerId(id);
        }

        public void Modificar(Automotores a)
        {
            Automotores automotorE = uow.Automotores.ObtenerId(a.ID_automotor);
            if (automotorE != null)
            {
                uow.DbContexto.Entry(automotorE).CurrentValues.SetValues(a);
                uow.Automotores.Modificar(automotorE);
            }
        }

        public void Eliminar(int id)
        {
            Automotores automotorE = uow.Automotores.ObtenerId(id);
            if (automotorE != null)
            {
                uow.Automotores.Eliminar(automotorE);
            }
        }

        public void Insertar(Automotores a)
        {
            try
            {
                uow.Automotores.Insertar(a);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error AutomotoresOperaciones.Insertar: {exp.Message}");
            }
        }
    }
}
