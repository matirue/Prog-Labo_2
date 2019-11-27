using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comparadora
    {
        public static bool GetElDelMedio(int uno, int dos, int tres, out int elDelMedio)
        {
            bool retorno = false;
            elDelMedio = 0;
            if ((uno > dos && uno < tres) || (uno < dos && uno > tres))
            {
                retorno = true;
                elDelMedio = uno;
            }
            else if ((dos > uno && dos < tres) || (dos < uno && dos > tres))
            {
                retorno = true;
                elDelMedio = dos;
            }
            else if ((tres > dos && tres < uno) || (tres < dos && tres > uno))
            {
                retorno = true;
                elDelMedio = tres;
            }
            return retorno;
        }
    }
}