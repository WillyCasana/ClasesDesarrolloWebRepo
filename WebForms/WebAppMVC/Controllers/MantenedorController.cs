using SisPla;
using SisPlaBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC.Controllers
{
    public class MantenedorController : Controller
    {
        // GET: Mantenedor
        public ActionResult Index()
        { 


            return View(SisplaLogic.PortadaListar());
        }

        public ActionResult Guardar(PortadaEnt obj)
        {

            SisplaLogic.PortadaRegistrar(obj);

           return RedirectToAction("Index");
        }

        public ActionResult Nuevo()
        {
            return View();
        }
    }
}