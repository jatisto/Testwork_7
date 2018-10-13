using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppliancesTech.Models;
using AppliancesTech.Models.ShopModel;
using AppliancesTech.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppliancesTech.Controllers
{
    public class AppliancesTechController : Controller
    {
        [BindProperty] public Product Product { get; set; }

        private ICategoryDetails _categoryDetails;

        // GET: AppliancesTech
        public AppliancesTechController(ICategoryDetails categoryDetails)
        {
            _categoryDetails = categoryDetails;
        }

        public IActionResult Info(int id)
        {
            var model = _categoryDetails.GetProductId(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Details));
            }

            return View(model);
        }

        // GET: AppliancesTech/Details/5
        public IActionResult Details()
        {
            var model = _categoryDetails.GetAllProduct();
            return View(model);
        }

        // GET: AppliancesTech/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: AppliancesTech/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var newProduct = new Product();
                newProduct.Name = product.Name;
                newProduct.CategoryViewModel = product.CategoryViewModel;
                newProduct.Description = product.Description;
                newProduct.Manufacturer = product.Manufacturer;
                newProduct.Price = product.Price;

                newProduct = _categoryDetails.Add(newProduct);
                return RedirectToAction(nameof(Info), new {id = newProduct.Id});
            }
            else
            {
                return View();
            }
        }

        // GET: AppliancesTech/Edit/5
        public ActionResult Edit(int id)
        {
            Product = _categoryDetails.GetProductId(id);
            if (Product == null)
            {
                return View(nameof(Info));
            }


            return View();
        }


        // POST: AppliancesTech/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            if (ModelState.IsValid)
            {
                _categoryDetails.Update(Product);
                return RedirectToAction("Info",  new { id = Product.Id });
            }
            else
            {
                return View();
            }
        }

      
    }
}