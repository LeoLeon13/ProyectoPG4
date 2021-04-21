﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projecto_Final_PG4.Entidades;

namespace Projecto_Final_PG4.AccesoDatos
{
    public class AutomotoresRepositorio : Repositorio<Automotores>, IAutomotoresRepositorio
    {
        public AutomotoresRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
