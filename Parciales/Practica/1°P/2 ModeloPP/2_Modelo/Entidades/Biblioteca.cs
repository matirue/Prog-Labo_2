using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {

        #region Atributos

        private int _capacidad;
        private List<Libro> _libros;

        #endregion


        #region Propiedades

        public double PrecioDeManuales
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Manual);

            }
        }


        public double PrecioDeNovelas
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Novela);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Ambos);

            }
        }

        #endregion


        #region Constructores

        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        #endregion


        #region Metodos


        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca b = new Biblioteca(capacidad);

            return b;
        }

  

        public static string Mostrar(Biblioteca e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad de la biblioteca: {0}\n", e._capacidad);
            sb.AppendFormat("Total por Manuales: $ {0:#.##}\n", e.PrecioDeManuales);
            sb.AppendFormat("Total por Novelas: $ {0:#.##}\n", e.PrecioDeNovelas);
            sb.AppendFormat("Total: $ {0:#.##}\n", e.PrecioTotal);
            sb.AppendLine("****************************************");
            sb.AppendLine("Listado de Libros");
            sb.AppendFormat("****************************************");

            foreach (Libro item in e._libros)
            {
                sb.AppendLine("");
                if (item is Manual)
                {
                    sb.AppendLine(((Manual)item).Mostrar());
                }
                else if (item is Novela)
                {
                    sb.AppendLine(((Novela)item).Mostrar());
                }
            }

            return sb.ToString();
        }


        private double ObtenerPrecio(ELibro tipolibro)
        {
            double acum = 0;
            foreach (Libro item in this._libros)
            {

                switch (tipolibro)
                {
                    case ELibro.Novela:
                        if (item is Novela)
                        {
                            acum += ((Novela)item);
                        }

                        break;

                    case ELibro.Manual:
                        if (item is Manual)
                        {
                            acum += ((Manual)item);
                        }
                        break;

                    default:

                        if (item is Manual)
                        {
                            acum += ((Manual)item);
                        }
                        if (item is Novela)
                        {
                            acum += ((Novela)item);
                        }

                        break;
                }

            }
            return acum;
        }




        #endregion


        #region Sobrecargas

        public static bool operator ==(Biblioteca b, Libro l)
        {
            bool retorno = false;

            foreach (Libro item in b._libros)
            {
                if (item is Novela && l is Novela)
                {
                    if (((Novela)item) == ((Novela)l))
                    {
                        retorno = true;
                        break;
                    }
                }

                else if (item is Manual && l is Manual)
                {
                    if (((Manual)item) == ((Manual)l))
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }


        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }


        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            if (b == l)
            {
                Console.WriteLine("El libro ya esta en la biblioteca");

            }
            else
            {
                if (b._libros.Count + 1 <= b._capacidad)
                {
                    b._libros.Add(l);
                }
                else
                {
                    Console.WriteLine("No hay mas lugar en la biblioteca");
                }

            }
            return b;
        }


        #endregion
    }

}
