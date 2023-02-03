using AM.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SM.Business.DataServices;

namespace AM.WebApp.Controllers
{
    public class PDetailController : Controller
    {
        //private readonly IPDetailsService _PDservice;
        //public PDetailController(IPDetailsService PDservice)
        //{
        //    _PDservice = PDservice;
        //}
        // GET: PDetailController
        public ActionResult Index()
        {
            //var models = _PDservice.GetAll();
            return View();
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
