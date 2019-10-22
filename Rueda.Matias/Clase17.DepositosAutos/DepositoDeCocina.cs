using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17.DepositosAutos
{
    public class DepositoDeCocina
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<Cocina> _lista;
        #endregion

        #region Constructor

        public DepositoDeCocina(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Retorna true, si pudo agregar la cocina al depósito de cocinas, false, caso contrario.
        /// Para poder agregar una cocina a la lista genérica hay que tener en cuenta que la capacidad 
        /// máxima del depósito no puede ser superada.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator +(DepositoDeCocina d, Cocina c)
        {
      
            if (!Object.Equals(d, c) && d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                return true;
            }
            return false;
        }


        public static bool operator -(DepositoDeCocina d, Cocina c)
        {
            int indice = d.GetIndice(c);

            if (indice != -1)
            {
                d._lista.Remove(c);
                return true;
            }
            else
                return false;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Retorna el valor del índice en el cual se encuentra el cocina pasado como parámetro.
        /// Se debe recorrer la lista genérica y retornar el índice de la primera ocurrencia,
        /// -1 si no se encuentra en la lista.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int GetIndice(Cocina c)
        {
            int indice = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i] == c)
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
        /// <param name="c"></param>
        /// <returns></returns>
        public bool Agregar(Cocina c)
        {
            return (this + c);
        }

        /// <summary>
        /// Está asociado al operador -.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool Remover(Cocina c)
        {
            return (this - c);
        }

        /// <summary>
        /// Retorna una cadena conteniendo la información del depósito de cocinas 
        /// (capacidad y todo el detalle de las cocinas que contiene).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder x = new StringBuilder();
            x.AppendFormat("Capacidad max: {0} \n", this._capacidadMaxima);
            x.AppendFormat("Lista de <cocinas: \n");

            foreach(Cocina c in this._lista)
            {
                x.AppendFormat(c.ToString());
            }

            return x.ToString();
        }


        #endregion
    }
}
