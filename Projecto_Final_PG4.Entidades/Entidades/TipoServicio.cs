using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Final_PG4.Entidades
{
    public class TipoServicio
    {
        [Key]
        public int ID_tipo_servicio { get; set; }

        [MaxLength(100)]
        public string descripcion_servicio { get; set; }
    }
}
