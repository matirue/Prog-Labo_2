using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Crear la clase genérica Cosa, utilizando una colección a elección, que exponga los métodos Add y Remove y la 
    //propiedad Count y un único constructor por defecto que inicialice la colección.
    public class Cosa<T>
    {
        #region Campos
        public List<String> listado;
        #endregion

        #region Propiedades
        public string Count
        {
            get
            {
                string retorno = " ";
                foreach (String aux in this.listado)
                    retorno += aux + " ";

                return retorno;
            }
        }
        #endregion

        #region Metodos
        public Cosa() { this.listado = new List<string>(); }

        public void Add(T datos)
        {
            this.listado.Add(datos.ToString());
        }

        public void Remove(T datos)
        {
            this.listado.Remove(datos.ToString());
        }
        #endregion
    }
}
