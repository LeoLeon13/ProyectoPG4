using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Final_PG4.Entidades
{
    public class Persona
    {
        public int ID_persona { get; set; }

        [Key]
        public string cedula { get; set; }

        [MaxLength(50)]
        public string nombre { get; set; }

        [MaxLength(50)]
        public string apellido { get; set; }

        [MaxLength(50)]
        public string correo { get; set; }

        public int celular { get; set; }

        [MaxLength(1)]
        public string esEmpleado { get; set; }

        public int telefono { get; set; }

        [MaxLength(80)]
        public string direccion { get; set; }

        [MaxLength(100)]
        public string tipo_empleado { get; set; }

        [MaxLength(50)]
        public string departamento { get; set; }

        [MaxLength(16)]
        public string pass { get; set; }

        //public ICollection<Persona> Direcciones { get; set; }

    }
}
