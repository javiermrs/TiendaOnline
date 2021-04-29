using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TiendaOnline.Data;
using TiendaOnline.Models;
using TiendaOnline.Utilidades;

namespace TiendaOnline.Areas.Cliente.Controllers
{
    [Area("Cliente")]

    public class OrdenController : Controller
    {

        ApplicationDbContext _db;
        SignInManager<IdentityUser> _SignInManager;

        public OrdenController(ApplicationDbContext db, SignInManager<IdentityUser> SignInManager)
        {
            _db = db;
            _SignInManager = SignInManager;
        }


        [Authorize]
        public IActionResult ConsultarOrdenes()
        {

            if (_SignInManager.IsSignedIn(User))
            {

                string email = User.Identity.Name;
                return View(_db.Orden.Where(c => c.Correo == email).ToList());
            }
            return View();

        }


        //Checkout Action Method

        public IActionResult Checkout()
        {
            return View();
        }

        //Post Checkout
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Checkout(Orden ord)
        {

            List<Productos> productos = HttpContext.Session.Get<List<Productos>>("productos");
            if (productos != null)
            {
                foreach(var producto in productos)
                {
                    OrdenDetalles ordenDetalles = new OrdenDetalles();
                    ordenDetalles.ProductoID = producto.ID;
                    ord.OrdenDetalles.Add(ordenDetalles);
                }
            }

            if (_SignInManager.IsSignedIn(User))
            {
                ord.Correo = User.Identity.Name;
            }
            ord.numeroOrden = obtenerNumeroOrden();
            ord.Estado = "En proceso";
            _db.Orden.Add(ord);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("productos", new List<Productos>());

            return View();
        }

        public string obtenerNumeroOrden()
        {//Count () + 1
            int conteoFila = _db.Orden.ToList().Count() + 1;
            return conteoFila.ToString("000");
        }



        public IActionResult Index()
        {
            return View(_db.Orden.ToList());
        }

        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var ordenes = _db.Orden.Find(id);
            if (ordenes == null)
            {
                return NotFound();
            }

            return View(ordenes);
        }

        //Crear el metodo Post Editar

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(Orden ordenes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ordenes);
                await _db.SaveChangesAsync();
                TempData["editar"] = "La orden se actualizó correctamente!";
                return RedirectToAction(nameof(Index));
            }
            return View(ordenes);
        }


        [HttpGet]
        public IActionResult Mapa()
        {
            return View(_db.Orden.ToList());
        }

        [HttpPost]
        public IActionResult Mapa(string estado)
        {
            ViewData["Estado"] = estado;
            return View(_db.Orden.ToList());
        }


        
    }
}