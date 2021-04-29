using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaOnline.Data;

namespace TiendaOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GestorClientesController : Controller
    {
        UserManager<IdentityUser> userManager;
        ApplicationDbContext _db;
        public GestorClientesController(UserManager<IdentityUser> _userManager, ApplicationDbContext db)
        {
            userManager = _userManager;
            _db = db;
        }

        public IActionResult Index()
        {

            return View(_db.ApplicationUsers.ToList());


        }

        public IActionResult VisualizarCompras(string id)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);

            var product = _db.Carrito.Include(c => c.Producto).Where(c => c.email == user.UserName).ToList();
            return View(product);
        }
    }
}