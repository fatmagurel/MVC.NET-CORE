using Core_QuereyString.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Core_QuereyString.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        
        }
        //public IActionResult Details(int id)
        //{
        //    return View();
        //}

        //browsera /home/details?detayAdi=BenimDetayım
        //public IActionResult Details(string detayAdi)
        //{
        //    return View();
        //}


        //[Route("/Home/Detay/{id:int}/{deger}")]

        //browsera /home/details?deger=Fatma&detay=BilgeAdam
        public IActionResult Details(string deger, string detay)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
