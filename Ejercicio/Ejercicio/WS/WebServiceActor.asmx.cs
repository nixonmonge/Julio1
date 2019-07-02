using Ejercicio.EF;
using Ejercicio.DAL;
using Ejercicio.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Ejercicio.WS
{
    /// <summary>
    /// Summary description for WebServiceActor
    /// </summary>
    [WebService(Namespace = "http://fanta.cl/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceActor : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<actor> Listar()
        {
            return ActorDAL.Listar();
        }
    }
}
