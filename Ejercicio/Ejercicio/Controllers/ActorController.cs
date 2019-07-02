using Ejercicio.EF;
using Ejercicio.DAL;
using Ejercicio.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio.Controllers
{
    public class ActorController : Controller
    {
        // GET: Actor
        public ActionResult Listar()
        {
            // viwBag
            // ViwData
            // Model = Formulario (solo puede ser uno)
            ViewData["actor"] = ActorDAL.Listar();

            return View();
        }       
        

    }
}