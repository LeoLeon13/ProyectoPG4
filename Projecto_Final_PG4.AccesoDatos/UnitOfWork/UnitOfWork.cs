using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Final_PG4.AccesoDatos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Contexto _db;
        private IPersonaRepositorio _Persona;
        private IAutoClienteRepositorio _AutoCliente;
        private IAutomotoresRepositorio _Automotores;
        private ILoginRepositorio _Login;
        private IServiciosClienteRepositorio _SrvCliente;
        private IServiciosRepositorio _Servicios;
        private ITipoServicioRepositorio _TipoSrv;


        public Contexto DbContexto
        {
            get { return _db; }
        }

        public IPersonaRepositorio Persona
        {
            get
            {
                if (this._Persona == null)
                {
                    this._Persona = new PersonaRepositorio(_db);
                }
                return this._Persona;
            }
        }

        public IAutoClienteRepositorio AutoCliente 
        {
            get
            {
                if (this._AutoCliente == null)
                {
                    this._AutoCliente = new AutoClienteRepositorio(_db);
                }
                return this._AutoCliente;
            }
        }

        public IAutomotoresRepositorio Automotores 
        {
            get
            {
                if (this._Automotores == null)
                {
                    this._Automotores = new AutomotoresRepositorio(_db);
                }
                return this._Automotores;
            }
        }

        public ILoginRepositorio Login
        {
            get
            {
                if (this._Login == null)
                {
                    this._Login = new LoginRepositorio(_db);
                }
                return this._Login;
            }
        }

        public IServiciosClienteRepositorio ServiciosCliente 
        {
            get
            {
                if (this._SrvCliente == null)
                {
                    this._SrvCliente = new ServiciosClienteRepositorio(_db);
                }
                return this._SrvCliente;
            }
        }

        public IServiciosRepositorio Servicios
        {
            get
            {
                if (this._Servicios == null)
                {
                    this._Servicios = new ServiciosRepositorio(_db);
                }
                return this._Servicios;
            }
        }

        public ITipoServicioRepositorio TipoServicio 
        {
            get
            {
                if (this._TipoSrv == null)
                {
                    this._TipoSrv = new TipoServicioRepositorio(_db);
                }
                return this._TipoSrv;
            }
        }

        //public IDireccionRepositorio Direccion
        //{
        //    get
        //    {
        //        if (this._Direccion == null)
        //        {
        //            this._Direccion = new DireccionRepositorio(_db);
        //        }
        //        return this._Direccion;
        //    }
        //}


        public UnitOfWork()
        {
            _db = new Contexto();

        }

        public void Dispose()
        {

        }

        public int SaveChanges()
        {
            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 1;
        }



    }
}
