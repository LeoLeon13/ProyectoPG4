using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projecto_Final_PG4.Entidades;
using Projecto_Final_PG4.AccesoDatos;

namespace Projecto_Final_PG4.Logica
{
    public class AutoClienteOperaciones
    {
        IUnitOfWork uow = new UnitOfWork();


        public Auto_Cliente ObtenerId(int id)
        {
            return uow.AutoCliente.ObtenerId(id);
        }

        public List<Auto_Cliente> ObtenerTodos()
        {
            return uow.AutoCliente.ObtenerTodos();
        }

        public void Eliminar(int t)
        {
            Auto_Cliente autoE = uow.AutoCliente.ObtenerId(t);
            if (autoE != null)
            {
                uow.AutoCliente.Eliminar(autoE);
            }
        }

        //public void Eliminar(string Auto_Cliente)
        //{
        //    oAutoCliente.Eliminar(Auto_Cliente);
        //}

        public void Insertar(Auto_Cliente t)
        {
            try
            {
                uow.AutoCliente.Insertar(t);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error AutoclienteOperaciones.Insertar: {exp.Message}");
            }
        }

        public void Modificar(Auto_Cliente p)
        {
            Auto_Cliente autoE = uow.AutoCliente.ObtenerId(p.ID_Auto_Cliente);
            if (autoE != null)
            {
                uow.DbContexto.Entry(autoE).CurrentValues.SetValues(p);
                uow.AutoCliente.Modificar(autoE);
            }
        }

    }
}
