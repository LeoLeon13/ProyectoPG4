using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Projecto_Final_PG4.ComunicacionSApp
{
    [DataContract]
    public class TipoServicioDTO
    {
        //Atributos
        private int ID_tipo_servicio;
        private string descripcion_servicio;

        //Propiedades
        [DataMember]
        public int ID_tipo_servicio1 { get => ID_tipo_servicio; set => ID_tipo_servicio = value; }
        [DataMember]
        public string Descripcion_servicio { get => descripcion_servicio; set => descripcion_servicio = value; }
    }
}