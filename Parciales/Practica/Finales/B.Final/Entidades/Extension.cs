using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Realizar un método de extensión, llamado EsPar, para la clase Int32, que permita determinar si el número es par o no.
    //Crear otro método de extensión, llamado EsImpar, para la clase Int32, que determine si el número es impar o no.Reutilizar código.
    //Realizar un Test Unitario para verificar los métodos anteriores.
    public static class Extension
    {
        //Realizar un método de extensión, llamado EsPar, para la clase Int32, que permita determinar si el número es par o no.
        public static bool EsPar(this Int32 numero)
        {
            if (numero % 2 == 0)
                return true;
            return false;
        }

        //Crear otro método de extensión, llamado EsImpar, para la clase Int32, que determine si el número es impar o no.Reutilizar código.
        public static bool EsImpar(this Int32 numero)
        {
            return !(EsPar(numero));
        }
    }
}
