using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projecto_Final_PG4.Entidades;
using Projecto_Final_PG4.AccesoDatos;

namespace Projecto_Final_PG4.Logica
{
    public class TipoServicioOperaciones
    {
        IUnitOfWork uow = new UnitOfWork();

        public List<TipoServicio> ObtenerTodosTipoServicios()
        {
            return uow.TipoServicio.ObtenerTodos();

        }

        public TipoServicio ObtenerTipoServiciosID(int id)
        {
            return uow.TipoServicio.ObtenerId(id);
        }

        public void ModificarTipoServicios(TipoServicio s)
        {
            TipoServicio tiposerviciosE = uow.TipoServicio.ObtenerId(s.ID_tipo_servicio);
            if (tiposerviciosE != null)
            {
                uow.DbContexto.Entry(tiposerviciosE).CurrentValues.SetValues(s);
                uow.TipoServicio.Modificar(tiposerviciosE);
            }
        }

        public void EliminarTipoServicios(int id)
        {
            TipoServicio tiposerviciosE = uow.TipoServicio.ObtenerId(id);
            if (tiposerviciosE != null)
            {
                uow.TipoServicio.Eliminar(tiposerviciosE);
            }
        }

        public void InsertarTipoServicios(TipoServicio s)
        {
            try
            {
                uow.TipoServicio.Insertar(s);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error ServiciosOperaciones.Insertar: {exp.Message}");
            }
        }
    }
}
