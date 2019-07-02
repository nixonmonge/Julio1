using Julio1.Models;
using Julio1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Julio1.Service
{
    // BS = business Service
    public class CajaBS
    {
        public static int Volumen(Caja caja)
        {
            return caja.Alto * caja.Ancho * caja.Largo;
        }
    }
}