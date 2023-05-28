using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            var persona = new Persona(){
                Nombre = "Mario",
                Edad = 23,
                Empleado = true,
                Nacimiento = new DateTime(2001, 11, 03)
            };
            ViewBag.Persona = persona;
            return View();
        }

        public ActionResult Registrar()
        {
            var persona = new Persona();
            return View(persona);
        }

        public ActionResult Registrar2()
        {
            var persona = new Persona();
            return View(persona);
        }
    }
}