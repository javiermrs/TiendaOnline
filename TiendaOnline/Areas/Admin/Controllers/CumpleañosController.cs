using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TiendaOnline.Data;

namespace TiendaOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CumpleañosController : Controller
    {

        ApplicationDbContext _db;

        public CumpleañosController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Enero()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 01).ToList());
        }
        public IActionResult Febrero()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 02).ToList());
        }
        public IActionResult Marzo()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 03).ToList());
        }
        public IActionResult Abril()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 04).ToList());
        }
        public IActionResult Mayo()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 05).ToList());
        }
        public IActionResult Junio()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 06).ToList());
        }
        public IActionResult Julio()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 07).ToList());
        }
        public IActionResult Agosto()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 08).ToList());
        }
        public IActionResult Septiembre()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 09).ToList());
        }
        public IActionResult Octubre()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 10).ToList());
        }
        public IActionResult Noviembre()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 11).ToList());
        }
        public IActionResult Diciembre()
        {
            return View(_db.ApplicationUsers.Where(c=>c.fechaNacimiento.Month == 12).ToList());
        }
    }
}