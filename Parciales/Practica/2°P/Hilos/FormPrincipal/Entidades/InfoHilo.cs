using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Interfaces;

namespace Entidades
{
    public class InfoHilo
    {
        private IRespuesta<int> callback;
        private Thread hilo;
        private int id;
        static Random randomizer;

        #region Métodos

        private void Ejecutar()
        {   
            Thread.Sleep(randomizer.Next(1000, 5000));
            this.callback.RespuestaHilo(this.id);
        }

        private InfoHilo()
        {
            randomizer = new Random();
            this.hilo = new Thread(this.Ejecutar);
            this.hilo.Start();
        }

        public InfoHilo(int id, IRespuesta<int> callback) : this()
        {
            this.id = id;
            this.callback = callback;
        }

        #endregion


    }
}
