﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02
{
    class Ej_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_02";
            Console.WriteLine("Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: ERROR. ¡Reingresar número!.\n\n");

            int num,cuadrado,cubo;

            Console.Write("Ingrese un numero: ");
            num = int.Parse( Console.ReadLine() );
            /*
            if (num <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
            else
            {
                //cuadrado = num*num;
                //cubo = num*num*num;
                //Console.WriteLine("El cuadrado: {0}",cuadrado);
                //Console.WriteLine("El cubo: {0}", cubo);

                Console.WriteLine("El cuadrado: {0}", Math.Pow(num, 2));
                Console.WriteLine("El cubo: {0}", Math.Pow(num, 3));
            }*/

            while (num <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                num = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Ingreso: {0}", num);
            Console.WriteLine("El cuadrado: {0}", Math.Pow(num, 2));
            Console.WriteLine("El cubo: {0}", Math.Pow(num, 3));
            Console.WriteLine("-------------------------------------------");

            Console.ReadKey();

        }
    }
}