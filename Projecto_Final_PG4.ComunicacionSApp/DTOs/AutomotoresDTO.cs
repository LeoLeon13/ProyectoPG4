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
        private int ID_automotor;
        private string placa;
        private string marca;
        private string modelo;
        private string tipo_combustible;
        private int cilindraje;
        private char esTransprivateo;
        private char esManual;
        private char esTransEspe;        
        private char tiene_contenedor;        
        private char esMensajero;        
        private char esClasica;
        private string tipo_vehiculo;

        //Propiedades
        [DataMember]
        public int ID_automotor1 { get => ID_automotor; set => ID_automotor = value; }
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
        public char EsTransprivateo { get => esTransprivateo; set => esTransprivateo = value; }
        [DataMember]
        public char EsManual { get => esManual; set => esManual = value; }
        [DataMember]
        public char EsTransEspe { get => esTransEspe; set => esTransEspe = value; }
        [DataMember]
        public char Tiene_contenedor { get => tiene_contenedor; set => tiene_contenedor = value; }
        [DataMember]
        public char EsMensajero { get => esMensajero; set => esMensajero = value; }
        [DataMember]
        public char EsClasica { get => esClasica; set => esClasica = value; }
        [DataMember]
        public string Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }
    }
}