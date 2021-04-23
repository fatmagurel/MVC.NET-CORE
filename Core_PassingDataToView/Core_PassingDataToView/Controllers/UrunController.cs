using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_PassingDataToView.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult StokAzalt()
        {
            int id =Convert.ToInt32(TempData["SatilanUrunID"]);
            string adi = TempData["SatilanUrunAdi"].ToString();
            string fiyati = TempData["SatilanUrunFiyati"].ToString();

            ViewBag.UrunID = id;
            ViewBag.UrunAdi = adi;
            ViewBag.UrunFiyati = fiyati;
            return View();
        }
    }
}
