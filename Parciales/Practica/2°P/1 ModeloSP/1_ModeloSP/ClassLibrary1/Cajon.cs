using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cajon<T>
    {
        #region Campos
        int _capacidad;
        List<T> _frutas;
        float _precioUnitario;
        #endregion

        #region Prop
        public List<T> Fruta { get { return this._frutas; } }
        public float PrecioTotal { get { return this._precioUnitario; } }
        #endregion

        #region Metodos
        public Cajon()
        {
            this._frutas = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }
        
        public Cajon(int capacidad, float precio) : this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad: " + this._capacidad);
            sb.AppendFormat("Cantidad de Frutas: " + this._frutas.Count);
            sb.AppendFormat("Precio Total: " + this.PrecioTotal);

            foreach(T x in this._frutas)
            {
                if (x != null)
                {
                    sb.AppendLine(x.ToString());
                }
            }

            return sb.ToString();
        }

        public static Cajon<T> operator + (Cajon<T> c, T t)
        {
            if(c._capacidad >= c._frutas.Count + 1)
            {
                if (c.PrecioTotal <= 55)
                {
                    c._frutas.Add(t);
                }
            }
            else
            {
                throw new CajonLlenoException("El cajon esta lleno.");
            }

            return c;
        }
        #endregion
    }
}
