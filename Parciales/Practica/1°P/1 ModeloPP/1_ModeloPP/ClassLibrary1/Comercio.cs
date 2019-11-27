using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercio
    {
        #region Atributos
        protected int _cantidadDeEmpleados;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected string _nombre;
        protected float _precioAlquiler;
        #endregion

        #region Propiedades

        /// <summary>
        /// Retornara el valor correspondiente del atributo _cantidadDeEmpleados que se inicializara
        /// en la propiedad  si es creo.
        /// </summary>
        public int CantidadDeEmpleados
        {
            get
            {
                int retorno;

                if (this._cantidadDeEmpleados == 0)
                {
                    retorno = Comercio._generadorDeEmpleados.Next(1, 100);
                }
                else
                {
                    retorno = this._cantidadDeEmpleados;
                }
                    

                return retorno;
            }
        }

        #endregion

        #region Constructor

        //de clase
        static Comercio()
        {
            Comercio._generadorDeEmpleados = new Random();
        }

        //de instancia
        public Comercio(float precioAlquiler, string nombreComercio, string nombre, string apellido)
            : this(nombre, new Comerciante(nombre, apellido), precioAlquiler)
        {

        }
        public Comercio(string nombre, Comerciante comerciante, float precioAlquiler)
        {
            this._nombre = nombre;
            this._comerciante = comerciante;
            this._precioAlquiler = precioAlquiler;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// privado y de clase, muestra una cadena de comercio
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static string Mostrar(Comercio c)
        {
            StringBuilder x = new StringBuilder();
            x.AppendFormat("-Cantidad de empleados: {0} \n", c.CantidadDeEmpleados);
            x.AppendFormat("Nombre: " + c._nombre);
            x.AppendFormat("-Precio de alquiler: ${0}", c._precioAlquiler);

            return x.ToString();
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Retorna el detalle completo del comercio que recibe como parametro.
        /// </summary>
        /// <param name="c"></param>
        public static explicit operator string(Comercio c)
        {
            return Comercio.Mostrar(c);
        }

        /// <summary>
        /// Retorna true en caso de que los comercios y comerciantes sean iguales
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Comercio a, Comercio b)
        {
            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                if (a._nombre == b._nombre && a._comerciante == b._comerciante)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Comercio a, Comercio b)
        {
            return !(a == b);
        }
        #endregion
    }
}

