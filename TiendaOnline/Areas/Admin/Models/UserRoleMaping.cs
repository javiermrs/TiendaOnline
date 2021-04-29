using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOnline.Areas.Admin.Models
{
    public class UserRoleMaping
    {
        public string UserID { get; set; }
        public string RoleID { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
    }
}
