using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class Diccionario
    {
        public Diccionario() { }
        public string Palabra { get; set; }
        public string Palabra_esp { get; set; }
        public string Palabra_ing { get; set; }
        public string Respuesta { get; set; }

        public void TraducirPalabra(String opc, DiccionarioServices diccionarioServices)
        {
            List<Diccionario> diccionario = diccionarioServices.LeerArchivo();

            switch (opc)
            {
                case "Palabra_esp":
                    foreach (var palabra_lista in diccionario)
                    {
                        if (palabra_lista.Palabra_ing.Trim() == Palabra.ToLower())
                        {
                            Respuesta = palabra_lista.Palabra_esp.Trim();
                            break;

                        }
                        else if (palabra_lista.Palabra_esp.Trim() == Palabra.ToLower())
                        {
                            Respuesta = palabra_lista.Palabra_esp.Trim();
                            break;

                        }
                        else
                        {
                            Respuesta = "Palabra no encontrada";
                        }
                    }
                    break;

                case "Palabra_ing":
                    foreach (var palabra_lista in diccionario)
                    {
                        if (palabra_lista.Palabra_esp.Trim() == Palabra.ToLower())
                        {
                            Respuesta = palabra_lista.Palabra_ing.Trim();
                            break;

                        }
                        else if (palabra_lista.Palabra_ing.Trim() == Palabra.ToLower())
                        {
                            Respuesta = palabra_lista.Palabra_ing.Trim();
                            break;
                        }
                        else
                        {
                            Respuesta = "Palabra no encontrada";
                        }
                    }
                    break;
            }
        }
    }
}