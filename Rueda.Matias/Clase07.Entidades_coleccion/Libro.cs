using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07.Entidades_coleccion
{
    public class Libro
    {
        #region Atributos
        private string _titulo;
        private string _autor;
        private List<Capitulo> _capitulos; //atributo de forma list del objeto capitulo
        #endregion

        #region Propiedades
        public string Titulo { get { return this._titulo; } }
        public string Autor { get { return this._autor; } }
        
        
        public int CantidadPaginas
        {
            get
            {
                int pag = 0;
                foreach(Capitulo c in this._capitulos)
                {
                    pag += c.Paginas;
                }
                return pag;
            }
        }

        public int CantidadCapitulos
        {
            get
            {
                return this._capitulos.Count;
            }
        }
        #endregion

        #region Indexeador
        public Capitulo this[int index]
        {
            get
            { /* si indice supera los rango de cap retorno null, si esta ente el rango  de cap retorno ese indice */
                if(index < this._capitulos.Count && index >= 0)
                {
                    return this._capitulos[index];
                }
                else
                {
                    return null;
                }
            }
            set
            { /* si supera el rango lo agrego, si esta por debajo lo reemplaza*/
                if(index<this._capitulos.Count && index >= 0)//count me da el numero de objetos
                {//lo agrego
                    this._capitulos.Insert(index, value);
                }
                else if(index==this._capitulos.Count)
                {
                    //lo piso
                    this._capitulos.Add(value);
                }
            }
        }
        #endregion

        #region Constructor
        public Libro(string tit, string aut)
        {
            this._titulo = tit;
            this._autor = aut;
            this._capitulos = new List<Capitulo>(); //creo la lista de capitulos
        }
        #endregion
        


    }
}
