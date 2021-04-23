using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_PartialView.Controllers
{
    public class SampleController : Controller
    {
        //public PartialViewResult Sample()
        //{
        //    return PartialView("_SamplePartial");
        //}
        public IActionResult Sample()
        {
            return View();
        }
    }
}
