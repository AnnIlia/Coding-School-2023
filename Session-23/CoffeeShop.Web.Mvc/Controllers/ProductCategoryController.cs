﻿using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using static CoffeeShop.Model.ProductCategoryEditDto;

namespace CoffeeShop.Web.Mvc.Controllers
{
    public class ProductCategoryController : Controller
    {
        private IEntityRepository <ProductCategory> _prodCatRepo;

        public ProductCategoryController(IEntityRepository<ProductCategory> prodCatRepo)

        { 
             _prodCatRepo = prodCatRepo;
          
        }
       
        
        // GET: ProductCategoryController
        public ActionResult Index()
        {
            var prodCats = _prodCatRepo.GetAll();
            var prodCategories = prodCats.ToList();

            return View(model:prodCats);
        }

        // GET: ProductCategoryController/Details/5
        public ActionResult Details(int? id)
        {
            var prodCat = _prodCatRepo.GetById(id.Value); //without ? (id)-without .Value
            if (id == null)
            {
                return NotFound();
            }
            if (prodCat == null)
            {
                return NotFound();
            }
            var viewProdCat = new ProductCategoryDetailsDto();
            {
                viewProdCat.Id = prodCat.Id;
                viewProdCat.Code = prodCat.Code;
                viewProdCat.Description = prodCat.Description;
                viewProdCat.ProductType = prodCat.ProductType;
                viewProdCat.Products = prodCat.Products.ToList();
                return View(model: viewProdCat);
            };
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
