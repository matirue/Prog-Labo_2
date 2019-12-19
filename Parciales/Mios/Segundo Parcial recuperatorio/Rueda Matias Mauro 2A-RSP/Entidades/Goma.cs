using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    
    //Goma-> soloLapiz:bool(publico); PreciosCuidados->true; 
    //Reutilizar UtilesToString en ToString() (mostrar todos los valores).
    //Sacapunta-> deMetal:bool(publico); 
    //Reutilizar UtilesToString en ToString() (mostrar todos los valores).
    public class Goma:Utiles
    {
        #region Campos
        public bool soloLapiz;
        #endregion

        #region Constructor
        public Goma( bool soloLapiz,string marca, double precio) 
            : base(marca, precio)
        {
            this.soloLapiz = soloLapiz;
        }
        #endregion

        #region Propiedad
        public override bool PreciosCuidados { get { return true; } }
        #endregion

        #region Metodos
        public override string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("\n+Goma: \nSolo Lapiz: " + this.soloLapiz.ToString());
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
