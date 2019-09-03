using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class ClaseError:ClaseBase
    {

        #region Constructores

        public ClaseError()
            : base(1)
        { }

        #endregion

        #region Métodos

        public void Falla(ClaseBase t)
        {
            //Console.WriteLine(t._edad);
        }
        public void Compila()
        {
            Console.WriteLine(_edad);
            Console.WriteLine(this.Id);
        }

        #endregion

    }
}
