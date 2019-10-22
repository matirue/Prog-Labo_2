using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17.DepositosAutos
{
    public class DepositoDeAutos
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<Auto> _lista;
        #endregion

        #region Constructor
        
        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Retorna true, si pudo agregar el auto al depósito de autos, false, caso contrario.
        /// Para poder agregar un auto a la lista genérica hay que tener en cuenta que la capacidad
        /// máxima del depósito no puede ser superada.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator +(DepositoDeAutos d, Auto a)
        {

            if (!Object.Equals(d, a) && d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Retorna true, si pudo remover el auto del depósito de autos, false, caso contrario.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            int indice = d.GetIndice(a);

            if (indice != -1)
            {
                d._lista.Remove(a);
                //d._lista.RemoveAt(indice);
                return true;
            }
            return false;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Retorna el valor del índice en el cual se encuentra el auto pasado como parámetro.
        /// Se debe recorrer la lista genérica y retornar el índice de la primera ocurrencia,
        /// -1 si no se encuentra en la lista.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int GetIndice(Auto a)
        {
            int indice=-1;
            for(int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i] == a)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        /// <summary>
        /// Está asociado al operador +.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Agregar(Auto a)
        {
            return (this + a);
            
        }

        /// <summary>
        /// Está asociado al operador -.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Remover(Auto a)
        {
            return (this - a);
        }

        /// <summary>
        /// Retorna una cadena conteniendo la información del depósito de autos 
        /// (capacidad y todo el detalle de los autos que contiene)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder x = new StringBuilder();
            x.AppendFormat("Capacidad Max: {0} \n", this._capacidadMaxima);
            x.AppendFormat("Lista de autos: \n");

            foreach(Auto a in this._lista)
            {
                x.AppendFormat(a.ToString());
            }

            return x.ToString(); 
        }


        #endregion
    }
}
