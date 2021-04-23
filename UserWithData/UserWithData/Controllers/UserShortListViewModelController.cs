using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserWithData.Models;

namespace UserWithData.Controllers
{
    public class UserShortListViewModelController : Controller
    {
        private readonly UserDbContext _context;

        public UserShortListViewModelController(UserDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<UserShortListViewModel> UserShortListViewModels = _context.Users
                .Select(x => new UserShortListViewModel { Id = x.Id, Username = x.Username, Email = x.Email })
                .ToList();
            return View(UserShortListViewModels);
        }
        public IActionResult ReturnView() 
        {
            return View();
        }

        public IActionResult ReturnString()
        {
            return Content("Yazı döndür.");
        }

        public IActionResult BosDondur()
        {
            return new EmptyResult();
        }

        public IActionResult ReturnAction()
        {
            return RedirectToAction("Index", "Users");
        }

        public IActionResult ReturnPartialView()
        {
            return PartialView();
        }

        public IActionResult ReturnFile()
        {
            return File("boyut", "dosya");
        }

        public IActionResult ReturnJson()
        {
            return Json(_context.Users);
        }
        [Microsoft.AspNetCore.Mvc.NonAction]
        //farklı bir siteye gönderilecekse
        public IActionResult ReturnURL()
        {
            return Redirect("https://www.bilgeadam.com/");
        }

        public IActionResult ReturnError()
        {
            return NotFound();
        }

        //Syncronous-- işlemler bitmesini bekliyor. Birer birer işliyor.
        public IActionResult Syncronous()
        {
            return View();
        }

        //Asyncronous-- işlemleri beklemiyor. İşlem bitince haber veriyor.
        
        public async Task<IActionResult> Asyncronous()
        {
            return View(await _context.SaveChangesAsync());
        }
    }
}
