using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Comun
{
    public class ComiqueriaException : Exception, IArchivoTexto
    {
        public ComiqueriaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
            ArchivoTexto.Escribir(this, true);
        }

        public string Ruta
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\log.txt";
            }
        }

        public string Texto
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(DateTime.Now.ToString());
                sb.AppendLine(base.Message);

                if (!object.ReferenceEquals(base.InnerException, null))
                {
                    Exception ex = base.InnerException;
                    do
                    {
                        sb.AppendLine(ex.Message);
                        ex = ex.InnerException;
                    } while (!object.ReferenceEquals(ex, null));
                }

                return sb.ToString();
            }
        }
    }
}
