using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        #region Atributos
        private List<LLamada> _listaDeLlamadas;
        protected string _razonSocial;
        #endregion

        #region Propiedades

        public float GananciaPorLocal { get { return this.CalcularGanancia(ETipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return this.CalcularGanancia(ETipoLlamada.Provincial); } }
        public float GananciaTotal { get { return this.CalcularGanancia(ETipoLlamada.Todas); } }
        public List<LLamada> Llamadas { get { return this._listaDeLlamadas; } }

        #endregion

        #region Metodos

        /// <summary>
        /// agrega nuevaLlamada a mi lista
        /// </summary>
        /// <param name="nuevaLlamada"></param>
        private void AgregarLlamada(LLamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        /// <summary>
        /// calcla la ganancia segun el tipo
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public float CalcularGanancia(ETipoLlamada tipo)
        {
            float ganancia = 0;

            foreach (LLamada aux in this._listaDeLlamadas)
            {
                if ((tipo is ETipoLlamada.Local) && (aux is Local))
                {
                    ganancia += ((Local)aux).CostoLlamadas;
                }
                else if ((tipo is ETipoLlamada.Provincial) && (aux is Provincial))
                {
                    ganancia += ((Provincial)aux).CostoLlamadas;
                }
                else if ((tipo is ETipoLlamada.Todas))
                {
                    if (aux is Local)
                        ganancia += ((Local)aux).CostoLlamadas;
                    if (aux is Provincial)
                        ganancia += ((Provincial)aux).CostoLlamadas;
                }
            }
            return ganancia;
        }


        #region Costructor
        //reserva memoria a la lista y la crea
        public Centralita()
        {
            this._listaDeLlamadas = new List<LLamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion

        #region Operadores

        public static bool operator ==(Centralita central, LLamada nuevaLlamada)
        {
            bool flag = false;
            if (!Object.Equals(central, null) && !Object.Equals(nuevaLlamada, null))
            {
                foreach (LLamada x in central._listaDeLlamadas)
                {
                    if (x == nuevaLlamada)
                    {
                        flag = true;
                        break;
                    }                    
                }
            }
            return flag;
        }
        public static bool operator !=(Centralita central, LLamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central, LLamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
                central.AgregarLlamada(nuevaLlamada);
            else
                Console.WriteLine("\n +++ La llamada ya existe en mi lista +++ \n");

            return central;
        }

        #endregion

        public void OrdenarLLamadas()
        {
            this._listaDeLlamadas.Sort(LLamada.ordenarPorDuracion);
        }

        /// <summary>
        /// Reemplaza al mostrar
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            foreach(LLamada aux in this.Llamadas)
            {
                if (aux is Local)
                    ret.AppendFormat(((Local)aux).ToString());
                if (aux is Provincial)
                    ret.AppendFormat(((Provincial)aux).ToString());
            }
            return ret.ToString();
        }
        #endregion
    }
}
