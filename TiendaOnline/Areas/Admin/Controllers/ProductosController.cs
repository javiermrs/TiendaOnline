using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using TiendaOnline.Data;
using TiendaOnline.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace TiendaOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductosController : Controller
    {

        private ApplicationDbContext _db;
        private IHostingEnvironment _he;

        public ProductosController(ApplicationDbContext db, IHostingEnvironment he)
        {
            _db = db;
            _he = he;
        }


        public IActionResult Index()
        {
            return View(_db.Productos.Include(c=>c.CategoriaProductos).ToList());
        }


        //Post Index
        [HttpPost]
        public IActionResult Index(double? bajoPrecio, double? altoPrecio)
        {
            var productos = _db.Productos.Include(c => c.CategoriaProductos).Where(c => c.Precio >= bajoPrecio && c.Precio <= altoPrecio).ToList();

            if (bajoPrecio == null || altoPrecio == null)
            {
                productos = _db.Productos.Include(c => c.CategoriaProductos).ToList();
            }

            return View(productos);
        }

        //Metodo Crear
        public IActionResult Create()
        {
            ViewData["categoriaProductoId"] = new SelectList(_db.CategoriaProductos.ToList(), "ID", "nombreCategoria");

            return View();
        }



        //Metodo Post Crear

        [HttpPost]
        public async Task<IActionResult>  Create(Productos productos, IFormFile imagen)
        {

            if (ModelState.IsValid)
            {

                var buscarProducto = _db.Productos.FirstOrDefault(c => c.Nombre == productos.Nombre);

                if(buscarProducto != null)
                {
                    ViewBag.message = "Este producto ya existe!";
                    ViewData["categoriaProductoId"] = new SelectList(_db.CategoriaProductos.ToList(), "ID", "nombreCategoria");
                    return View(productos);
                }

                if (imagen != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Imagenes", Path.GetFileName(imagen.FileName));
                    await imagen.CopyToAsync(new FileStream(name, FileMode.Create));
                    productos.Imagen = "Imagenes/" + imagen.FileName;
                }

                //if(imagen == null)
                //{
                //    productos.Imagen = "Imagenes/ErrorImagen.jpg";
                //}

                _db.Productos.Add(productos);
                await _db.SaveChangesAsync();
                TempData["guardar"] = "El Producto se agregó exitosamente!";
                return RedirectToAction(nameof(Index));
            }


            return View(productos);
        }


        //Editar

        public IActionResult Edit(int? id)
        {

            ViewData["categoriaProductoId"] = new SelectList(_db.CategoriaProductos.ToList(), "ID", "nombreCategoria");
            if(id == null)
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


        //Metodo Post Editar
        [HttpPost]
        public async Task<IActionResult> Edit(Productos productos, IFormFile imagen)
        {

            if (ModelState.IsValid)
            {

                if (imagen != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Imagenes", Path.GetFileName(imagen.FileName));
                    await imagen.CopyToAsync(new FileStream(name, FileMode.Create));
                    productos.Imagen = "Imagenes/" + imagen.FileName;
                }

                //if (imagen == null)
                //{
                //    productos.Imagen = "Imagenes/ErrorImagen.jpg";
                //}

                _db.Productos.Update(productos);
                await _db.SaveChangesAsync();
                TempData["editar"] = "El Producto se actualizó exitosamente!";
                return RedirectToAction(nameof(Index));
            }


            return View(productos);
        }


        //Detalles


        public ActionResult Details(int? id)
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


        //Eliminar

        public ActionResult Delete(int? id)
        {

            if(id == null)
            {
                return NotFound();
            }

            var producto = _db.Productos.Include(c=>c.CategoriaProductos).Where(c => c.ID == id).FirstOrDefault();

            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        //Post Eliminar
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm (int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var producto = _db.Productos.FirstOrDefault(c => c.ID == id);

            if (producto == null)
            {
                return NotFound();
            }

            _db.Productos.Remove(producto);

            await _db.SaveChangesAsync();
            TempData["eliminar"] = "El producto se eliminó exitosamente!";
            return RedirectToAction(nameof(Index));
        }

    }
}