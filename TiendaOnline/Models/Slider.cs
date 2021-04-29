using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TiendaOnline.ViewModels;

namespace TiendaOnline.Models
{
    public class Slider
    {
        [Key]
        public int ID { get; set; }

        public string image{ get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
