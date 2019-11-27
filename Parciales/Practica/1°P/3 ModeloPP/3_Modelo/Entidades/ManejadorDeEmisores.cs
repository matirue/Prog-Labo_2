using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ManejadorDeEmisores
    {
        #region Atributos

        private List<Emisor> _emisores;
        private string _region;

        #endregion


        #region Constructores

        private ManejadorDeEmisores()
        {
            this._emisores = new List<Emisor>();
        }

        public ManejadorDeEmisores(string region) : this()
        {
            this._region = region;
        }

        #endregion


        #region Metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("REGION: {0}\n", this._region);

            sb.AppendLine("****************************************");
            sb.AppendLine("Listado de Emisores");
            sb.AppendFormat("****************************************");

            foreach (Emisor item in this._emisores)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }


        public string EnviarMensajes()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Emisor item in this._emisores)
            {
                sb.AppendLine(item.ToString());
                sb.AppendLine(this._region);
            }

            return sb.ToString();

        }


        #endregion

  
        #region Sobrecargas


        public static bool operator == (ManejadorDeEmisores manejador, Emisor emisor)
        {

            foreach (Emisor emisorB in manejador._emisores)
            {
                if (emisorB == emisor)
                {
                    return true;
                }
            }

            return false;

        }


        public static bool operator != (ManejadorDeEmisores manejador, Emisor emisor)
        {
            return !(manejador == emisor);
        }


        public static bool operator +(ManejadorDeEmisores manejador, Emisor emisor)
        {
            bool retorno = false;

            if (manejador != emisor)
            {
                manejador._emisores.Add(emisor);
                retorno = true;

            }

            return retorno;
        }

        public static bool operator -(ManejadorDeEmisores manejador, Emisor emisor)
        {
            bool retorno = false;

            if (manejador == emisor)
            {
                manejador._emisores.Remove(emisor);
                retorno = true;

            }

            return retorno;
        }


        #endregion
    }
}
