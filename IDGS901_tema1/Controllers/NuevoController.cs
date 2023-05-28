using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        //Metodo que retorna la vista
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OperasBas(string n1, string n2, string opera)//Variables
        {
            int res;
            switch (opera)
            {
                case "suma": 
                    res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
                    ViewBag.Res = res;
                    break;
                case "resta":
                    res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
                    ViewBag.Res = res;
                    break;
                case "multiplicacion":
                    res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
                    ViewBag.Res = res;
                    break;
                case "division":
                    res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
                    ViewBag.Res = res;
                    break;
            }
            
            return View();
        }

        public ActionResult MuestraPulque()
        {
            var PulquesService1 = new PulquesServices();
            var model = PulquesService1.ObtenerPulque();
            return View(model);
        }

        public ActionResult Calculos(OperasBas op, string opera)
        {
            op.Calcular(opera);
            return View(op);
        }
    }
}