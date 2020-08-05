using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Crear en la clase Comparadora el método bool GetElDelMedio(int uno, int dos, int tres, out int elDelMedio). 
    //La funcionalidad de este método de clase es la siguiente: Retornará un true, si encuentra el valor medio entre 
    //los tres parámetros recibidos(y lo alojará en el parámetro de salida elDelMedio). Retornará false si no encuentra 
    //un valor medio.Ejemplo 1: uno = 6; dos = 9; tres = 8; => true; elDelMedio = 8. Ejemplo 2: uno = 5; dos = 1; 
    //tres = 5; => false; elDelMedio = 0
    //Hacer un Test Unitario para el ingreso de: 3, 5, 4;  5, 4, 4;  5, 1, 2; y  1, 1, 0.
    public class Comparadora
    {
        public static bool GetElDelMedio(int uno, int dos, int tres, out int elDelMedio)
        {
            elDelMedio = 0;
            if((uno < dos && uno > tres) || (uno > dos && uno < tres))
            {
                elDelMedio = uno;
                return true;
            }
            else if((dos > uno && dos < tres) || (dos < uno && dos > tres))
            {
                elDelMedio = dos;
                return true;
            }
            else if((tres > dos && tres < uno) || (tres < dos && tres > uno))
            {
                elDelMedio = tres;
                return true;
            }
            return false;
        }
    }
}
