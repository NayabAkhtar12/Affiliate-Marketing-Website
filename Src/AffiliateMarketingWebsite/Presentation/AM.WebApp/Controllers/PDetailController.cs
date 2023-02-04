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
            var PDetailModel=new PDetailsModel { Id = 1, Name = "nayab", Price = "1200", Product_Description = "desk", Link = "1" };
            _PDservice.Add(PDetailModel);

            var models = _PDservice.GetAll();
             return View(models);
            //////var models = _PDservice.GetAll();
            //List<PDetailsModel> Detail = new List<PDetailsModel>();
            //Detail.Add(new PDetailsModel { Id = 1, Name = "nayab", Price = "1200", Product_Description = "desk", Link = "1" });
            //return View(Detail);
        }

        // GET: PDetailController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PDetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PDetailController/Create
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

        // GET: PDetailController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PDetailController/Edit/5
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

        // GET: PDetailController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PDetailController/Delete/5
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
