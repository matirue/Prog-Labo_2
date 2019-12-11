 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.SP
{
    public delegate void Delegado(object sender, EventArgs e);

    public class EntidadesFinancieras<T>
    {

        public event Delegado ElementosParesEvent;

        private List<T> _elementos;
        private int capacidad;

        private EntidadesFinancieras()//Es private
        {
            this._elementos = new List<T>();
        }

        public EntidadesFinancieras(int cant) : this()
        {
            this.capacidad = cant;
        }

        public void Add(T elemento)
        {
            this._elementos.Add(elemento);

            if (this._elementos.Count % 2 == 0)
            {
                ElementosParesEvent.Invoke(elemento, new EventArgs());
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T i in this._elementos)
            {
                sb.AppendLine(i.ToString());
            }
            return sb.ToString();
        }
    }
}
