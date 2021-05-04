using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AutoMapper;
using Projecto_Final_PG4.Entidades;
using Projecto_Final_PG4.Logica;

namespace Projecto_Final_PG4.ComunicacionSApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PrimerServicio" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PrimerServicio.svc or PrimerServicio.svc.cs at the Solution Explorer and start debugging.
    public class PrimerServicio : IPrimerServicio
    {
        PersonaOperaciones personaOperaciones = new PersonaOperaciones();
        AutoClienteOperaciones autoclienteOperaciones = new AutoClienteOperaciones();
        ServiciosOperaciones serviciosOperaciones = new ServiciosOperaciones();
        AutomotorOperaciones automotoresOperaciones = new AutomotorOperaciones();
        TipoServicioOperaciones tipoServicioOperaciones = new TipoServicioOperaciones();
        ServiciosClienteOperaciones servicioClienteOp = new ServiciosClienteOperaciones();

        public void EliminarPersona(string id)
        {
            personaOperaciones.Eliminar(id);
        }

        public void InsertarPersona(PersonaDTO persona)
        {
            Persona destino = new Persona();
            //Crear mapeo
            //CreateMap<origen,destino>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PersonaDTO, Persona>());
            var mapper = config.CreateMapper();

            //Realizar el Mapeo
            destino = mapper.Map<Persona>(persona);
            personaOperaciones.Insertar(destino);
        }

        public void ModificarPersona(PersonaDTO persona)
        {
            Persona destino = new Persona();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<PersonaDTO, Persona>());
            var mapper = config.CreateMapper();

            destino = mapper.Map<Persona>(persona);
            personaOperaciones.Modificar(destino);
        }

        public PersonaDTO ObtenerPersonaID(string id)//cambie  esto de int a string
        {

            Persona origenPersona = personaOperaciones.ObtenerId(id);
            PersonaDTO destinodto = new PersonaDTO();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Persona, PersonaDTO>());
            var mapper = config.CreateMapper();

            destinodto = mapper.Map<PersonaDTO>(origenPersona);

            destinodto.Cedula = origenPersona.cedula;

            return destinodto;
        }

        public PersonaDTO.ListaPersonas ObtenerTodosPersona()
        {
            List<Persona> listPersonas = personaOperaciones.ObtenerTodos();
            PersonaDTO.ListaPersonas destinoListaPersona = new PersonaDTO.ListaPersonas();
            destinoListaPersona.lista = new List<PersonaDTO>();
            foreach (Persona persona in listPersonas)
            {
                destinoListaPersona.lista.Add(new PersonaDTO()
                {
                    ID_persona = persona.ID_persona
                    ,
                    Cedula = persona.cedula
                    ,
                    Nombre = persona.nombre
                    ,
                    Apellido = persona.apellido
                    ,
                    Correo = persona.correo
                    ,
                    Celular = persona.celular
                    ,
                    EsEmpleado = persona.esEmpleado
                    ,
                    Telefono = persona.telefono
                    ,
                    Direccion = persona.direccion
                    ,
                    Tipo_empleado = persona.tipo_empleado
                    ,
                    Departamento = persona.departamento
                    ,
                    Pass = persona.pass

                });
            }

            return destinoListaPersona;
        }

        //AutoClientes

        public void EliminarAutoCliente(int id)
        {
            autoclienteOperaciones.Eliminar(id);
        }

        public void InsertarAutoCliente(AutoClienteDTO cliente)
        {
            Auto_Cliente destino = new Auto_Cliente();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AutoClienteDTO, Auto_Cliente>());
            var mapper = config.CreateMapper();

            destino = mapper.Map<Auto_Cliente>(cliente);
            autoclienteOperaciones.Insertar(destino);
        }

        public void ModificarAutoCliente(AutoClienteDTO cliente)
        {
            Auto_Cliente destino = new Auto_Cliente();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AutoClienteDTO, Auto_Cliente>());
            var mapper = config.CreateMapper();

            destino = mapper.Map<Auto_Cliente>(cliente);
            autoclienteOperaciones.Modificar(destino);
        }

        public AutoClienteDTO ObtenerAutoClienteID(int id)
        {

            Auto_Cliente origencliente = autoclienteOperaciones.ObtenerId(id);
            AutoClienteDTO destinodto = new AutoClienteDTO();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Auto_Cliente, AutoClienteDTO>());
            var mapper = config.CreateMapper();

            destinodto = mapper.Map<AutoClienteDTO>(origencliente);

            destinodto.Cedula = origencliente.cedula;

            return destinodto;
        }

        public AutoClienteDTO.ListaAutoCliente ObtenerTodosAutoClientes()
        {
            List<Auto_Cliente> listaCliente = autoclienteOperaciones.ObtenerTodos();
            AutoClienteDTO.ListaAutoCliente destinoListaCleinte = new AutoClienteDTO.ListaAutoCliente();
            destinoListaCleinte.lista = new List<AutoClienteDTO>();
            foreach (Auto_Cliente cleinte in listaCliente)
            {
                destinoListaCleinte.lista.Add(new AutoClienteDTO()
                {
                    ID_Auto_Cliente = cleinte.ID_Auto_Cliente
                    ,
                    Cedula = cleinte.cedula
                    ,
                    Placa = cleinte.placa

                });
            }

            return destinoListaCleinte;
        }

        //Servicios

        public void EliminarServicio(int id)
        {
            serviciosOperaciones.Eliminar(id);
        }

        public void InsertarServicio(ServiciosDTO servicio)
        {
            Servicios destino = new Servicios();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiciosDTO, Servicios>());
            var mapper = config.CreateMapper();

            destino = mapper.Map<Servicios>(servicio);
            serviciosOperaciones.Insertar(destino);
        }

        public void ModificarServicio(ServiciosDTO servicios)
        {
            Servicios destino = new Servicios();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiciosDTO, Servicios>());
            var mapper = config.CreateMapper();

            destino = mapper.Map<Servicios>(servicios);
            serviciosOperaciones.Modificar(destino);
        }

        public ServiciosDTO ObtenerServicioID(int id)
        {

            Servicios origenservicio = serviciosOperaciones.ObtenerId(id);
            ServiciosDTO destinodto = new ServiciosDTO();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Servicios, ServiciosDTO>());
            var mapper = config.CreateMapper();

            destinodto = mapper.Map<ServiciosDTO>(origenservicio);

            destinodto.ID_servicio = origenservicio.ID_servicio;

            return destinodto;
        }

        public ServiciosDTO.ListaServicios ObtenerTodosServicio()
        {
            List<Servicios> listaServicios = serviciosOperaciones.ObtenerTodos();
            ServiciosDTO.ListaServicios destinoListaServicios = new ServiciosDTO.ListaServicios();
            destinoListaServicios.lista = new List<ServiciosDTO>();
            foreach (Servicios srv in listaServicios)
            {
                destinoListaServicios.lista.Add(new ServiciosDTO()
                {
                    ID_servicio = srv.ID_servicio
                    ,
                    ID_tipo_servicio = srv.ID_tipo_servicio
                    ,
                    Fecha = srv.fecha
                    ,
                    Descripcion_servicio = srv.descripcion_servicio
                    ,
                    Cedula = srv.cedula
                    ,
                    Placa = srv.placa
                    ,
                    Servicio_seleccionado = srv.servicio_seleccionado
                });
            }

            return destinoListaServicios;
        }

        //Servicios Cliente

        public void EliminarServicioCliente(int id)
        {
            servicioClienteOp.Eliminar(id);
        }

        public void InsertarServicioCliente(ServiciosClienteDTO servicio)
        {
            Servicios_Cliente destino = new Servicios_Cliente();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiciosClienteDTO, Servicios_Cliente>());
            var mapper = config.CreateMapper();

            destino = mapper.Map<Servicios_Cliente>(servicio);
            servicioClienteOp.Insertar(destino);
        }

        public void ModificarServicioCliente(ServiciosClienteDTO servicios)
        {
            Servicios_Cliente destino = new Servicios_Cliente();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiciosClienteDTO, Servicios_Cliente>());
            var mapper = config.CreateMapper();

            destino = mapper.Map<Servicios_Cliente>(servicios);
            servicioClienteOp.Modificar(destino);
        }

        public ServiciosClienteDTO ObtenerServicioClienteID(int id)
        {

            Servicios_Cliente origenservicio = servicioClienteOp.ObtenerId(id);
            ServiciosClienteDTO destinodto = new ServiciosClienteDTO();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Servicios_Cliente, ServiciosClienteDTO>());
            var mapper = config.CreateMapper();

            destinodto = mapper.Map<ServiciosClienteDTO>(origenservicio);

            destinodto.ID_Servicio_Cliente = origenservicio.ID_Servicio_Cliente;

            return destinodto;
        }

        public ServiciosClienteDTO.ListaServiciosCliente ObtenerTodosServicioCliente()
        {
            List<Servicios_Cliente> listaServicios = servicioClienteOp.ObtenerTodos();
            ServiciosClienteDTO.ListaServiciosCliente destinoListaServicios = new ServiciosClienteDTO.ListaServiciosCliente();
            destinoListaServicios.lista = new List<ServiciosClienteDTO>();
            foreach (Servicios_Cliente srv in listaServicios)
            {
                destinoListaServicios.lista.Add(new ServiciosClienteDTO()
                {
                    ID_Servicio_Cliente = srv.ID_Servicio_Cliente
                    ,
                    Cedula = srv.cedula
                    ,
                    Placa = srv.placa
                    ,
                    Servicio_Seleccionado = srv.Servicio_Seleccionado
                });
            }

            return destinoListaServicios;
        }

        //Automotores

        public void EliminarAutomotor(int id)
        {
            automotoresOperaciones.Eliminar(id);
        }

        public void InsertarAutomotor(AutomotoresDTO automotor)
        {
            Automotores destino = new Automotores();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AutomotoresDTO, Automotores>());
            var mapper = config.CreateMapper();

            destino = mapper.Map<Automotores>(automotor);
            automotoresOperaciones.Insertar(destino);
        }

        public void ModificarAutomotor(AutomotoresDTO automotor)
        {
            Automotores destino = new Automotores();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<AutomotoresDTO, Automotores>());
            var mapper = config.CreateMapper();

            destino = mapper.Map<Automotores>(automotor);
            automotoresOperaciones.Modificar(destino);
        }

        public AutomotoresDTO ObtenerAutomotorID(int id)//esta variable la cambie de int a string y la volvi a int
        {

            Automotores origenservicio = automotoresOperaciones.ObtenerId(id);
            AutomotoresDTO destinodto = new AutomotoresDTO();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Automotores, AutomotoresDTO>());
            var mapper = config.CreateMapper();

            destinodto = mapper.Map<AutomotoresDTO>(origenservicio);

            destinodto.ID_automotor = origenservicio.ID_automotor;

            return destinodto;
        }

        public AutomotoresDTO.ListaAutomotores ObtenerTodosAutomotores()
        {
            List<Automotores> listaAutomotores = automotoresOperaciones.ObtenerTodos();
            AutomotoresDTO.ListaAutomotores destinoListaServicios = new AutomotoresDTO.ListaAutomotores();
            destinoListaServicios.lista = new List<AutomotoresDTO>();
            foreach (Automotores srv in listaAutomotores)
            {
                destinoListaServicios.lista.Add(new AutomotoresDTO()
                {
                    ID_automotor = srv.ID_automotor
                    ,
                    Placa = srv.placa
                    ,
                    Marca = srv.marca
                    ,
                    Modelo = srv.modelo
                    ,
                    Tipo_combustible = srv.tipo_combustible
                    ,
                    Cilindraje = srv.cilindraje
                    ,
                    EsTransPublico = srv.esTransPublico
                    ,
                    EsManual = srv.esManual
                    ,
                    EsTransEspe = srv.esTransEspe
                    ,
                    Tiene_contenedor = srv.tiene_contenedor
                    ,
                    EsMensajero = srv.esMensajero
                    ,
                    EsClasica = srv.esClasica
                    ,
                    Tipo_vehiculo = srv.tipo_vehiculo

                });
            }

            return destinoListaServicios;
        }

        //Tipos de Servicio

        public void EliminarTipoServicio(int id)
        {
            tipoServicioOperaciones.EliminarTipoServicios(id);
        }

        public void InsertarTipoServicio(TipoServicioDTO tipoSrv)
        {
            TipoServicio destino = new TipoServicio();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<TipoServicioDTO, TipoServicio>());
            var mapper = config.CreateMapper();

            destino = mapper.Map<TipoServicio>(tipoSrv);
            tipoServicioOperaciones.InsertarTipoServicios(destino);
        }

        public void ModificarTipoServicio(TipoServicioDTO tipoSrv)
        {
            TipoServicio destino = new TipoServicio();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<TipoServicioDTO, TipoServicio>());
            var mapper = config.CreateMapper();

            destino = mapper.Map<TipoServicio>(tipoSrv);
            tipoServicioOperaciones.ModificarTipoServicios(destino);
        }

        public TipoServicioDTO ObtenerTipoServicioID(int id)
        {

            TipoServicio origenservicio = tipoServicioOperaciones.ObtenerTipoServiciosID(id);
            TipoServicioDTO destinodto = new TipoServicioDTO();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TipoServicio, TipoServicioDTO>());
            var mapper = config.CreateMapper();

            destinodto = mapper.Map<TipoServicioDTO>(origenservicio);

            destinodto.ID_tipo_servicio = origenservicio.ID_tipo_servicio; // aca pedia la placa ??

            return destinodto;
        }

        public TipoServicioDTO.ListaTipoServicios ObtenerTodosTipoServicio()
        {
            List<TipoServicio> listaTipoServicio = tipoServicioOperaciones.ObtenerTodosTipoServicios();
            TipoServicioDTO.ListaTipoServicios destinoListaTipoServicios = new TipoServicioDTO.ListaTipoServicios();
            destinoListaTipoServicios.lista = new List<TipoServicioDTO>();
            foreach (TipoServicio srv in listaTipoServicio)
            {
                destinoListaTipoServicios.lista.Add(new TipoServicioDTO()
                {
                    ID_tipo_servicio = srv.ID_tipo_servicio
                    ,
                    Descripcion_servicio = srv.descripcion_servicio

                });
            }

            return destinoListaTipoServicios;
        }

    }
}
