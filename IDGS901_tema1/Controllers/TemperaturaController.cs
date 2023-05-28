using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TemperaturaController : Controller
    {
        // GET: Temperatura
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Temperatura t, string opc)
        {
            double temperatura = t.ConvertirTemperatura(opc);

            // Redirigir a la vista de resultado con el valor de la distancia
            return RedirectToAction("ResultadoConversion", new { temperatura = temperatura });
        }

        public ActionResult ResultadoConversion(double temperatura)
        {
            ViewBag.Temperatura = temperatura;
            return View();
        }
    }
}