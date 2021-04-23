using Core_TagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_TagHelper.Controllers
{
    public class UserController : Controller
    {
        //localhost:PortNo/User/Index/HtmlHelpers
        //public IActionResult HtmlHelpers()
        //{
        //    return View();
        //}

        public IActionResult HtmlHelpers() => View();

        [HttpPost]
        public IActionResult HtmlHelpers(User u)
        {
            return View("TagHelpers");
        }

        public IActionResult TagHelpers() => View();

        [HttpPost]
        public IActionResult TagHelpers(User u)
        {
            return View("HtmlHelpers");
        }
    }
}
