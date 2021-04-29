using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOnline.Areas.Admin.Models
{
    public class RoleUsesrVm
    {
        [Required]
        [Display(Name = "Usuario")]
        public string UserID { get; set; }
        [Required]
        [Display(Name = "Rol")]
        public string RoleID { get; set; }
    }
}
