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

        public  ActionResult DetalleCompra(int PortId)
        {
            PortadaCompraEnt pcObj = SisplaLogic.PortadaListarXId(PortId);

            return View(pcObj);
        }
    }
}