using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Registar(Maestros maes)
        {
            var op = new GuardarServices();
            op.GuardarArchivo(maes);
            return View();
        }
    }
}