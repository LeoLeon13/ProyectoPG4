using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Projecto_Final_PG4.ComunicacionSApp
{
    [DataContract]
    public class ServiciosDTO
    {
        //Atributos
        private int ID_servicio;
        private int ID_tipo_servicio;
        private DateTime fecha;
        private string descripcion_servicio;
        private string cedula;
        private string placa;
        private string servicio_seleccionado;

        //Propiedades
        [DataMember]
        public int ID_servicio1 { get => ID_servicio; set => ID_servicio = value; }
        [DataMember]
        public int ID_tipo_servicio1 { get => ID_tipo_servicio; set => ID_tipo_servicio = value; }
        [DataMember]
        public DateTime Fecha { get => fecha; set => fecha = value; }
        [DataMember]
        public string Descripcion_servicio { get => descripcion_servicio; set => descripcion_servicio = value; }
        [DataMember]
        public string Cedula { get => cedula; set => cedula = value; }
        [DataMember]
        public string Placa { get => placa; set => placa = value; }
        [DataMember]
        public string Servicio_seleccionado { get => servicio_seleccionado; set => servicio_seleccionado = value; }

        [DataContract]
        public class ListaServicios
        {
            [DataMember]
            public List<ServiciosDTO> lista;

        }
    }
}