using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17.DepositosAutos
{
    public class Cocina
    {
        #region Atributos
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;
        #endregion

        #region Propiedades
        public int Codigo { get { return this._codigo; } }
        public bool EsIndustrial { get { return this._esIndustrial; } }
        public double Precio { get { return this._precio; } }
        #endregion

        #region Constructor
        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }
        #endregion

        #region Operador
        /// <summary>
        /// true en caso de igualdad en codigo 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Cocina a, Cocina b)
        {
            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                if (a._codigo == b._codigo)
                    return true;
            }

            return false;
        }
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// true si obj es de tipo Cocina y codigos son iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( obj is Cocina && ((Cocina)obj==this) )
                return true;
            else
                return false;
        }

        /// <summary>
        /// retorna un string con codigo, precio e industrial
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cad = "   ->Codigo: " + this._codigo + " - Precio: $" + this._precio + " - Industrial: ";

            if (this._esIndustrial == true)
                return cad + "SI \n";
            else
                return cad + "NO \n";
        }

        #endregion
    }
}
