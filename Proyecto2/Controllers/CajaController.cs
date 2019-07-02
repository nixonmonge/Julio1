using Proyecto2.Controllers;
using Proyecto2.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto2.Controllers
{
    public class CajaController : Controller
    {
        [HttpGet]
        public ActionResult Calcula()
        {
            Caja caja = new Caja();
            return View(caja);
        }
        [HttpPost]
        public ActionResult Calcula(Caja caja)
        {
            // conectarse al web service
            using (var cliente = new ServiceReference1.CajaWSSOAPSoapClient())
            {
                int total = cliente.Volumen(caja);
                ViewBag.total = total;
            }
            // cuando usar using?
            // conexion base de datos
            // conexion a web service o pagina 
            // lectura y escritura de archivo
            return View(caja);
        }
    }
}