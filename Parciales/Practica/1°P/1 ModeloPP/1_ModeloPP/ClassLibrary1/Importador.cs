using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Importador : Comercio
    {
        #region Atributo
        public EPaises paisOrigen;
        #endregion

        #region Constructor

        public Importador(string nombreComercio, float precioAlquiler, Comerciante comerciante, EPaises paisOrigen)
            : base(nombreComercio, comerciante, precioAlquiler)
        {
            this.paisOrigen = paisOrigen;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Mostrara  el contenido del objeto de esta clase
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder x = new StringBuilder();

            x.AppendLine((string)this);
            x.AppendFormat("-Pais de origen: {0}", this.paisOrigen);

            return x.ToString();
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Retorna true en caso de que los comerciantes y pais de origen sean iguales
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Importador a, Importador b)
        {
            if (a._comerciante == b._comerciante && b.paisOrigen == a.paisOrigen)
                return true;

            return false;
        }
        public static bool operator !=(Importador a, Importador b)
        {
            return !(a == b);
        }


        /// <summary>
        /// Retorna el precio de aqluiler del parametro que recibe
        /// </summary>
        /// <param name="m"></param>
        public static implicit operator double(Importador m)
        {
            return m._precioAlquiler;
        }
        #endregion
    }
}
