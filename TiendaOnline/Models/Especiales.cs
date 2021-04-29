using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOnline.Models
{
    public class Especiales
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
    }
}
