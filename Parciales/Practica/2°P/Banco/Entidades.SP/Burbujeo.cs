using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.SP
{
    public class Burbujeo
    {
        public static void MetodoClase()
        {
            try
            {

                new Burbujeo().MetodoInstancia();

            }            
            catch(MiException ex)
            {
                ex.Data.Add("MetodoClase-" + DateTime.Now.ToString("HH:mm:ss"), 1);
                throw ex;
            }
        }

        public void MetodoInstancia()
        {
            MiException ex = new MiException();
            ex.Data.Clear();
            ex.Data.Add("MetodoInstancia-" + DateTime.Now.ToString("HH:mm:ss"), 0);
            throw ex;
        }
    }
}
