using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        public delegate void AvisoFinCallback(string mensaje);
        public event AvisoFinCallback AvisoFin;

        private int id;
        private List<InfoHilo> misHilos;

        string rutaArchivo;
        StreamReader leerArchivo;
        StreamWriter guardaArchivo;

        #region Propiedades

        public string Bitacora
        {
            get
            {
                try
                {
                    string datosArchivo;
                    rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    leerArchivo = new StreamReader(rutaArchivo + "\\bitacora.txt", true);

                    datosArchivo = leerArchivo.ReadToEnd();
                    return datosArchivo;
                }
                catch(IOException exception)
                {
                    throw exception;
                }
                finally
                {
                    leerArchivo.Close();
                }
            }
            set
            {
                try
                {
                    rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    guardaArchivo = new StreamWriter(rutaArchivo+"\\bitacora.txt",true);

                    guardaArchivo.WriteLine(value);
                }
                catch(IOException exception)
                {
                    throw exception;
                }
                finally
                {
                    guardaArchivo.Close();
                }
            }
        }

        #endregion

        #region Métodos

        public static LosHilos AgregarHilo(LosHilos hilos)
        {
            hilos.id++;

            hilos.misHilos.Add(new InfoHilo(hilos.id, hilos));

            return hilos;
        }

        public LosHilos()
        {
            this.id = 0;
            this.misHilos = new List<InfoHilo>();
        }

        public void RespuestaHilo(int id)
        {
            string mensaje = String.Format("Terminó el hilo {0}", id);

            this.Bitacora = mensaje;
            this.AvisoFin(mensaje);
        }

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if(cantidad >= 1)
            {
                for(int i = 0;i < cantidad;i++)
                {
                    LosHilos.AgregarHilo(hilos);
                }
                return hilos;
            }
            else
            {
                throw new CantidadInvalidaException();
            }
        }

        #endregion
    }
}
