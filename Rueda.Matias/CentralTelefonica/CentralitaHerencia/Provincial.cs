using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : LLamada
    {
        #region Atributos
        protected EFranja _fanjaHoraria;
        #endregion

        #region Propiedad
        public override float CostoLlamadas { get { return this.CalcularCosto(); } }
        #endregion

        #region Metodos

        //calcula el costo de la llamada segun la franja
        private float CalcularCosto()
        {
            float costo = 0;

            switch (_fanjaHoraria)
            {
                case (EFranja.Franja_1):
                    costo = (float)(0.99 * this.Duracion);
                    break;

                case (EFranja.Franja_2):
                    costo = (float)(1.25 * this.Duracion);
                    break;

                case (EFranja.Franja_3):
                    costo = (float)(0.66 * this.Duracion);
                    break;
            }
            return costo;
        }

        public override bool Equals(Object obj)
        {
            if (obj is Provincial)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Lista la llamada heredada anexano el costo de la misma y su franja
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            //return base.Mostrar() + "";
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat(base.Mostrar());
            retorno.AppendFormat(" -- Franja: {0}", this._fanjaHoraria);
            retorno.AppendFormat(" -- Costo de la llamada: ${0}", this.CostoLlamadas);
            return retorno.ToString();
        }


        #region Constructor

        public Provincial(string origen,EFranja miFanja, float duracion, string destino)
            :base(origen,destino,duracion)
        {
            this._fanjaHoraria = miFanja;
        }
        public Provincial(EFranja miFranja, LLamada unaLlamada)
            :this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {
        }

        #endregion


        /// <summary>
        /// LLama al mostarr protegido
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }

}
