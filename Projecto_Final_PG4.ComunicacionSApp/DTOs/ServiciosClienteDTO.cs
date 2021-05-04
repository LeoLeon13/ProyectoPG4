using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Projecto_Final_PG4.ComunicacionSApp
{
    [DataContract]
    public class ServiciosClienteDTO
    {
        //Atributos
        private int id_servicio_cliente;
        private string cedula;
        private string placa;
        private string servicio_seleccionado;

        //Propiedades
        [DataMember]
        public int ID_Servicio_Cliente { get => id_servicio_cliente; set => id_servicio_cliente = value; }
        [DataMember]
        public string Cedula { get => cedula; set => cedula = value; }
        [DataMember]
        public string Placa { get => placa; set => placa = value; }
        [DataMember]
        public string Servicio_Seleccionado { get => servicio_seleccionado; set => servicio_seleccionado = value; }

        [DataContract]
        public class ListaServiciosCliente
        {
            [DataMember]
            public List<ServiciosClienteDTO> lista;

        }
    }
}