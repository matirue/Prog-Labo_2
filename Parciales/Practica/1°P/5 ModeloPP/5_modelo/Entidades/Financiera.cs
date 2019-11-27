using System;
using System.Collections.Generic;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
            #region Atributos
            private string razonSocial;
            private List<Prestamo> listaDePrestamos;
            #endregion

            #region Propiedades
            public float InteresesEnDolares
            {
                get {
                    return this.CalcularInteresGanado(TipoDePrestamo.Dolares);
                }
            }

            public float InteresesPesos
            {
                get {
                    return this.CalcularInteresGanado(TipoDePrestamo.Pesos);
                }
            }

            public float InteresesTotales
            {
                get {
                    return this.CalcularInteresGanado(TipoDePrestamo.Todos);
                }
            }


            public string RazonSocial
            {
                get {
                    return this.razonSocial;
                }
            }

            public List<Prestamo> ListaDePrestamos
            {
                get {
                    return this.listaDePrestamos;
                }
            }
            #endregion

            #region Constructores
            private Financiera()
            {
                this.listaDePrestamos = new List<Prestamo>();
            }

            public Financiera(string RazonSocial) : this()
            {
                this.razonSocial = RazonSocial;
            }
            #endregion

            #region Metodos
            public static string Mostrar(Financiera financiera)
            {
                return (string)financiera;
            }

            public static explicit operator string(Financiera financiera)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("\nRazon social {0}", financiera.RazonSocial);
                sb.AppendFormat("\nPrestamos otorgados {0}\nPrestamos en Pesos {1}\nPrestamos en Dolares {2}", financiera.InteresesTotales, financiera.InteresesPesos, financiera.InteresesEnDolares);
                financiera.OrdenarPrestamos();
                foreach (Prestamo item in financiera.ListaDePrestamos)
                {
                    sb.AppendLine(item.Mostrar());
                }
                return sb.ToString();

            }

            public void OrdenarPrestamos()
            {
                this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
            }

            private float CalcularInteresGanado(TipoDePrestamo tipoDePrestamo)
            {
                float interesDolar = 0;
                float interesPeso = 0;
                float interesGeneral = 0;
                float retorno = 0;
                foreach (Prestamo item in this.listaDePrestamos)
                {
                    if (item is PrestamoPeso)
                    {
                        interesPeso += ((PrestamoPeso)item).Interes;
                        interesGeneral += ((PrestamoPeso)item).Interes;
                    }
                    else if (item is PrestamoDolar)
                    {
                        interesDolar += ((PrestamoDolar)item).Interes;
                        interesGeneral += ((PrestamoDolar)item).Interes;
                    }
                }

                switch (tipoDePrestamo)
                {
                    case TipoDePrestamo.Pesos:
                        retorno = interesPeso;
                        break;
                    case TipoDePrestamo.Dolares:
                        retorno = interesDolar;
                        break;
                    case TipoDePrestamo.Todos:
                        retorno = interesGeneral;
                        break;
                    default:
                        break;
                }
                return retorno;
            }

            public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
            {
                financiera.ListaDePrestamos.Add(prestamoNuevo);
                return financiera;
            }

            public static bool operator ==(Financiera financiera, Prestamo prestamo)
            {
                bool retorno = false;
                foreach (Prestamo item in financiera.ListaDePrestamos)
                {
                    if (item == prestamo)
                    {
                        retorno = true;
                    }
                }
                return retorno;
            }

            public static bool operator !=(Financiera financiera, Prestamo prestamo)
            {
                return !(financiera == prestamo);
            }
            #endregion

        }
    }
