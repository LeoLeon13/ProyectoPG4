using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Projecto_Final_PG4.Entidades;
using static Projecto_Final_PG4.ComunicacionSApp.AutoClienteDTO;
using static Projecto_Final_PG4.ComunicacionSApp.PersonaDTO;
using static Projecto_Final_PG4.ComunicacionSApp.ServiciosDTO;
using static Projecto_Final_PG4.ComunicacionSApp.TipoServicioDTO;
using static Projecto_Final_PG4.ComunicacionSApp.ServiciosClienteDTO;
using static Projecto_Final_PG4.ComunicacionSApp.AutomotoresDTO;

namespace Projecto_Final_PG4.ComunicacionSApp
{
    [ServiceContract]
    interface IPrimerServicio
    {
        [OperationContract]
        void InsertarPersona(PersonaDTO persona);
        [OperationContract]
        void ModificarPersona(PersonaDTO persona);
        [OperationContract]
        void EliminarPersona(string id);
        [OperationContract]
        PersonaDTO ObtenerPersonaID(string id); //cambie esta variable de int a string 

        [OperationContract]
        ListaPersonas ObtenerTodosPersona();

        //AutoCliente
        [OperationContract]
        void InsertarAutoCliente(AutoClienteDTO cliente);
        [OperationContract]
        void ModificarAutoCliente(AutoClienteDTO cleinte);
        [OperationContract]
        void EliminarAutoCliente(int id);
        [OperationContract]
        AutoClienteDTO ObtenerAutoClienteID(int id);

        [OperationContract]
        ListaAutoCliente ObtenerTodosAutoClientes();

        //Servicios
        [OperationContract]
        void InsertarServicio(ServiciosDTO servicio);
        [OperationContract]
        void ModificarServicio(ServiciosDTO servicio);
        [OperationContract]
        void EliminarServicio(int id);
        [OperationContract]
        ServiciosDTO ObtenerServicioID(int id);

        [OperationContract]
        ListaServicios ObtenerTodosServicio();

        //Servicios Cliente
        [OperationContract]
        void InsertarServicioCliente(ServiciosClienteDTO servicio);
        [OperationContract]
        void ModificarServicioCliente(ServiciosClienteDTO servicio);
        [OperationContract]
        void EliminarServicioCliente(int id);
        [OperationContract]
        ServiciosClienteDTO ObtenerServicioClienteID(int id);

        [OperationContract]
        ListaServiciosCliente ObtenerTodosServicioCliente();

        //Automotores
        [OperationContract]
        void InsertarAutomotor(AutomotoresDTO automotor);
        [OperationContract]
        void ModificarAutomotor(AutomotoresDTO automotor);
        [OperationContract]
        void EliminarAutomotor(int id);
        [OperationContract]
        AutomotoresDTO ObtenerAutomotorID(int id);//esta variable la cambie de int a string y la devolvi a int

        [OperationContract]
        ListaAutomotores ObtenerTodosAutomotores();

        //Tipos de Servicios
        [OperationContract]
        void InsertarTipoServicio(TipoServicioDTO tipoSrv);
        [OperationContract]
        void ModificarTipoServicio(TipoServicioDTO tipoSrv);
        [OperationContract]
        void EliminarTipoServicio(int id);
        [OperationContract]
        TipoServicioDTO ObtenerTipoServicioID(int id);

        [OperationContract]
        ListaTipoServicios ObtenerTodosTipoServicio();
    }
}
