using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Projecto_Final_PG4.ComunicacionSApp
{
    [DataContract]
    public class AutoClienteDTO
    {
        //Atributos
        private int Id_Auto_Cliente;
        private string cedula;
        private string placa;

        //Propiedades
        [DataMember]
        public int ID_Auto_Cliente { get => Id_Auto_Cliente; set => Id_Auto_Cliente = value; }
        [DataMember]
        public string Cedula { get => cedula; set => cedula = value; }
        [DataMember]
        public string Placa { get => placa; set => placa = value; }

        [DataContract]
        public class ListaAutoCliente
        {
            [DataMember]
            public List<AutoClienteDTO> lista;

        }
    }
}