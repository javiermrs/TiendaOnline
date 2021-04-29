using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOnline.Models
{
    public class CategoriaProductos
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Categoria del Producto")]
        public string nombreCategoria { get; set; }
    }
}
