﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N (char c)
        {          
            if(c == 's' || c == 'S')
            {
                return true;
            }

            return false;
        }
    }
}
