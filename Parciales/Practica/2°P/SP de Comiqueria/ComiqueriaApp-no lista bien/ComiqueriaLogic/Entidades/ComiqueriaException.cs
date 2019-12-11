using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ComiqueriaLogic.Comun;

namespace ComiqueriaLogic.Entidades
{
    public class ComiqueriaException : Exception, IArchivoTexto
    {
        public ComiqueriaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
            ArchivoTexto.Escribir(this, true);
        }

        #region Implementacion de IArchivoTexto
        public string Ruta
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\log.txt"; }
        }

        public string Texto
        {
            get
            {
                StringBuilder datosException = new StringBuilder((DateTime.Now).ToString());
                datosException.AppendLine(base.Message);
                while (base.InnerException != null)
                {
                    datosException.AppendLine(base.InnerException.Message);
                }
                return datosException.ToString();
            }
        }
        #endregion

    }
}
    