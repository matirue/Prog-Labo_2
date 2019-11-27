using System;
using System.Collections.Generic;
using System.Text;

namespace PreParcial
{
    public class Grupo
    {
        #region Atributos
        private List<Mascota> _manada;
        private string _nombre;
        private static EtipoManada _tipo;
        #endregion

        #region Propiedades
        public EtipoManada Tipo {
            set {
                _tipo = value;
            }
        }
        #endregion

        #region Metodos

        #region Constructores
        static Grupo(){
           Grupo._tipo = EtipoManada.Unica;
        }
        private Grupo()
        {
            this._manada = new List<Mascota>();
        }

        private Grupo(string nombre) : this()
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre, EtipoManada tipo) : this (nombre)
        {
            this.Tipo = tipo;
        }
        #endregion

        public static implicit operator string(Grupo g)
        {
            string retorno;
            retorno = "Grupo: " + g._nombre + " - Tipo: " + Grupo._tipo + "\nIntegrantes <"+ g._manada.Count + ">:\n";
            foreach(Mascota masc in g._manada)
            {
                retorno += masc + "\n";
            }
            return retorno;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g==m);
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g._manada.Remove(m);
            }
            else
            {
                Console.WriteLine("{0} no se encuentra en el grupo!", m);
            }
            return g;
        }
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g!=m)
            {
                g._manada.Add(m);
            }
            else
            {
                Console.WriteLine("{0} ya se encuentra en el grupo!", m);
            }
            return g;
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            foreach (Mascota masc in g._manada)
            {
                if(masc == m)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
