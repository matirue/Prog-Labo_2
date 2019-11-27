using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComiqueriaLogic.Entidades
{
    public static class Formateo
    {
        /// <summary>
        /// Crear en una nueva clase un método de extensión “FormatearPrecio” que extienda el tipo Double 
        /// y devuelva un string con el valor formateado con 2 decimales y el signo $ por delante.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string FormatearPrecio(this double numero)
        {
            return String.Format("$ {0:0.00}", numero);
        }
    }
}