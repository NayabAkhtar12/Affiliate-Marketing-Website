using AM.Business.Interfaces;
using AM.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SM.Business.DataServices;

namespace AM.WebApp.Controllers
{
    public class PDetailController : Controller
    {
        private readonly IPDetailsService _PDservice;
        public PDetailController(IPDetailsService PDservice)
        {
            _PDservice = PDservice;
        }
        // GET: PDetailController
        public ActionResult Index()
        {
            //var PDetailModel=new PDetailsModel {Name = "nayab", Price = "1200", Product_Description = "desk", Link = "1" };
            //_PDservice.Add(PDetailModel);

            var models = _PDservice.GetAll();
             return View(models);
        }

        // GET: PDetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PDetailController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PDetailsModel model)
        {
            try
            {
                _PDservice.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PDetailController/Edit/5
        public ActionResult Edit(int id)
        {
            var PDetailmodel = _PDservice.GetById(id);
            return View(PDetailmodel);
        }

        // POST: PDetailController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PDetailsModel model)
        {
            try
            {
                _PDservice.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PDetailController/Delete/5
        public ActionResult Delete(int id)
        {
            _PDservice.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
