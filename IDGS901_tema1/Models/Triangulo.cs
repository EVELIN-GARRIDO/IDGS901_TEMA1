using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class Triangulo
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double x3 { get; set; }
        public double y3 { get; set; }
        public string verificacion { get; set; }
        public string triangulo { get; set; }
        public double perimetro { get; set; }
        public double area { get; set; }
        public string resultado_perimetro { get; set; }
        public string resultado_area { get; set; }
    }
}