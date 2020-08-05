using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        #region atributos

        protected Fabricante fabricante;
        protected static Random generadorDeVelocidad;
        protected string modelo;
        protected float precio;
        protected int velocidadMAxima;

        #endregion

        #region Propiedad

        public int VelocidadMaxima
        { get
            {
                if (this.velocidadMAxima == 0)
                {
                    generadorDeVelocidad = new Random();
                    this.velocidadMAxima = generadorDeVelocidad.Next(100, 280);
                }
                return this.velocidadMAxima;
                
            }
        }

        #endregion

        #region Constructores

        static Vehiculo()
        {
            Vehiculo.generadorDeVelocidad = new Random();
        }
        public Vehiculo(float precio,string modelo,Fabricante fabri)
        {
            this.fabricante = fabri;
            this.precio = precio;
            this.modelo = modelo;
        }
        public Vehiculo(string marca, EPais pais,string modelo, float precio)
            :this(precio,modelo,new Fabricante(marca,pais))
        {

        }

        #endregion

        #region Metodos

        protected static string Mostrar(Vehiculo v)
        {
            StringBuilder x = new StringBuilder();
            x.AppendFormat("-FABRICANTE: {0} \n", (String)v.fabricante);

            x.AppendFormat("-MODELO: {0} \n" ,v.modelo);
            x.AppendFormat("-VELOCIDAD MAXIMA: {0} \n", v.VelocidadMaxima );
            x.AppendFormat("-PRECIO: ${0}", v.precio);
            //x.AppendFormat("-PRECIO: ${0}", v.precio);

            return x.ToString();
        }


        #endregion

        #region Operador

        /// <summary>
        /// TRUE si modelo y fabricante son iguales
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            if(!Object.Equals(a,null) && !Object.Equals(b, null))
            {
                if (a.modelo == b.modelo && a.fabricante == b.fabricante)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Muestra el objeto que recibe como parametro
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator String(Vehiculo v)
        {
            return Vehiculo.Mostrar(v);
        }
        #endregion
    }
}
