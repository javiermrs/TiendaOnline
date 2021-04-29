using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOnline.ViewModels
{
    public class SliderViewModel
    {
        [Required(ErrorMessage = "Por favor agregue la Foto del Slider.")]
        public IFormFile SliderImagen { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
