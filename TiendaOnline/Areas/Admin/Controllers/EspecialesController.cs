using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TiendaOnline.Data;
using TiendaOnline.Models;

namespace TiendaOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EspecialesController : Controller
    {
        public ApplicationDbContext _db;

        public EspecialesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            return View(_db.Especiales.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Especiales especiales)
        {
            if (ModelState.IsValid)
            {
                _db.Especiales.Add(especiales);
                await _db.SaveChangesAsync();
                TempData["guardar"] = "El especial se guardó exitosamente!";
                return RedirectToAction(nameof(Index));
            }
            return View(especiales);
        }

        //Metodo Editar
        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var especiales = _db.Especiales.Find(id);
            if (especiales == null)
            {
                return NotFound();
            }


            return View(especiales);
        }

        //Crear el metodo Post Editar

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(Especiales especiales)
        {
            if (ModelState.IsValid)
            {
                _db.Update(especiales);
                await _db.SaveChangesAsync();
                TempData["editar"] = "El especial se actualizó exitosamente!";
                return RedirectToAction(nameof(Index));
            }
            return View(especiales);
        }



        //Detalles
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var especiales = _db.Especiales.Find(id);
            if (especiales == null)
            {
                return NotFound();
            }


            return View(especiales);
        }

        //Crear el metodo Post Details

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Details(Especiales especiales)
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
            var especiales = _db.Especiales.Find(id);
            if (especiales == null)
            {
                return NotFound();
            }


            return View(especiales);
        }

        //Crear el metodo Post Eliminar

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(int? id, Especiales especiales)
        {

            if (id == null)
            {
                return NotFound();
            }

            if (id != especiales.ID)
            {
                return NotFound();
            }

            var especial = _db.Especiales.Find(id);
            if (especial == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Remove(especial);
                await _db.SaveChangesAsync();
                TempData["eliminar"] = "El especial se eliminó exitosamente!";
                return RedirectToAction(nameof(Index));
            }
            return View(especiales);
        }
    }
}