using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Final_PG4.Entidades
{
    public class Login
    {
        [Key]
        public string cedula { get; set; }

        [MaxLength(10)]
        public string password { get; set; }

        [MaxLength(1)]
        public string perfil { get; set; }
    }
}
