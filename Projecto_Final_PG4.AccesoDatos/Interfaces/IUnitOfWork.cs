using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Final_PG4.AccesoDatos
{
    public interface IUnitOfWork
    {        
        IAutoClienteRepositorio AutoCliente { get; }
        IAutomotoresRepositorio Automotores { get; }
        ILoginRepositorio Login { get; }
        IPersonaRepositorio Persona { get; }
        IServiciosClienteRepositorio ServiciosCliente { get; }
        IServiciosRepositorio Servicios { get; }
        ITipoServicioRepositorio TipoServicio { get; }

        Contexto DbContexto { get; }

        int SaveChanges();
    }
}
