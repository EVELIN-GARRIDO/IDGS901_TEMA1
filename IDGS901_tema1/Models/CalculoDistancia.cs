using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class CalculoDistancia
    {
        public CalculoDistancia() { }
        public int x0 { get; set; }
        public int y0 { get; set; }
        public int x1 { get; set; }
        public int y1 { get; set; }
        public double distancia { get; set; }

        public double CalcularDistancia()
        {
            return Math.Sqrt(Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2));
        }
    }
}