using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class DiccionarioController : Controller
    {
        // GET: Diccionario
        public ActionResult GuardarPalabras()
        {
            var datos = new DiccionarioServices();
            var diccionario = datos.LeerArchivo();
            return View(diccionario);
        }

        [HttpPost]
        public ActionResult GuardarPalabras(Diccionario dicc)
        {
            var datos = new DiccionarioServices();
            datos.GuardarArchivo(new Diccionario { Palabra_esp = dicc.Palabra_esp, Palabra_ing = dicc.Palabra_ing});
            var diccionario = datos.LeerArchivo();
            return View(diccionario);
        }

        public ActionResult Traductor(Diccionario dicc, String opc)
        {
            var datos = new DiccionarioServices();
            ViewBag.Opcion = opc;
            dicc.TraducirPalabra(opc, datos);
            return View(dicc);
        }
    }
}