using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Platano:Fruta
    {
        #region Campos
        public string paisOrigen;
        #endregion

        #region Prop
        public override bool TieneCarozo { get { return false; } }
        public string Tipo { get { return "Platano"; } }
        #endregion

        #region Metodos
        protected override string FtrutaTostring()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.FtrutaTostring());
            sb.AppendFormat("Pais de origen: " + this.paisOrigen);

            return sb.ToString();
        }

        public Platano(float peso, ConsoleColor color, string pais) 
            : base(peso, color)
        {
            this.paisOrigen = pais;
        }

        public override string ToString()
        {
            return this.FtrutaTostring();
        }
        #endregion
    }
}
