﻿using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Web.Mvc.Controllers
{
    public class ProductCategoryController : Controller
    {
        private IEntityRepo<ProductCategory> _prodCatRepo;

        public ProductCategoryController(IEntityRepo<ProductCategory> prodCatRepo)

        { 
             _prodCatRepo = prodCatRepo;
          
        }
       
        
        // GET: ProductCategoryController
        public ActionResult Index()
        {
            var prodCats = _prodCatRepo.GetAll();
            //var prodCategories = prodCats.ToList();

            return View(model:prodCats);
        }

        // GET: ProductCategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}