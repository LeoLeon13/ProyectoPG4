using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Final_PG4.AccesoDatos
{
    public interface IRepositorio<T> where T : class
    {
        T ObtenerId(object id);
        void Insertar(T entidad);
        void Modificar(T entidad);
        void Eliminar(T entidad);
        List<T> ObtenerTodos();
        IQueryable<T> Tabla { get; }
    }
}
