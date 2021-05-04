using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Projecto_Final_PG4.ComunicacionSApp
{
    [DataContract]
    public class AutomotoresDTO
    {
        //Atributos
        private int Id_automotor;
        private string placa;
        private string marca;
        private string modelo;
        private string tipo_combustible;
        private int cilindraje;
        private string esTransPublico;
        private string esManual;
        private string esTransEspe;
        private string tiene_contenedor;
        private string esMensajero;
        private string esClasica;
        private string tipo_vehiculo;

        //Propiedades
        [DataMember]
        public int ID_automotor { get => Id_automotor; set => Id_automotor = value; }
        [DataMember]
        public string Placa { get => placa; set => placa = value; }
        [DataMember]
        public string Marca { get => marca; set => marca = value; }
        [DataMember]
        public string Modelo { get => modelo; set => modelo = value; }
        [DataMember]
        public string Tipo_combustible { get => tipo_combustible; set => tipo_combustible = value; }
        [DataMember]
        public int Cilindraje { get => cilindraje; set => cilindraje = value; }
        [DataMember]
        public string EsTransPublico { get => esTransPublico; set => esTransPublico = value; }
        [DataMember]
        public string EsManual { get => esManual; set => esManual = value; }
        [DataMember]
        public string EsTransEspe { get => esTransEspe; set => esTransEspe = value; }
        [DataMember]
        public string Tiene_contenedor { get => tiene_contenedor; set => tiene_contenedor = value; }
        [DataMember]
        public string EsMensajero { get => esMensajero; set => esMensajero = value; }
        [DataMember]
        public string EsClasica { get => esClasica; set => esClasica = value; }
        [DataMember]
        public string Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }

        [DataContract]
        public class ListaAutomotores
        {
            [DataMember]
            public List<AutomotoresDTO> lista;

        }
    }
}