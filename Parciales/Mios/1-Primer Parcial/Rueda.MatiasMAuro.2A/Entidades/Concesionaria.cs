using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concesionaria
    {
        #region Atriburtos
        private int capacidad; //capacidad maxima de la concesionaria
        private List<Vehiculo> vehiculos; //coleccion generica de vehiculos
        #endregion

        #region Propiedades
        public double PrecioDeAutos { get { return this.ObtenerPrecio(EVehiculo.PrecioDeAutos); } }
        public double PrecioDeMotos { get { return this.ObtenerPrecio(EVehiculo.PrecioDeMotos); } }
        public double PrecioTotal { get { return this.ObtenerPrecio(EVehiculo.PrecipTotal); } }
        #endregion

        #region Constructor
        private Concesionaria()
        {
            vehiculos = new List<Vehiculo>();
        }
        private Concesionaria(int capacidad):this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region Operador

        /// <summary>
        /// Retorna true si el vehiculo se encuentra en la lista
        /// </summary>
        /// <param name="c"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool operator ==(Concesionaria c, Vehiculo v)
        {
            foreach (Vehiculo x in c.vehiculos)
            {
                //if (x==v)
                //{
                //    return true;
                //    break;
                //}

                if(x is Auto && v is Auto)
                {
                    if((Auto)x == (Auto)v)
                    {
                        return true;
                        break;
                    }
                }

                if(x is Moto && v is Moto)
                {
                    if((Moto)x == (Moto)v)
                    {
                        return true;
                        break;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        /// <summary>
        /// agrega el vehiculo si hay lugar y no se encuentra en la lista
        /// </summary>
        /// <param name="c"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Concesionaria operator +(Concesionaria c, Vehiculo v)
        {
            int cont = 0;
            foreach(Vehiculo x in c.vehiculos)
            {
                cont++;
            }

            if(c!=v && !Object.Equals(c,v) && cont<c.capacidad)
            {
                c.vehiculos.Add(v);
                Console.WriteLine("\n El vehiculo ya esta en la concecionaria!!!!");
            }
            else
            {
               Console.WriteLine("\n No hay mas lugar en la conceciionaria!!!!");
            }
            return c;
        }

        /// <summary>
        /// Retorna la instancia de concesionaria cuya capacidad
        /// </summary>
        /// <param name="capacidad"></param>
        public static implicit operator Concesionaria(int capacidad)
        {
            Concesionaria s = new Concesionaria(capacidad);
            return s;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// retorna el precio del vehiculo
        /// </summary>
        /// <param name="tipoVehiculo"></param>
        /// <returns></returns>
        private double ObtenerPrecio(EVehiculo tipoVehiculo)
        {
            double retorno = 0;

            foreach (Vehiculo x in this.vehiculos)
            {
                switch (tipoVehiculo)
                {
                    case (EVehiculo.PrecioDeAutos):
                        if (x is Auto)
                            retorno += (Double)((Auto)x);
                        break;

                    case (EVehiculo.PrecioDeMotos):
                        if (x is Moto)
                            retorno += ((Moto)x);
                        break;

                    //case (EComercio.Ambos):
                    default:
                        if (x is Auto)
                            retorno += (Double)((Auto)x);
                        if (x is Moto)
                            retorno += ((Moto)x);
                        break;
                }

            }
            return retorno;
        }

        public static string Mostrar(Concesionaria c)
        {
            StringBuilder x = new StringBuilder();

            x.AppendFormat("Capacidad: {0}\n", c.capacidad);
            x.AppendFormat("Total de autos: {0}\n", c.PrecioDeAutos);
            x.AppendFormat("Total de motos: {0}\n", c.PrecioDeMotos);
            x.AppendFormat("Total: {0}\n", c.PrecioTotal);

            x.AppendFormat("************************************************");
            x.AppendLine("\nListado de Vehiculos:");
            x.AppendFormat("************************************************");

            foreach (Vehiculo v in c.vehiculos)
            {
                x.AppendLine(" ");

                if (v is Auto)                
                    x.AppendLine(((Auto)v).ToString());                       
                    
                if (v is Moto)
                    x.AppendLine(((Moto)v).ToString());
            }

            return x.ToString();
        }
        #endregion
    }
}
