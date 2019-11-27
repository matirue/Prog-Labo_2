using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manzana:Fruta
    {
        #region Campos
        public string distribuidora;
        #endregion

        #region Prop
        public override bool TieneCarozo { get { return true; } }
        public string Tipo { get { return "Manzana"; } }
        #endregion

        #region Metodos
        protected override string FtrutaTostring()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.FtrutaTostring());
            sb.AppendFormat("Distribuidor: " + this.distribuidora);

            return sb.ToString();
        }

        public Manzana(float peso,ConsoleColor color, string distribuidor) 
            : base(peso, color)
        {
            this.distribuidora = distribuidor;
        }

        public override string ToString()
        {
            return this.FtrutaTostring();
        }
        #endregion
    }
}
