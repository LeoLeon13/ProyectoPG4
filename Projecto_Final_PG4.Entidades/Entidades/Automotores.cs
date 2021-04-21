using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Final_PG4.Entidades
{
    public class Automotores
    {
        #region variables
        //publicas

        //privadas
        [Key]
        public int ID_automotor { get; set; }

        [MaxLength(6)]
        public string placa { get; set; }

        [MaxLength(50)]
        public string marca { get; set; }

        [MaxLength(50)]
        public string modelo { get; set; }

        [MaxLength(30)]
        public string tipo_combustible { get; set; }

        public int cilindraje { get; set; }

        [MaxLength(1)]
        public char esTransPublico { get; set; }

        [MaxLength(1)]
        public char esManual { get; set; }

        [MaxLength(1)]
        public char esTransEspe { get; set; }

        [MaxLength(1)]
        public char tiene_contenedor { get; set; }

        [MaxLength(1)]
        public char esMensajero { get; set; }

        [MaxLength(1)]
        public char esClasica { get; set; }

        [MaxLength(50)]
        public string tipo_vehiculo { get; set; }

        #endregion
    }
}
