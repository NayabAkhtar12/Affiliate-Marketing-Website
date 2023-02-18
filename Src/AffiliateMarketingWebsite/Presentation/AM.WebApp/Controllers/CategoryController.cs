using AM.Business.Interfaces;
using AM.Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SM.Business.DataServices;

namespace AM.WebApp.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _Categoryservice;
        public CategoryController(ICategoryService categoryservice)
        {
            _Categoryservice = categoryservice;
        }

        // GET: CategoryController
        public ActionResult Index()
        {
            var models = _Categoryservice.GetAll();
            return View(models);
        }
    
        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryModel model)
        {
            try
            {
                _Categoryservice.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var catmodel = _Categoryservice.GetById(id);
            return View(catmodel);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryModel model)
        {
            try
            {
                _Categoryservice.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            _Categoryservice.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
