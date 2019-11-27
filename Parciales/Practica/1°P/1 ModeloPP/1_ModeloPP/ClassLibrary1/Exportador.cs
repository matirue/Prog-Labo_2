using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Exportador : Comercio
    {
        #region Atributo
        public ETipoProducto tipo;
        #endregion

        #region Constructor

        public Exportador(string nombreComercio, float precioAlquiler, string nombre, string apellido, ETipoProducto tipo)
            : base(precioAlquiler, nombreComercio, nombre, apellido)
        {
            this.tipo = tipo;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Publico de instancia, muestra la info completa del objeto
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder x = new StringBuilder();
            x.AppendLine((string)this);

            x.AppendFormat("-Tipo: {0}", this.tipo);

            return x.ToString();
        }

        #endregion

        #region Operadores

        /// <summary>
        /// retorna true en caso de que los comercios y tipos son iguales
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Exportador a, Exportador b)
        {
            if (a._nombre == b._nombre && a.tipo == b.tipo)
                return true;

            return false;
        }
        public static bool operator !=(Exportador a, Exportador b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Retorna el precio de alquiler del comercio exportador
        /// </summary>
        /// <param name="m"></param>
        public static implicit operator double(Exportador m)
        {
            return m._precioAlquiler;
        }

        #endregion
    }
}
