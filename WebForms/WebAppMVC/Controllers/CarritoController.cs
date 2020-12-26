using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisPla;
using SisPlaBLL;

namespace WebAppMVC.Controllers
{
    public class CarritoController : Controller
    {
        // GET: Carrito
        public ActionResult Index()
        {
            return View(SisplaLogic.PortadaListar());
        }


        public ActionResult DetalleCompra(int id)
        {
            PortadaCompraEnt pcObj = SisplaLogic.PortadaListarXId(id);
            //ViewBag.mensaje = "Exito";
            return View(pcObj);
        }

        [HttpPost]  //IMPORTANTE PARA DISTINGUIR DEL OTRO DetalleCompra
        public ActionResult DetalleCompra(PortadaCompraEnt obj)
        {
            SisplaLogic.PortadaCompraGrabar(obj);

            //return RedirectToAction("Index");
            //return RedirectToAction("DetalleCompra", new { id = obj.PortId });

            return View(obj);
        }

        public ActionResult Guardar(PortadaCompraEnt obj)
        {
            SisplaLogic.PortadaCompraGrabar(obj);
           // return View();

            return RedirectToAction("Index");
        }

      
    }
}