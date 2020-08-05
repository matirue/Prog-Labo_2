using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Crear la siguiente jerarquía de clases:
    //Utiles-> marca:string y precio:double (publicos); PreciosCuidados:bool (prop. s/l, abstracta);
    //constructor con 2 parametros y UtilesToString():string (protegido y virtual, retorna los valores del útil)
    //ToString():string (polimorfismo; reutilizar código)  
    
    
    public abstract class Utiles
    {
        #region Campos
        public string marca;
        public double precio;
        #endregion

        #region Constructores
        protected Utiles(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }
        public Utiles() { }
        #endregion

        #region Propiedad
        public abstract bool PreciosCuidados { get; }
        #endregion

        #region Metodos
        public virtual string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: "+ this.marca+ " - Precio: $" + this.precio.ToString());
            
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.UtilesToString();
        }
        #endregion
    }

}
