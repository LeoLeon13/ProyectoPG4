using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Final_PG4.Entidades
{
    public class Servicios
    {
        #region variables
        //publicas

        //privadas
        [Key]
        public int ID_servicio { get; set; }

        
        public int ID_tipo_servicio { get; set; }


        public DateTime fecha { get; set; }

        [MaxLength(120)]
        public string descripcion_servicio { get; set; }


        //public int ID_cliente { get; set; }
        [MaxLength(40)]
        public string cedula { get; set; }

        [MaxLength(6)]
        public string placa { get; set; }

        [MaxLength(50)]
        public string servicio_seleccionado { get; set; }

        #endregion
    }
}
