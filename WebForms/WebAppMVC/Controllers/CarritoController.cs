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

            return View(pcObj);
        }

        public ActionResult Guardar(PortadaCompraEnt obj)
        {
            SisplaLogic.PortadaCompraGrabar(obj);



            return RedirectToAction("Index");

            //ViewBag.mensaje = "Exito";
            //return RedirectToAction("DetalleCompra", new { id= obj.PortId});
        }

      
    }
}