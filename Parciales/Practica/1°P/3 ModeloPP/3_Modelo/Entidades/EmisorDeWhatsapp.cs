using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmisorDeWhatsapp : Emisor
    {
        #region Atributos

        private bool _numeroCargado;
        private int _numeroTelefono;

        #endregion


        #region Constructores

        public EmisorDeWhatsapp (string mensaje, EProducto producto) : base(mensaje, producto)
        {
        
        }

        #endregion


        #region Propiedades


        public int NumeroTelefono
        {
            get
            {
                int retorno = 0;

                if (this._numeroTelefono > 1500000000  && this._numeroTelefono < 1599999999)
                {
                    retorno = this._numeroTelefono;
                }
                else
                {
                    this._numeroCargado = false;
                }

                return retorno;
            }
            set
            {
                this._numeroTelefono = value;
            }

        }
        #endregion


        #region Metodos


        public override string enviarMensaje()
        {
            StringBuilder sb = new StringBuilder();

            if (this._numeroCargado == true)
            {
                sb.AppendFormat("Numero: {0} - Confirmacion: {1}", this._numeroTelefono, this._numeroCargado + " Enviando mensaje​");
            }

            else
            {
                sb.AppendFormat("Numero: {0} - Confirmacion: {1}", this._numeroTelefono, this._numeroCargado + " No se pudo enviar mensaje");
            }

            return sb.ToString();
        }


        public static explicit operator string(EmisorDeWhatsapp emisor)
        {
            return emisor.enviarMensaje();
        }

        #endregion
    }
}
