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

            return View("PagoCompra");



            //return RedirectToAction("DetalleCompra", new { id = obj.PortId });

            //return View(obj);
        }

        public ActionResult PagoCompra()
        {
            return View();
        }

    
        public ActionResult PagoCompraGuardar(PortadaPagoEnt obj)
        {

           if (!ModelState.IsValid)
            {
                return View("PagoCompra",obj); //Si hay algún error en los campos, se mantiene en la misma pantalla
            }

            SisplaLogic.PagoCompraGuardar(obj);

            // return RedirectToAction("Index");
            return View("Confirmacion");
        }

   

        //verbos del protocolo Html
        //Post(registrar), Get(Consultar), Put(Update), Delete(Eliminar)
        //[HttpPost]
        //public ActionResult PagoCompraGuardar()
        //{
        //   // SisplaLogic.PagoCompraGuardar(obj);

        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult Guardar(PortadaCompraEnt obj)
        {
      
            SisplaLogic.PortadaCompraGrabar(obj);

            return View("PagoCompra");
        }

      
    }
}