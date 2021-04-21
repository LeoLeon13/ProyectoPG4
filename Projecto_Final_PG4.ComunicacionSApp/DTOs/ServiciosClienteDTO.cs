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
        private int ID_Servicio_Cliente;
        private string ID_Cliente;
        private string placa;
        private string Servicio_Seleccionado;

        //Propiedades
        [DataMember]
        public int ID_Servicio_Cliente1 { get => ID_Servicio_Cliente; set => ID_Servicio_Cliente = value; }
        [DataMember]
        public string ID_Cliente1 { get => ID_Cliente; set => ID_Cliente = value; }
        [DataMember]
        public string Placa { get => placa; set => placa = value; }
        [DataMember]
        public string Servicio_Seleccionado1 { get => Servicio_Seleccionado; set => Servicio_Seleccionado = value; }
    }
}