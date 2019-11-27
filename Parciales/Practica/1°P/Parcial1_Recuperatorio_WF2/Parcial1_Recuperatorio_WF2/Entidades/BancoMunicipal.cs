using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class BancoMunicipal:BancoProvincial
  {
    //BancoMunicipal(bancoProvincial, municipio)
    //Crear una instancia de cada clase e inicializar los atributos del form: 
    //_bancoNacional, _bancoProvincial y _bancoMunicipal.
    
            #region Atributos
        public string municipio;
        #endregion

    
            #region Constructor

        public BancoMunicipal(BancoProvincial provincial, string municipio):base(new BancoNacional(provincial.nombre,provincial.pais), provincial.provincia)
        {
          this.municipio = municipio;
        }

        #endregion

       
            #region Metodos

        /// <summary>
        /// Muestra el nombre del banco.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
          return " Nombre: " + this.nombre;
        }

        /// <summary>
        /// Muestra los datos del nombre pasado como parametro.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public override string Mostrar(Banco b)
        {
          return base.Mostrar(b) + " -- Municipio: " + this.municipio;
        }
        #endregion


            #region Sobrecarga

        //Agregar en la clase BancoMunicipal una sobrecarga en el implicit para que retorne todas
        //las características de la instancia en formato string. Aplicar polimorfismo sobre el método ToString
        //que deberá reutilizar código.
        public static implicit operator string(BancoMunicipal bM)
        {
          return "Nombre: " + bM.nombre + " -- Pais:" + bM.pais + " -- Provincia: " + bM.provincia + " -- Municipio: " + bM.municipio;
        }

        public override string ToString()
        {
          return this;
        }
        #endregion

  }
}
