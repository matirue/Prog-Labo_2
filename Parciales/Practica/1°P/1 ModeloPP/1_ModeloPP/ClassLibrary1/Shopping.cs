using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Shopping
    {
        #region Atributos
        private int _capacidad; //capacidad maxima para comercios
        private List<Comercio> _comercios; //coleccion generica
        #endregion

        #region Propiedades

        public double PrecioDeExportadores { get { return this.ObtenerPrecio(EComercio.Exportador); } }
        public double PrecioDeImportadores { get { return this.ObtenerPrecio(EComercio.Importador); } }
        public double PrecioTotal { get { return this.ObtenerPrecio(EComercio.Ambos); } }
        //public double PrecioTotal { get { return this.ObtenerPrecio(EComercio.Exportador) + this.ObtenerPrecio(EComercio.Importador); } }

        #endregion

        #region Constructor
        private Shopping()
        {
            this._comercios = new List<Comercio>();
        }
        private Shopping(int capacida) : this()
        {
            this._capacidad = capacida;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Retorna una cadena con la informacion del shopping mas el detalle de cada uno de los comercios
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Mostrar(Shopping s)
        {
            StringBuilder x = new StringBuilder();

            x.AppendFormat("Capacidad del shopping: {0}\n",  s._capacidad);
            x.AppendFormat("Total por Importadores: ${0}\n",  s.PrecioDeImportadores);
            x.AppendFormat("Total por Exportadores: ${0}\n",  s.PrecioDeExportadores);
            x.AppendFormat("Total: ${0}\n",  s.PrecioTotal);

            x.AppendFormat("************************************************");
            x.AppendLine("\nListado de Comercios:");
            x.AppendFormat("************************************************");

            foreach(Comercio c in s._comercios)
            {
                x.AppendLine(" ");

                if (c is Importador)
                    x.AppendLine(((Importador)c).Mostrar());
                if (c is Exportador)
                    x.AppendLine(((Exportador)c).Mostrar());
            }

            return x.ToString();
        }

        /// <summary>
        /// retorna valor del shopping de acuerdo al enumerado que recibe como parametro.
        /// </summary>
        /// <param name="tipoComercio"></param>
        /// <returns></returns>
        private double ObtenerPrecio(EComercio tipoComercio)
        {
            double retorno = 0;

            foreach (Comercio x in this._comercios)
            {
                switch (tipoComercio)
                {
                    case (EComercio.Importador):
                        if (x is Importador)
                            retorno += ((Importador)x);
                        break;

                    case (EComercio.Exportador):
                        if (x is Exportador)
                            retorno += ((Exportador)x);
                        break;

                    //case (EComercio.Ambos):
                    default:
                        if (x is Importador)
                            retorno += ((Importador)x);
                        if (x is Exportador)
                            retorno += ((Exportador)x);
                        break;
                }

            }
            return retorno;
        }


        #endregion

        #region Operadores

        /// <summary>
        /// Retorna la instancia de shopping donde coincide con el parametro
        /// </summary>
        /// <param name="capacidad"></param>
        public static implicit operator Shopping (int capacidad)
        {
            Shopping s = new Shopping(capacidad);
            return s;
        }

        /// <summary>
        /// retorna true si comercio ya se encuentra en el shopping
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator ==(Shopping s, Comercio c)
        {
            foreach(Comercio x in s._comercios)
            {
                if (x == c)
                {
                    return true;
                    break;
                }                    
            }
            return false;
        }
        public static bool operator !=(Shopping s, Comercio c)
        {
            return !(s == c);

        }

        /// <summary>
        /// Agrega el comercio al shopping en caso de tenga espacio.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Shopping operator +(Shopping s, Comercio c)
        {
            if (s != c)
            {
                s._comercios.Add(c);
            }
            else
            {
                Console.WriteLine("\n No hay mas espacion en el shopping para este comercio!!!!");
            }
            return s;
        }
        #endregion
    }
}
