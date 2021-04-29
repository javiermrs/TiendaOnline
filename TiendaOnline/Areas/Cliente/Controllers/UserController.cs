using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TiendaOnline.Data;
using TiendaOnline.Models;

namespace TiendaOnline.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class UserController : Controller
    {

        UserManager<IdentityUser> _userManager;
        ApplicationDbContext _db;

        public UserController(UserManager<IdentityUser> userManager, ApplicationDbContext db )
        {
            _userManager = userManager;
            _db = db;
        }
        
        public IActionResult Index()
        {
            return View(_db.ApplicationUsers.ToList());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                var result = await _userManager.CreateAsync(user, user.PasswordHash);

                if (result.Succeeded)
                {
                    var isSaveRole = await _userManager.AddToRoleAsync(user, "User");
                    TempData["guardar"] = "El usuario se creó exitosamente!";
                    return RedirectToRoute("registro");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            
            return View();
        }



        public async Task<IActionResult> Edit(string id)
        {

            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);

            if(user == null)
            {
                return NotFound();
            }
            
            return View(user);
        }


        [HttpPost]

        public async Task<IActionResult> Edit(ApplicationUser user)
        {

            var userInfo = _db.ApplicationUsers.FirstOrDefault(c => c.Id == user.Id);

            if (userInfo == null)
            {
                return NotFound();
            }

            userInfo.fechaNacimiento = user.fechaNacimiento;

            var result = await _userManager.UpdateAsync(userInfo);

            if (result.Succeeded)
            {
                TempData["guardar"] = "El usuario se actualizó exitosamente!";
                return RedirectToAction(nameof(Index));
            }

            return View(userInfo);
        }



        public async Task<IActionResult> Details(string id)
        {

            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }



        public async Task<IActionResult> BloquearUsuario(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> BloquearUsuario(ApplicationUser user)
        {

            var userInfo = _db.ApplicationUsers.FirstOrDefault(c => c.Id == user.Id);
            if (userInfo == null)
            {
                return NotFound();
            }

            userInfo.LockoutEnd = DateTime.Now.AddYears(100);
            int filaAfectada = _db.SaveChanges();

            if (filaAfectada > 0)
            {
                TempData["guardar"] = "El usuario se bloqueó correctamente!";
                return RedirectToAction(nameof(Index));
            }

            return View(userInfo);
        }



        public async Task<IActionResult> Active(string id)
        {

            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);


        }

        [HttpPost]
        public async Task<IActionResult> Active(ApplicationUser user)
        {

            var userInfo = _db.ApplicationUsers.FirstOrDefault(c => c.Id == user.Id);
            if (userInfo == null)
            {
                return NotFound();
            }

            userInfo.LockoutEnd = DateTime.Now.AddDays(-1);
            int filaAfectada = _db.SaveChanges();

            if (filaAfectada > 0)
            {
                TempData["guardar"] = "El usuario se activó correctamente!";
                return RedirectToAction(nameof(Index));
            }

            return View(userInfo);
        }







        public async Task<IActionResult> Delete(string id)
        {

            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);


        }

        [HttpPost]
        public async Task<IActionResult> Delete(ApplicationUser user)
        {

            var userInfo = _db.ApplicationUsers.FirstOrDefault(c => c.Id == user.Id);
            if (userInfo == null)
            {
                return NotFound();
            }
                _db.ApplicationUsers.Remove(userInfo);
                int filaAfectada = _db.SaveChanges();

                if (filaAfectada > 0)
                {
                TempData["guardar"] = "El usuario se eliminó correctamente!";
                return RedirectToAction(nameof(Index));
            }

            return View(userInfo);
        }


    }
}