using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17.DepositosAutos
{
    public class Deposito<T>
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<T> _lista;
        #endregion

        #region Constructor

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        #endregion

        #region Operadores


        /// <summary>
        ///  Retorna true, si pudo agregar el objeto T al depósito de T, false, caso contrario.
        ///  Para poder agregar un objeto T a la lista genérica hay que tener en cuenta que la 
        ///  capacidad máxima del depósito no puede ser superada.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator +(Deposito<T> d, T a)
        {
            if(!Object.Equals(d,a) && d._lista.Count < d._capacidadMaxima )
            {
                d._lista.Add(a);
                return true;
            }

            return false;
        }


        public static bool operator -(Deposito<T> d, T a)
        {
            int indice = d.GetIndice(a);

            if (indice != -1)
            {
                d._lista.Remove(a);
                return true;
            }
            else
                return false;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Retorna el valor del índice en el cual se encuentra el objeto T 
        /// pasada como parámetro. Se debe recorrer la lista genérica y retornar 
        /// el índice de la primera ocurrencia, -1 si no se encuentra en la lista.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int GetIndice(T a)
        {
            int indice = -1;
            int cont = 0;
            foreach(T x in this._lista)
            {
                if (x.Equals(a))
                    indice = cont;

                cont++;
            }
            return indice;
        }

        /// <summary>
        /// Está asociado al operador +.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Agregar(T a)
        {
            return (this + a);
        }

        /// <summary>
        /// Está asociado al operador -.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Remover(T a)
        {
            return (this - a);
        }
        
        /// <summary>
        /// Retorna una cadena conteniendo la información del depósito T 
        /// (capacidad y todo el detalle de los objetos T que contiene).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder x = new StringBuilder();
            x.AppendFormat("Capacidad Max: {0} \n", this._capacidadMaxima);
            x.AppendFormat("Lista del deposito:\n");

            foreach(T a in this._lista)
            {
                x.AppendFormat(a.ToString());
            }

            return x.ToString();
        }

        #endregion
    }
}
