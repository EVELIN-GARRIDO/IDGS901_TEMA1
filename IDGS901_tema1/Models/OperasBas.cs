using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class OperasBas
    {
        public OperasBas() { }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }

        public void Calcular(String opera)
        {
            switch(opera)
            {
                case "suma":
                    Res = Num1 + Num2;
                    break;

                case "resta":
                    Res = Num1 - Num2;
                    break;

                case "multiplicacion":
                    Res = Num1 * Num2;
                    break;

                case "division":
                    Res = Num1 / Num2;
                    break;
            }
        }
    }
}