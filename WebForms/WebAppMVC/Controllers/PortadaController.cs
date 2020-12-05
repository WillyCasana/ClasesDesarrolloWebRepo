using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisPlaBLL;


namespace WebAppMVC.Controllers
{
    public class PortadaController : Controller
    {
        // GET: Portada
        public ActionResult Index()
        {

            return View(SisplaLogic.PortadaListar());
        }

        // GET: Portada/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Portada/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Portada/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Portada/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Portada/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Portada/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Portada/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
