using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projecto_Final_PG4.Entidades;

namespace Projecto_Final_PG4.AccesoDatos
{
    public class Contexto : DbContext
    {
        public Contexto() 
            : base("name=STRCNN_Projecto_Final_PG4")
        {

        }

        public DbSet<Auto_Cliente> Auto_Clientes { get; set; }
        public DbSet<Automotores> Automotores { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Servicios_Cliente> servicios_Clientes { get; set; }
        public DbSet<TipoServicio> TipoServicios { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
