using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_PassingDataToView.Controllers
{
    public class SiparisController : Controller
    {
        public IActionResult UrunSat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UrunSat(IFormCollection koleksiyon)
        {
            TempData["SatilanUrunID"] = Convert.ToInt32(koleksiyon["urunID"]);
            TempData["SatilanUrunAdi"] = koleksiyon["urunAdi"].ToString();
            TempData["SatilanUrunFiyati"] = koleksiyon["birimFiyati"].ToString();

            return RedirectToAction("StokAzalt","Urun");//bilgileri uruncontroller daki stokazalta yönlendirdi
        }
    }
}
