using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOnline.Models
{
    public class Productos
    {
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }

        [Required]
        public double Precio { get; set; }

        public string Imagen { get; set; }
        [Required]
        public bool Disponibilidad { get; set; }
        [Required]
        public string Detalles { get; set; }

        [Display(Name = "Categoria del Producto")]
        [Required]
        public int CategoriaProductoId { get; set; }

        [ForeignKey("CategoriaProductoId")]
        public CategoriaProductos CategoriaProductos { get; set; }


    }
}
