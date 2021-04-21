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
        void EliminarPersona(int id);
        [OperationContract]
        PersonaDTO ObtenerPersonaID(string id); //cambie esta variable de int a string 

        [OperationContract]
        ListaPersonas ObtenerTodos();

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
        ListaAutoCliente ObtenerTodosClientes();

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
    }
}
