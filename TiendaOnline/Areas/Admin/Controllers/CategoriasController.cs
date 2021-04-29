using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaOnline.Data;
using TiendaOnline.Models;
using TiendaOnline.Utilidades;

namespace TiendaOnline.Areas.Admin.Controllers
{
    
    [Area("Admin")]

    public class CategoriasController : Controller
    {

        private ApplicationDbContext _db;

        public CategoriasController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Ropas()
        {
            return View(_db.Productos.Include(c => c.CategoriaProductos).Where(c => c.CategoriaProductos.nombreCategoria == "Ropas").ToList());
        }

        public IActionResult Calzados()
        {
            return View(_db.Productos.Include(c => c.CategoriaProductos).Where(c => c.CategoriaProductos.nombreCategoria == "Calzados").ToList());
        }

        public IActionResult Tecnologia()
        {
            return View(_db.Productos.Include(c => c.CategoriaProductos).Where(c => c.CategoriaProductos.nombreCategoria == "Tecnologia").ToList());
        }

        public IActionResult Deportes()
        {
            return View(_db.Productos.Include(c => c.CategoriaProductos).Where(c => c.CategoriaProductos.nombreCategoria == "Deportes").ToList());
        }

        public IActionResult SaludBelleza()
        {
            return View(_db.Productos.Include(c => c.CategoriaProductos).Where(c => c.CategoriaProductos.nombreCategoria == "SaludBelleza").ToList());
        }

        public IActionResult Hogar()
        {
            return View(_db.Productos.Include(c => c.CategoriaProductos).Where(c => c.CategoriaProductos.nombreCategoria == "Hogar").ToList());
        }

        public IActionResult RepuestosAccesorios()
        {
            return View(_db.Productos.Include(c => c.CategoriaProductos).Where(c => c.CategoriaProductos.nombreCategoria == "RepuestosAccesorios").ToList());
        }

        public IActionResult Videojuegos()
        {
            return View(_db.Productos.Include(c => c.CategoriaProductos).Where(c => c.CategoriaProductos.nombreCategoria == "Videojuegos").ToList());
        }

        public IActionResult Bebes()
        {
            return View(_db.Productos.Include(c => c.CategoriaProductos).Where(c => c.CategoriaProductos.nombreCategoria == "Bebes").ToList());
        }

        public IActionResult Musica()
        {
            return View(_db.Productos.Include(c => c.CategoriaProductos).Where(c => c.CategoriaProductos.nombreCategoria == "Musica").ToList());
        }





        public ActionResult Detail(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var producto = _db.Productos.Include(c => c.CategoriaProductos).FirstOrDefault(c => c.ID == id);

            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }


        //Post Detalles de Producto
        [HttpPost]
        [ActionName("Detail")]
        public ActionResult ProductoDetail(int? id)
        {

            List<Productos> productos = new List<Productos>();

            if (id == null)
            {
                return NotFound();
            }

            var producto = _db.Productos.Include(c => c.CategoriaProductos).FirstOrDefault(c => c.ID == id);

            if (producto == null)
            {
                return NotFound();
            }


            productos = HttpContext.Session.Get<List<Productos>>("productos");
            if (productos == null)
            {
                productos = new List<Productos>();
            }
            productos.Add(producto);
            HttpContext.Session.Set("productos", productos);
            return View(producto);
        }

    }
}