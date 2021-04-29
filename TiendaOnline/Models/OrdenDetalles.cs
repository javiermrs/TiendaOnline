using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOnline.Models
{
    public class OrdenDetalles
    {
        public int ID { get; set; }

        [Display(Name ="Orden")]
        public int OrdenID { get; set; }

        [Display(Name = "Producto")]
        public int ProductoID { get; set; }

        [ForeignKey("OrdenID")]
        public Orden Orden { get; set; }

        [ForeignKey("ProductoID")]
        public Productos Productos { get; set; }

    }
}
