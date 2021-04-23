using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_PassingDataToView.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Tarih = DateTime.Now.ToLongDateString(); //veriyi viewe taşır. dynamic yapı olduğu için boxing unboxing yapmaya gerek kalmaz viewbag ile.
            ViewBag.Koleksiyon = new string[] { "Bilge", "Ayşe", "Hayriye" };
            ViewData["Saat"] = DateTime.Now.ToLongTimeString();
            return View();
        }
    }
}
