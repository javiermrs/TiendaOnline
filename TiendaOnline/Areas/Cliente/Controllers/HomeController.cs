using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaOnline.Data;
using TiendaOnline.Models;
using TiendaOnline.Utilidades;
using X.PagedList;

namespace TiendaOnline.Controllers
{

    [Area("Cliente")]

    public class HomeController : Controller
    {

        private ApplicationDbContext _db;

        public HomeController (ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(/*int? page*/)
        {
            ProductosSlider ps = new ProductosSlider();
            ps.productos = _db.Productos.ToList();
            ps.sliders = _db.Slider.ToList();
            return View(ps);
           // return View(_db.Productos.Include(c=>c.CategoriaProductos).ToList().ToPagedList(page??1, 6));

        }
        public async Task<IActionResult> Resultados(string busqueda)
        {

            ViewData["FILTRO"] = busqueda;
            var productos = from s in _db.Productos select s;
            if (!String.IsNullOrEmpty(busqueda))
            {
                productos = productos.Where(s => s.Nombre.Contains(busqueda));

                if (productos.Count() == 0)
                {
                    return RedirectToAction(nameof(notresultado));
                }
            }
            
            return View(productos.ToList());

        }
        public IActionResult notresultado()
        {
            @ViewData["NORESULTADO"] = "NO SE ENCONTRARON RESULTADOS";
            return View();
        }




        public IActionResult Inicio(int? page)
        {

            ProductosSlider ps = new ProductosSlider();
            ps.productos = _db.Productos.ToList();
            ps.sliders = _db.Slider.ToList();
            return View(ps);
            //return View(_db.Productos.Include(c => c.CategoriaProductos).ToList().ToPagedList(page ?? 1, 6));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.Productos.Include(c => c.CategoriaProductos).FirstOrDefault(c => c.ID == id);
            if (product == null)
            {
                return NotFound();

            }
            return View(product);
        }

        [HttpPost]
        [ActionName("Detail")]
        public async Task<ActionResult> ProductDetail(int? id)
        {
            Carrito cr = new Carrito();
            List<Productos> producto = _db.Productos.Include(c => c.CategoriaProductos).Where(c => c.ID == id).ToList();

            if (producto != null)
            {
                foreach (var prod in producto)
                {
                    cr.ProductId = prod.ID;
                }
            }

            cr.email = User.Identity.Name;

            cr.Cantidad = 1;

            await _db.Carrito.AddAsync(cr);

            _db.SaveChanges();

            
            return RedirectToAction(nameof(Index));


        }



        //Detalles de Producto

        //public ActionResult Detail(int? id)
        //{

        //    if(id == null)
        //    {
        //        return NotFound();
        //    }

        //    var producto = _db.Productos.Include(c => c.CategoriaProductos).FirstOrDefault(c => c.ID == id);

        //    if (producto == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(producto);
        //}


        ////Post Detalles de Producto
        //[HttpPost]
        //[ActionName("Detail")]
        //public ActionResult ProductoDetail(int? id)
        //{

        //    List<Productos> productos = new List<Productos>();

        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var producto = _db.Productos.Include(c => c.CategoriaProductos).FirstOrDefault(c => c.ID == id);

        //    if (producto == null)
        //    {
        //        return NotFound();
        //    }


        //    productos = HttpContext.Session.Get<List<Productos>>("productos");
        //    if (productos == null)
        //    {
        //        productos = new List<Productos>();
        //    }
        //    productos.Add(producto);
        //    HttpContext.Session.Set("productos", productos);
        //    return RedirectToAction(nameof(Index));
        //}

        //Get Remove



        public async Task<IActionResult> Remove(int? id, Carrito ca)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != ca.Id)
            {
                return NotFound();
            }

            var car = _db.Carrito.Find(id);
            if (car == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Remove(car);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName: nameof(Carrito));
            }
            return View(car);
        }

        [Authorize]
        public IActionResult Carrito()
        {

            var product = _db.Carrito.Include(c => c.Producto).Where(c => c.email == User.Identity.Name).ToList();
            return View(product);
        }



        //public IActionResult Remove(int? id)
        //{

        //    List<Productos> productos = HttpContext.Session.Get<List<Productos>>("productos");
        //    if (productos != null)
        //    {
        //        var producto = productos.FirstOrDefault(c => c.ID == id);
        //        if (producto != null)
        //        {
        //            productos.Remove(producto);
        //            HttpContext.Session.Set("productos", productos);
        //        }
        //    }
        //    return RedirectToAction(nameof(Index));
        //}




        //Producto Carrito

        //public IActionResult Carrito()
        //{
        //    List<Productos> productos = HttpContext.Session.Get<List<Productos>>("productos");
        //    if (productos == null)
        //    {
        //        productos = new List<Productos>();
        //    }
        //    return View(productos);
        //}

    }
}
