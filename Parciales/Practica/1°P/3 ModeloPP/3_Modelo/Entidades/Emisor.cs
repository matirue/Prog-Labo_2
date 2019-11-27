using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Emisor
    {
        #region Atributos

        private string _mensaje;
        private EProducto _producto;

        #endregion


        #region Constructores

        protected Emisor (string mensaje, EProducto producto)
        {
            this._mensaje = mensaje;
            this._producto = producto;
        }

        #endregion


        #region Metodos

        public abstract string enviarMensaje();


        public static bool operator == (Emisor emisor, Emisor emisorDos)
        {
            bool retorno = false;

            if (emisor._mensaje == emisorDos._mensaje && emisor._producto == emisorDos._producto)
            {
                retorno = true;
            }

            return retorno;
        }


        public static bool operator != (Emisor emisor, Emisor emisorDos)
        {
            return !(emisor == emisorDos);
        }


        public override string ToString()
        {
            return string.Format("Producto: {0} - Mensaje: {1}", this._producto, this._mensaje);
        }



        #endregion


    }
}
