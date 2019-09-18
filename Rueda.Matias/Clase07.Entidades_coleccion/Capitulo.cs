using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07.Entidades_coleccion
{
    public class Capitulo
    {
        #region Atributos
        private int _numero;
        private string _titulo;
        private int _paginas;

        private static Random _generadorDeNumero;
        private static Random _generadorDePaginas;
        #endregion

        #region Constructor
        static Capitulo()
        {
            Capitulo._generadorDeNumero = new Random();
            Capitulo._generadorDePaginas = new Random();
            
        }

        private Capitulo (int num, string tit, int pag)
        {
            this._numero = num;
            this._titulo = tit;
            this._paginas = pag;
        }
        #endregion        
        
        #region Sobrecarga
        public static bool operator ==(Capitulo c1,Capitulo c2)
        {
            if(!Object.Equals(c1,null) && !Object.Equals(c2, null))
            {
                if (c1._titulo == c2._titulo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Capitulo c1, Capitulo c2)
        {
            return !(c1 == c2);
        }
        #endregion

        #region Metodos
        public static implicit operator Capitulo(string cad)
        {
            Capitulo cap = new Capitulo(Capitulo._generadorDeNumero.Next(1, 56), cad, Capitulo._generadorDePaginas.Next(15, 255));
            return cap;
        }
        #endregion

        #region Propiedades
        public int Numero
        {
            get
            {
                return this._numero;
            }
        }
        public string Titulo
        {
            get
            {
                return this._titulo;
            }
        }
        public int Paginas
        {
            get
            {
                return this._paginas;
            }
        }
        #endregion

    }
}
