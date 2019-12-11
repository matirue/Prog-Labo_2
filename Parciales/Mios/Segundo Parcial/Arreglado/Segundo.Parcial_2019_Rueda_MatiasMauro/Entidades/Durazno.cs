using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Durazno-> _cantPelusa:int (protegido); Nombre:string (prop. s/l, retornará 'Durazno'); 
//Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true

namespace Entidades
{
    public class Durazno:Fruta
    {
        protected int _cantPelusa;
               
        public string Nombre { get { return "Durazno"; } }

        public override bool TieneCarozo { get { return true; } }

        public Durazno(string color, double peso, int cantidadPelusa) 
            : base(color, peso)
        {
            this._cantPelusa = cantidadPelusa;
        }
        
        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutaToString());
            sb.AppendFormat("Cantidad pelusa: {0}", this._cantPelusa);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
