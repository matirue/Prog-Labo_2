using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Fruta
    {
        #region Campos
        protected ConsoleColor _color;
        protected float _peso;
        #endregion

        #region Prop
        public abstract bool TieneCarozo { get; }
        #endregion

        #region Metodos

        public Fruta() { }

        public Fruta(float peso, ConsoleColor color)
        {
            this._color = color;
            this._peso = peso;
        }
        

        protected virtual string FtrutaTostring()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Color: " + this._color + " - Peso: " + this._peso);

            return sb.ToString();
        }
        #endregion

    }
}
