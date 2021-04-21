using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Projecto_Final_PG4.ComunicacionSApp
{
    [DataContract]
    public class LoginDTO
    {
        //Atributos
        private string cedula;
        private string password;
        private string perfil;

        //Propiedades
        [DataMember]
        public string Cedula { get => cedula; set => cedula = value; }
        [DataMember]
        public string Password { get => password; set => password = value; }
        [DataMember]
        public string Perfil { get => perfil; set => perfil = value; }
    }
}