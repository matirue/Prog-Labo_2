using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Fruta-> _color:string y _peso:double (protegidos); TieneCarozo:bool (prop. s/l, abstracta);
//constructor con 2 parametros y 
//FrutaToString():string (protegido y virtual, retorna los valores de la fruta)
namespace Entidades
{
    public abstract class Fruta
    {
        string _color;
        double _peso;

        public abstract bool TieneCarozo { get; }

        public double Peso
        {
            get { return this._peso;  }
            set { this._peso = value; }
        }

        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }



        public Fruta() { }
        
        public Fruta(string color, double peso)
        {
            this._color = color;
            this._peso = peso;
        }


        protected virtual string FrutaToString()
        {
            return string.Format("Color: {0} \nPeso: {1}", this._color, this._peso);
        }
    }
}
