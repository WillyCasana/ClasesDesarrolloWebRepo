using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPersonalEjemplo.Models;

namespace WebAppPersonalEjemplo.Controllers
{
    public class PersonalController : Controller
    {
        List<PersonalEnt> listadoPersonal =null;
        public ActionResult Listado()
        {
            listadoPersonal = new List<PersonalEnt>();
         
            //Llenado local(sin base de datos), al inicio cargan 2 registros
            PersonalEnt pers01 = new
                PersonalEnt
            {
                PersonalId = 1,
                Nombres = "Juan",
                Apellidos = "Perez",
                Correo = "jperez@hotmail.com"
            };

            PersonalEnt pers02 = new
             PersonalEnt
            {
                PersonalId = 2,
                Nombres = "Pedro",
                Apellidos = "Suarez",
                Correo = "psuarez@hotmail.com"
            };

            listadoPersonal.Add(pers01);
            listadoPersonal.Add(pers02);

            ViewBag.listado = listadoPersonal;

            return View(listadoPersonal);
        }

        public ActionResult Nuevo()
        {
            //TempData sirve para enviar datos de la view al controller
            //A diferencia del ViewBag que envia datos del controller a la view
            List<PersonalEnt> list = (List<PersonalEnt>)TempData["listado"];

            PersonalEnt persObj = new PersonalEnt();

            ViewBag.listado = list;


            return View(persObj);
        }

        
        public ActionResult Registrar(PersonalEnt persObj)
        {
            List<PersonalEnt> listado = (List<PersonalEnt>)TempData["listado"];
            listado.Add(persObj); 
          return  View("Listado", listado); //Una vez cargado
        }


      
    }
}