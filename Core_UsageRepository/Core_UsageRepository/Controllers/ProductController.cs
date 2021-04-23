using Core_UsageRepository.Models;
using Core_UsageRepository.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_UsageRepository.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.Products);
        }

        [HttpGet]
        public IActionResult Insert() => View();

        [HttpPost]
        public IActionResult Insert(Product item)
        {
            if (ModelState.IsValid)
            {
                if (_repository.InsertProduct(item))
                {
                    return RedirectToAction("Index");
                }
                else
                    return View(item);
            }
            else
            {
                return View(item);
            }
        }

        [HttpGet]
        public IActionResult Update(int id) => View(_repository.GetById(id));

        [HttpPost]
        public IActionResult Update(Product item)
        {
            _repository.UpdateProduct(item);
            return RedirectToAction("Index");


        }

        public IActionResult Delete(int id)
        {
            _repository.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        //ViewModel veya Tuple yazılan örnekler:

        public IActionResult GetProductCategory()
        {
            IndexVM vm = new IndexVM();
            // vm.Products = _repository.Products.ToList();
            //  vm.Categories = _repository.Categories.ToList();
            //return View(vm);


            //tuple için:
            return View(Tuple.Create<Category, IndexVM, List<Product>>(new Category(), vm, _repository.Products.ToList()));
        }

        [HttpPost]
        public IActionResult GetProductCategory([Bind(Prefix = "item1")] Category item)
        {
            return Json("item1 kategori nesnesidir.");
        }
    }
}
