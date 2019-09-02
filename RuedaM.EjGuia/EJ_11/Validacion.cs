using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_11
{
    public class Validacion
    {
        public static bool Validar (int valor, int min, int max)
        {
            bool retorno = true;
            
            if(!(valor<=max && valor >= min))
            {
                retorno = false;
            }
             
            return retorno;
        }
    }
}
