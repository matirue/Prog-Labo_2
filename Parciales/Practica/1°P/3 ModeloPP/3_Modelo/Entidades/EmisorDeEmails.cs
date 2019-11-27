using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmisorDeEmails : Emisor
    {
        #region Atributos

        private string _email;
        private bool _enviado;

        #endregion


        #region Constructores

        public EmisorDeEmails(string mensaje, EProducto producto, string email) : base (mensaje, producto)
        {
            this._email = email;
            this._enviado = false;
        }

        #endregion


        #region Metodos

        public override string enviarMensaje()
        {
            StringBuilder sb = new StringBuilder();

           if (this._enviado == true)
            {
                sb.AppendFormat("EMAIL: {0} - Confirmacion: {1}", this._email, this._enviado + " .Error, el mensaje ya fue enviado​");
            }
              
           else
            {
                 sb.AppendFormat("EMAIL: {0} - Confirmacion: {1}", this._email, this._enviado + " .Se envia el mensaje");
                 this._enviado = true;
            }

           return sb.ToString();
        }


        public static explicit operator string(EmisorDeEmails emisor)
        {
            return emisor.enviarMensaje();
        }

        #endregion
    }
}
