using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class BancoProvincial:BancoNacional
  {

        #region Atributos

        public string provincia;

        #endregion


        #region Constructores

        public BancoProvincial(BancoNacional nacional, string provincia):base(nacional.nombre,nacional.pais)
        {
          this.provincia = provincia;
        }

        #endregion


        #region Metodos

        /// <summary>
        /// Muestra el nombre del banco.
        /// </summary>
        /// <returns></returns>

        public override string Mostrar()
        {
          StringBuilder sb = new StringBuilder();
          sb.AppendFormat(" Nombre : {0}", this.nombre);
          return sb.ToString();
        }

        /// <summary>
        /// Muestra los datos del nombre pasado como parametro.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public override string Mostrar(Banco b)
        {
          StringBuilder sb = new StringBuilder();
          if(b is BancoProvincial)
          {
            sb.Append(((BancoProvincial)b).pais);
          }

          return sb.ToString();
     
        }

        #endregion
    }
}
