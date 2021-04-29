using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOnline.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Fecha de Nacimiento")]
        [Required (ErrorMessage = "Debe ingresar una fecha de nacimiento")]
        public DateTime fechaNacimiento { get; set; }
    }
}
