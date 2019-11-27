using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class BancoNacional:Banco
  {
    
        #region Atributos
        public string pais;
        #endregion

   
        #region Constructores

        public BancoNacional(string nombre, string paisAux):base(nombre)
        {
          this.pais = paisAux;
        }
        #endregion


        #region Metodos

        //El método que no recibe parámetros, retornará el nombre, mientras que el otro
        //retornará todas las características de la instancia que recibe como parametro. REUTILIZAR CODIGO.


        /// <summary>
        /// Muestra el nombre del banco.
        /// </summary>
        /// <returns></returns>

        public override string Mostrar()
        {
          StringBuilder sb = new StringBuilder();
          sb.AppendFormat(" Nombre: {0}", this.nombre);
          return sb.ToString();
        }

        /// <summary>
        /// Muestra los datos del nombre pasado como parametro.
        /// </summary>
        /// <param name="b">Banco a ser mostrado</param>
        /// <returns></returns>

        public override string Mostrar(Banco b)
        {
          StringBuilder sb = new StringBuilder();
          sb.AppendFormat(b.Mostrar());
          sb.AppendFormat(" Pais : {0}", ((BancoNacional)b).pais);
          return sb.ToString();
        }
        #endregion
      }
}
