using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projecto_Final_PG4.Entidades;
using Projecto_Final_PG4.AccesoDatos;

namespace Projecto_Final_PG4.Logica
{
    public class ServiciosClienteOperaciones
    {
        IUnitOfWork uow = new UnitOfWork();

        public List<Servicios_Cliente> ObtenerTodos()
        {
            return uow.ServiciosCliente.ObtenerTodos();

        }

        public Servicios_Cliente ObtenerId(int id)//cambie la variable de int a string
        {
            return uow.ServiciosCliente.ObtenerId(id);
        }

        public void Modificar(Servicios_Cliente s)
        {
            Servicios_Cliente serviciosE = uow.ServiciosCliente.ObtenerId(s.cedula);
            if (serviciosE != null)
            {
                uow.DbContexto.Entry(serviciosE).CurrentValues.SetValues(s);
                uow.ServiciosCliente.Modificar(serviciosE);
            }
        }

        public void Eliminar(int id)
        {
            Servicios_Cliente serviciosE = uow.ServiciosCliente.ObtenerId(id);
            if (serviciosE != null)
            {
                uow.ServiciosCliente.Eliminar(serviciosE);
            }
        }

        public void Insertar(Servicios_Cliente s)
        {
            try
            {
                uow.ServiciosCliente.Insertar(s);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error ServiciosClienteOperaciones.Insertar: {exp.Message}");
            }
        }
    }
}
