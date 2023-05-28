using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class Temperatura
    {
        public double Temp { get; set; }
        public double Farenheit { get; set; }
        public double Centigrados { get; set; }

        public double TemperaturaResultado { get; set; }

        public double ConvertirTemperatura(String opc)
        {
            switch (opc)
            {
                case "Farenheit":
                    Farenheit = (Temp * 9 / 5) + 32;
                    TemperaturaResultado = Farenheit;
                    break;

                case "Centigrados":
                    Centigrados = (5 * (Temp - 32)) / 9;
                    TemperaturaResultado = Centigrados;
                    break;
            }
            return TemperaturaResultado;
        }
    }
}