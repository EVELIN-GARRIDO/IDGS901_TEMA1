using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class Pulques
    {
        public Pulques() { }
        public string Producto { get; set; }
        public int litros { get; set; }
        public DateTime Produccion { get; set; }
        public string Descripcion { get; set; }
    }
}