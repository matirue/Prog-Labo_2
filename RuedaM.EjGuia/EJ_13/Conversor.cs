using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_13
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un numero de decimal a binario
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static string DecimalBinario(double dato)
        {
            return Convert.ToString((int)dato, 2);
        }

        /// <summary>
        /// Convierte un numero de binario a decimal
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public static double BinarioDecimal(string dato)
        {
            double entero = 0;

            for (double i = 0; i < dato.Length; i++)
            {
                entero += double.Parse(dato[i - 1].ToString()) * (double)Math.Pow(2, dato.Length - i);
            }

            return entero;
        }

    }
}
