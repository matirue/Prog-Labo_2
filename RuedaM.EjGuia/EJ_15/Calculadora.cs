using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_15
{
    class Calculadora
    {
        public static double Calcular(double n1, double n2, int op)
        {
            double retorno = 0;
            switch (op)
            {
                case 1:
                    retorno = n1 + n2;
                    break;

                case 2:
                    retorno = n1 - n2;
                    break;

                case 3:
                    retorno = n1 * n2;
                    break;

                case 4:
                    if (Validar(n2))
                    {
                        retorno = n1 / n2;
                    }
                    else
                    {
                        Console.WriteLine("\n------ Error, el divisor no debe ser cero -------");
                        Console.ReadKey();
                        System.Environment.Exit(1);
                        break;
                    }
                    break;
            }
            return retorno;
        }

        private static bool Validar(double n)
        {
            bool retorno = false;
            if (n != 0)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
