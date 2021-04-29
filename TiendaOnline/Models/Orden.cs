using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOnline.Models
{
    public class Orden
    {

        public Orden()
        {
            OrdenDetalles = new List<OrdenDetalles>();
        }

        public int ID { get; set; }
        [Display(Name ="Numero de Orden")]
        public string numeroOrden { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Display(Name = "Numero de Teléfono")]
        [Required]
        public string  numeroTel { get; set; }
        public string Estado { get; set; }
        [Required]
        [EmailAddress]
        public string Correo { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Display(Name = "Dirección")]
        [Required]
        public string Direccion { get; set; }
        [Display(Name = "Latitud")]
        [Required]
        public string Lat { get; set; }
        [Display(Name = "Longitud")]
        [Required]
        public string Long { get; set; }
        public virtual List<OrdenDetalles> OrdenDetalles { get; set; }

    }
}
