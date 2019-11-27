using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        #region Atributos

        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        #endregion


        #region Propiedades

        public int CantidadDePaginas
        {
            get
            {
                int retorno;

                if (this._cantidadDePaginas == 0) // Si la cantidad de paginas es 0, genera una nueva cantidad.
                {
                    retorno = Libro._generadorDePaginas.Next(10, 500);
                }
                else
                {
                    retorno = this._cantidadDePaginas; // Y sino, retorna directamente la cantidad que ya tenga.
                }

                return retorno;
            }
        }

        #endregion


        #region Constructores

        static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }



        public Libro (float precio, string titulo, string nombre, string apellido) : this (titulo, new Autor (nombre, apellido), precio)
        {

        }


        public Libro (string titulo, Autor autor, float precio)
        {
            this._titulo = titulo;
            this._autor = autor;
            this._precio = precio;
        }

        #endregion


        #region Metodos

        private static string Mostrar (Libro l)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("TITULO: {0}\n", l._titulo);
            sb.AppendFormat("CANTIDAD DE PAGINAS: {0}\n", l.CantidadDePaginas);
            sb.AppendLine("Autor: " + l._autor);
            sb.AppendFormat("PRECIO: {0}", l._precio);

            return sb.ToString();

        }


        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }



        public static bool operator == (Libro a, Libro b)
        {
            bool retorno = false;

            if (a._titulo == b._titulo && a._autor == b._autor)
            {
                retorno = true;
            }

            return retorno;
        }


        public static bool operator != (Libro a, Libro b)
        {
            return !(a == b);
        }


        #endregion

    }
}
