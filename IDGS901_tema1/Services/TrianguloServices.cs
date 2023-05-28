using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class TrianguloServices
    {
        public void ObtenerTipoTriangulo(Triangulo t)
        {
            double lado1 = Math.Sqrt(Math.Pow(t.x2 - t.x1, 2) + Math.Pow(t.y2 - t.y1, 2));
            double lado2 = Math.Sqrt(Math.Pow(t.x3 - t.x2, 2) + Math.Pow(t.y3 - t.y2, 2));
            double lado3 = Math.Sqrt(Math.Pow(t.x1 - t.x3, 2) + Math.Pow(t.y1 - t.y3, 2));

            if ((lado1 + lado2 > lado3) && (lado2 + lado3 > lado1) && (lado3 + lado1 > lado2))
            {
                t.verificacion = "Los 3 puntos ingresados forman un triángulo.";
                Console.Write(t.verificacion);
                if (Math.Round(lado1, 2) == Math.Round(lado2, 2) && Math.Round(lado2, 2) == Math.Round(lado3, 2))
                {
                    t.triangulo = "El triángulo formado es equilátero.";
                    t.perimetro = lado1 + lado2 + lado3;
                    double mitad_perimetro = t.perimetro / 2;
                    t.area = Math.Sqrt(mitad_perimetro * (mitad_perimetro - lado1) * (mitad_perimetro - lado2) * (mitad_perimetro - lado3));
                    t.resultado_perimetro = "El resultado del perimetro es: " + Math.Round(t.perimetro, 2) + ".";
                    t.resultado_area = "El resultado del área es: " + t.area + " u^2.";
                }
                else if (Math.Round(lado1, 2) == Math.Round(lado2, 2) || Math.Round(lado2, 2) == Math.Round(lado3, 2) || Math.Round(lado3, 2) == Math.Round(lado1, 2))
                {
                    t.triangulo = "El triángulo formado es isósceles.";
                    t.perimetro = lado1 + lado2 + lado3;
                    double mitad_perimetro = t.perimetro / 2;
                    t.area = Math.Sqrt(mitad_perimetro * (mitad_perimetro - lado1) * (mitad_perimetro - lado2) * (mitad_perimetro - lado3));
                    t.resultado_perimetro = "El resultado del perímetro es: " + Math.Round(t.perimetro, 2) + ".";
                    t.resultado_area = "El resultado del área es: " + t.area + " u^2.";
                }
                else
                {
                    t.triangulo = "El triángulo formado es escaleno.";
                    t.perimetro = lado1 + lado2 + lado3;
                    double mitad_perimetro = t.perimetro / 2;
                    t.area = Math.Sqrt(mitad_perimetro * (mitad_perimetro - lado1) * (mitad_perimetro - lado2) * (mitad_perimetro - lado3));
                    t.resultado_perimetro = "El resultado del perímetro es: " + Math.Round(t.perimetro, 2) + ".";
                    t.resultado_area = "El resultado del área es: " + t.area + " u^2.";
                }

            }
            else
            {
                t.verificacion = "Los 3 puntos ingresados no forman un triángulo.";
            }
        }
    }
}