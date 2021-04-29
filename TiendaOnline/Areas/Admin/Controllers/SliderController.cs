using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaOnline.Data;
using TiendaOnline.Models;
using TiendaOnline.ViewModels;

namespace TiendaOnline.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SliderController : Controller
    {

        public  ApplicationDbContext _db;
        public  IHostingEnvironment _he;

        public SliderController(ApplicationDbContext context, IHostingEnvironment hostEnvironment)
        {
            _db = context;
            _he = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_db.Slider.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Slider sl, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {

                    var name = Path.Combine(_he.WebRootPath + "/Slider", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    sl.image = "Slider/" + image.FileName;

                }


                _db.Slider.Add(sl);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(sl);
        }



        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var slider = _db.Slider.Find(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, Slider slider)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != slider.ID)
            {
                return NotFound();
            }

            var sl = _db.Slider.Find(id);
            if (sl == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Remove(sl);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(sl);

        }

        //private string UploadedFile(SliderViewModel slider)
        //{
        //    string uniqueFileName = null;

        //    if (slider.SliderImagen != null)
        //    {
        //        string uploadsFolder = Path.Combine(_he.WebRootPath, "imagenes");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + slider.SliderImagen.FileName;
        //        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            slider.SliderImagen.CopyTo(fileStream);
        //        }
        //    }
        //    return uniqueFileName;
        //}






        //Metodo Eliminar
        //public ActionResult Delete(int? id)
        //{

        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var slider = _db.Slider.Find(id);
        //    if (slider == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(slider);
        //}

        ////Crear el metodo Post Eliminar

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Delete(int? id, Slider slider)
        //{

        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    if (id != slider.ID)
        //    {
        //        return NotFound();
        //    }

        //    var sld = _db.CategoriaProductos.Find(id);
        //    if (sld == null)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        _db.Remove(sld);
        //        await _db.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(slider);
        //}


    }
}