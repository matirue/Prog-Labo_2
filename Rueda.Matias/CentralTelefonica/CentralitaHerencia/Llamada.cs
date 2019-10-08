using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class LLamada
    {
        #region Atributos
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region Propiedades
        //todas laas prop de solo lectura
        public abstract float CostoLlamadas { get; } //prop abtracta

        public float Duracion { get { return this._duracion; } }
        public string NroOrigen { get { return this._nroOrigen; } }
        public string NroDestino { get { return this._nroDestino; } }
        #endregion

        #region Metodos

        #region Constructor

        public LLamada(string origen, string destino, float duracion)
        {
            this._nroDestino = destino;
            this._nroOrigen = origen;
            this._duracion = duracion;
        }
        
        #endregion

        protected virtual string Mostrar()
        {
            //return "\n Origen: " + this._nroOrigen + " /// Destino: " + this._nroDestino + " /// Duracion: " + this._duracion;
            StringBuilder retorna = new StringBuilder();
            retorna.AppendFormat("\n+ Numero de Origen: {0}", this.NroOrigen);
            retorna.AppendFormat(" -- Numero Destino: {0}", this.NroDestino);
            retorna.AppendFormat(" -- Duracion: {0}", this.Duracion);
            return retorna.ToString();
        }

        #region Operadores

        public static bool operator ==(LLamada uno, LLamada dos)
        {
            if (!Object.Equals(uno, null) && !Object.Equals(dos, null))
            {
                if (Object.Equals(uno, dos) && uno._nroOrigen==dos._nroOrigen && uno._nroDestino==dos._nroDestino)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(LLamada uno, LLamada dos)
        {
            return !(uno == dos);
        }
        #endregion

        /// <summary>
        /// Compara y ordena las llamadas segun la duracion.
        /// </summary>
        /// <param name="uno"></param>
        /// <param name="dos"></param>
        /// <returns></returns>
        public static int ordenarPorDuracion(LLamada uno, LLamada dos)
        {
            return string.Compare(uno.Duracion.ToString(), dos.Duracion.ToString());
        }

        #endregion
    }
}
