using Mostrar.Controllers;
using Mostrar.Models;
using Mostrar.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mostrar.Controllers
{
    public class ActorController : Controller
    {
        // GET: Actor
        public ActionResult Lista()
        { 
            var lista = new List<actor>();
            using (var cliente = new ServiceReference1.WebServiceActorSoapClient())
           {
                lista = cliente.Listar();
            }
            ViewBag.lista = lista;
        
            return View();
        }

    }
}