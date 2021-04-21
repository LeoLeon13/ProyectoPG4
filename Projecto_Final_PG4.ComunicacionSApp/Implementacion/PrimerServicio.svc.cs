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

        public void EliminarPersona(int id)
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

        public PersonaDTO.ListaPersonas ObtenerTodos()
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

        public AutoClienteDTO.ListaAutoCliente ObtenerTodosClientes()
        {
            List<Auto_Cliente> listaCliente = autoclienteOperaciones.ObtenerTodos();
            AutoClienteDTO.ListaAutoCliente destinoListaCleinte = new AutoClienteDTO.ListaAutoCliente();
            destinoListaCleinte.lista = new List<AutoClienteDTO>();
            foreach (Auto_Cliente cleinte in listaCliente)
            {
                destinoListaCleinte.lista.Add(new AutoClienteDTO()
                {
                    ID_Auto_Cliente1 = cleinte.ID_Auto_Cliente
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

            destinodto.Placa = origenservicio.placa;

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
                    ID_servicio1 = srv.ID_servicio
                    ,
                    ID_tipo_servicio1 = srv.ID_tipo_servicio
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

    }
}
