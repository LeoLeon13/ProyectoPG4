using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projecto_Final_PG4.Entidades;

namespace Projecto_Final_PG4.AccesoDatos
{
    public class LoginRepositorio : Repositorio<Login>, ILoginRepositorio
    {
        public LoginRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
