using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class DiccionarioServices
    {

    public void GuardarArchivo(Diccionario dicc)
    {
        var palabra_esp = dicc.Palabra_esp;
        var palabra_ing = dicc.Palabra_ing;

        var datos = palabra_esp.ToLower() + ", " + palabra_ing.ToLower() + ", " + Environment.NewLine;
        var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Diccionario.txt");
        File.AppendAllText(archivo, datos);
    }


    public List<Diccionario> LeerArchivo()
        {
            var palabras = new List<Diccionario>();
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Diccionario.txt");

            if (File.Exists(archivo))
            {
                var lineas = File.ReadAllLines(archivo);

                foreach (var linea in lineas)
                {
                    var palabrasArray = linea.Split(',');

                    if (palabrasArray.Length >= 2)
                    {
                        var diccionario = new Diccionario();
                        diccionario.Palabra_esp = palabrasArray[0];
                        diccionario.Palabra_ing = palabrasArray[1];

                        palabras.Add(diccionario);
                    }
                }
            }

            return palabras;
        }
    }
}