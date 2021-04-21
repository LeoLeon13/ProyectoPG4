using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Final_PG4.Entidades
{
    public class Servicios_Cliente
    {
        [Key]
        public int ID_Servicio_Cliente { get; set; }

        //[MaxLength(30)]
        //public string ID_Cliente { get; set; }
        [MaxLength(40)]
        public string cedula { get; set; }

        [MaxLength(7)]
        public string placa { get; set; }

        [MaxLength(100)]
        public string Servicio_Seleccionado { get; set; }
    }
}
