using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Banana-> _paisOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Banana'); 
//Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->false
namespace Entidades
{
    public class Banana:Fruta
    {
        protected string _paisOrigen;

        public string Nombre { get { return "Banana"; } }

        public override bool TieneCarozo { get { return false; } }       


        public Banana(string color, double peso, string paisOrigen) 
            : base(color, peso)
        {
            this._paisOrigen = paisOrigen;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutaToString());
            sb.AppendFormat("Pais Origen: {0}", this._paisOrigen);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
