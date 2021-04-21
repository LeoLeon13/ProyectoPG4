using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Final_PG4.Entidades
{
    public class Auto_Cliente
    {
        [Key]
        public int ID_Auto_Cliente { get; set; }

        [MaxLength(15)]
        public string cedula { get; set; }

        [MaxLength(7)]
        public string placa { get; set; }
    }
}
