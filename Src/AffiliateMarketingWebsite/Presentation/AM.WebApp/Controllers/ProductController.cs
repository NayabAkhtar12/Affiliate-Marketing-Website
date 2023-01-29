using AM.Business.Interfaces;
using AM.Business.Models;
using Microsoft.AspNetCore.Mvc;
using SM.Business.DataServices;

namespace AM.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _Productservice;
        public ProductController(IProductServices productservice)
        {
            _Productservice = productservice;
        }
        // GET: ProductController
        public ActionResult Index(string? Search)
        {
            List<ProductModel> products;
            if (Search == null)
            {
                products = _Productservice.GetAll();
            }
            else
            {
                products = _Productservice.GetAll().Where(x => x.Name.ToLower()
                .Contains(Search.Trim().ToLower())).ToList();
            }
            return View(products);
        }

        // GET: ProductController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

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

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _Productservice.GetAll().Where(x => x.id == id).FirstOrDefault();
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductModel model)
        {
            try
            {
                var product = _Productservice.GetAll().Where(x => x.id == id).FirstOrDefault();
                if (product != null)
                {
                    product.Name = model.Name;
                    product.Price = model.Price;
                    product.Img = model.Img;
                    product.Product_Description = model.Product_Description;
                }
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
