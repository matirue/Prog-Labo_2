﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_06
{
    class Ej_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_06";
            Console.Write("Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no. Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.\n\n");

            float anio;

            Console.Write("Ingrese año: ");

            anio = float.Parse(Console.ReadLine());

            // Calculo
            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
            {
                Console.WriteLine("Es biciesto");
            }
            else
            {
                Console.WriteLine("No es biciesto");
            }

            Console.ReadKey();
        }
    }
}