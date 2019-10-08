using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : LLamada
    {
        #region Atributos
        protected float _costo;
        #endregion

        #region Propiedades

        public override float CostoLlamadas { get { return CalcularCosto(); } }

        #endregion

        #region Metodos

        /// <summary>
        /// Calcula el costo segundo la duracion de la llamada
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            return this._costo * this._duracion;
        }

        /// <summary>
        /// Compara si obj es de tipo Local
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj is Local)
                return true;
            else
                return false;
        }
        
        
        #region Constructor
        public Local(string origen, float duracion, string destino, float costo) : base(origen, destino,duracion)
        {
            this._costo = costo;
        }
        public Local(LLamada unaLlamada, float costo)
            : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        {

        }
        #endregion


        /// <summary>
        /// Lista la llamada heredada anexano el costo de la misma
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat(base.Mostrar());
            retorno.AppendFormat(" -- Costo de la llamada: ${0}", this.CostoLlamadas);
            return retorno.ToString();
        }

        /// <summary>
        /// Llama al metodo protegido Mostrar
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}
