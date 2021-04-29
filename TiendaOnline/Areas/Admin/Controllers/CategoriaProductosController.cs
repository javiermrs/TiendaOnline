using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TiendaOnline.Data;
using TiendaOnline.Models;

namespace TiendaOnline.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "ADMIN")]
    public class CategoriaProductosController : Controller
    {

        private ApplicationDbContext _db;

        public CategoriaProductosController(ApplicationDbContext db)
        {
            _db = db;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {

            //var data = _db.CategoriaProductos.ToList();

            return View(_db.CategoriaProductos.ToList());
        }
    
        //Metodo Crear
        public ActionResult Create()
        {
            return View();
        }

        //Crear el metodo Post

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(CategoriaProductos categoriaProductos)
        {
            if (ModelState.IsValid)
            {
                _db.CategoriaProductos.Add(categoriaProductos);
                await _db.SaveChangesAsync();
                TempData["guardar"] = "La categoria agregó exitosamente!";
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaProductos);
        }

        //Metodo Editar
        public ActionResult Edit(int? id)
        {

            if(id == null)
            {
                return NotFound();
            }
            var categoriaProducto = _db.CategoriaProductos.Find(id);
            if(categoriaProducto == null)
            {
                return NotFound();
            }


            return View(categoriaProducto);
        }

        //Crear el metodo Post Editar

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(CategoriaProductos categoriaProductos)
        {
            if (ModelState.IsValid)
            {
                _db.Update(categoriaProductos);
                await _db.SaveChangesAsync();
                TempData["editar"] = "La categoria se actualizó exitosamente!";
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaProductos);
        }



        //Detalles
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var categoriaProducto = _db.CategoriaProductos.Find(id);
            if (categoriaProducto == null)
            {
                return NotFound();
            }


            return View(categoriaProducto);
        }

        //Crear el metodo Post Details

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Details(CategoriaProductos categoriaProductos)
        {

            return RedirectToAction(nameof(Index));
        }





        //Metodo Eliminar
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var categoriaProducto = _db.CategoriaProductos.Find(id);
            if (categoriaProducto == null)
            {
                return NotFound();
            }


            return View(categoriaProducto);
        }

        //Crear el metodo Post Eliminar

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(int? id,  CategoriaProductos categoriaProductos)
        {

            if (id == null)
            {
                return NotFound();
            }

            if (id != categoriaProductos.ID)
            {
                return NotFound();
            }

            var categoriaProducto = _db.CategoriaProductos.Find(id);
            if(categoriaProducto == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Remove(categoriaProducto);
                await _db.SaveChangesAsync();
                TempData["eliminar"] = "La categoria se eliminó exitosamente!";
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaProductos);
        }


    }
}