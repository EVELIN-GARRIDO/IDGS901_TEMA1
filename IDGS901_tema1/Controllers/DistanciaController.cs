using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult Distancia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Distancia(CalculoDistancia cd)
        {
            if (ModelState.IsValid)
            {
                // Calcular la distancia utilizando el método del modelo
                double distancia = cd.CalcularDistancia();

                // Redirigir a la vista de resultado con el valor de la distancia
                return RedirectToAction("ResultadoDistancia", new { distancia = distancia });
            }

            // Si los datos no son válidos, mostrar el formulario nuevamente
            return View(cd);
        }

        public ActionResult ResultadoDistancia(double distancia)
        {
            ViewBag.Distancia = distancia;
            return View();
        }
    }
}