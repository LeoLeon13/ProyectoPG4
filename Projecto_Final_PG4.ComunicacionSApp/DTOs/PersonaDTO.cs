using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Projecto_Final_PG4.ComunicacionSApp
{
    [DataContract]
    public class PersonaDTO
    {
        //Atributos
        private int Id_persona;
        private string cedula;
        private string nombre;
        private string apellido;
        private string correo;
        private int celular;
        private string esEmpleado;
        private int telefono;
        private string direccion;
        private string tipo_empleado;
        private string departamento;
        private string pass;

        //Propiedades
        [DataMember]
        public int ID_persona { get => Id_persona; set => Id_persona = value; }
        [DataMember]
        public string Cedula { get => cedula; set => cedula = value; }
        [DataMember]
        public string Nombre { get => nombre; set => nombre = value; }
        [DataMember]
        public string Apellido { get => apellido; set => apellido = value; }
        [DataMember]
        public string Correo { get => correo; set => correo = value; }
        [DataMember]
        public int Celular { get => celular; set => celular = value; }
        [DataMember]
        public string EsEmpleado { get => esEmpleado; set => esEmpleado = value; }
        [DataMember]
        public int Telefono { get => telefono; set => telefono = value; }
        [DataMember]
        public string Direccion { get => direccion; set => direccion = value; }
        [DataMember]
        public string Tipo_empleado { get => tipo_empleado; set => tipo_empleado = value; }
        [DataMember]
        public string Departamento { get => departamento; set => departamento = value; }
        [DataMember]
        public string Pass { get => pass; set => pass = value; }

        [DataContract]
        public class ListaPersonas
        {
            [DataMember]
            public List<PersonaDTO> lista;

        }
    }
}