using AM.Business.Interfaces;
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
      //  AffiliateMarketingDbContext _context;

        public ProductController(IProductService productservice)
        {
            _Productservice = productservice;
        }
        //GET: ProductController
        public ActionResult Index(int categoryId)
        {
            //List<ProductModel> products;
            //products = _Productservice.GetAll();
            //return View(products);
            var products = _Productservice.Productsforcategories(categoryId);
            return View(products);
        }

        // GET: ProductController/Details/5


        // GET: ProductController/Create
        public ActionResult Create(int? id)
        {
            ViewBag.Id = id;
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel model)
        {
            try
            {
               // model.Category = null;
                _Productservice.Add(model);
                return RedirectToAction(nameof(Index), new {Id=model.CategoryId});
            }
            catch
            {
                return View();
            }
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

        public ActionResult Details(int id)
        {
            var product = _Productservice.GetAll().Where(x => x.Id == id).FirstOrDefault();
            return View(product);

        }
        // POST: CoursesController/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(ProductModel model)
        {
            try
            {
                var product = _Productservice.GetAll().Where(x => x.Id == model.Id).FirstOrDefault();
                if (product != null)
                {
                    product.Name = model.Name;
                    product.Price=model.Price;
                    product.Img = model.Img;
                    product.Product_Description = model.Product_Description;
                    product.LinkToBuy = model.LinkToBuy;
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

    }
}
