﻿using AM.Business.Interfaces;
using AM.Business.Models;
using AM.Data;
using AM.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SM.Business.DataServices;

namespace AM.WebApp.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {

        private readonly IProductService _Productservice;
        AffiliateMarketingDbContext _context;

        public ProductController(IProductService productservice)
        {
            _Productservice = productservice;
        }
        public ActionResult Index(string? search)
        {
            List<ProductModel> products;
            if (search == null)
            {
                products = _Productservice.GetAll();
            }
            else
            {
                products = _Productservice.Search(search);
            }
            return View(products);
        }
        // GET: ProductController
        //public ActionResult Index(int categoryId, string? search)
        //{
        //var products = _Productservice.Productsforcategories(categoryId, search);
        //    return View(products);
        //}

       // GET: ProductController/Details/5
       

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel model)
        {
            try
            {
                _Productservice.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            List<ProductModel> products;
            products = _Productservice.GetAllProducts(id);
            //Product products = _context.Products.Where(x=>x.Id==id).FirstOrDefault(); 
            return View(products);
        }
        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _Productservice.GetById(id);
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductModel model)
        {
            try
            {
                _Productservice.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            _Productservice.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        //// POST: ProductController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


    }
}
