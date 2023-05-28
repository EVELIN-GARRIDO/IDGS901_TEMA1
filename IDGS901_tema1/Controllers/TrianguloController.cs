using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult VerificarTriangulo(Triangulo triangulo)
        {
            TrianguloServices services = new TrianguloServices();
            services.ObtenerTipoTriangulo(triangulo);
            return View(triangulo);
        }
    }
}