using Ejercicio.EF;
using Ejercicio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio.DAL
{
    public class ActorDAL
    {
        public static List<actor> Listar()
        {
            var l = new List<actor>();
            using (var db = new Model1())
            {
                l = db.actor.ToList();
            }
            return l;
        }
    }
}