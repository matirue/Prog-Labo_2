using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    //Sacapunta-> deMetal:bool(publico); 
    //Reutilizar UtilesToString en ToString() (mostrar todos los valores).
    public class Sacapunta:Utiles
    {
        #region Campos
        public bool deMetal;
        #endregion

        #region Constructor
        public Sacapunta( bool deMetal, double precio, string marca) 
            : base(marca, precio)
        {
            this.deMetal = deMetal;
        }
        #endregion

        #region Propiedad
        public override bool PreciosCuidados { get { return false; } }
        #endregion

        #region Metodos
        public override string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("\n+Sacapuntas: \nEs de metal: " +this.deMetal.ToString());
            sb.AppendLine(" - Precio cuidado: " + this.PreciosCuidados);
            return base.UtilesToString()+sb.ToString();
        }
        public override string ToString()
        {
            return this.UtilesToString();
        }
        #endregion
    }
}
