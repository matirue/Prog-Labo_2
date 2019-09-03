using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2016.Formatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Formatos de Consola";

            Console.WriteLine("Justificando a derecha (valor positivo) y a izquierda (valor negativo):");
            Console.WriteLine("---------- ----------");
            Console.WriteLine("{0,10} {1,-10} {2}", 10, 15, 23);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Estableciendo cantidad máxima de decimales:");
            Console.WriteLine("{0:.0} - {1:#.00} - {2:0.000} - {3}", 10.476864, 0.3558742, 0.9214, 96.3352587);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Mostrando caracteres de puntuación:");
            Console.WriteLine("{0:#,#} - {1:N} - {2} - {3:#,#.00}", 1500, 153558742, 963352587, 85632.3658);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Otros formatos:");
            Console.WriteLine("{0:X} - {1:E} - {2:C} - {3:D10}", 1500, 15355.8742, 963352587, 85632);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Utilizando todo junto:");
            Console.WriteLine("--------------- ----------");
            Console.WriteLine("{0, 15:#,#} {1, -10:#,#.00}", 153558742, 85632.3658);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Mostrando la fecha y hora del sistema:");
            Console.WriteLine("Hoy es: {0:G}", DateTime.Now);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Fecha con formato:");
            Console.WriteLine("Hoy es: {0:dd/MM/yy}", DateTime.Now);
            Console.WriteLine("Hoy es: {0:dd-MM-yy}", DateTime.Now);
            Console.WriteLine("Hoy es: {0:dd/MM/yyyy}", DateTime.Now);
            Console.WriteLine("Hoy es: {0:dd-MM-yyyy}", DateTime.Now);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Fecha con más formato:");
            Console.WriteLine("Hoy es: {0:dddd, dd \\de MMMM \\de yyyy}", DateTime.Now);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Formato para las horas:");
            Console.WriteLine("La hora es: {0:hh:mm:ss}", DateTime.Now);
            Console.WriteLine("La hora es: {0:HH:mm:ss.ff}", DateTime.Now);


            Console.ReadLine();


            //Referencias: 
            //https://msdn.microsoft.com/es-ar/library/s8s7t687.aspx
            //https://msdn.microsoft.com/es-AR/library/8kb3ddd4(v=vs.110).aspx

        }
    }
}
