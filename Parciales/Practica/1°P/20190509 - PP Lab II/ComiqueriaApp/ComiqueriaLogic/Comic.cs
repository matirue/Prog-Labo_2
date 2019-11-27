using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic:Producto
    {
        private string autor;
        private TipoComic tipoComic;
        public enum TipoComic
        {
            Occidental,
            Oriental
        }
        public Comic(string descripcion,int stock,double precio,string autor, TipoComic tipoComic):base(descripcion,stock,precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0} \nAutor: {1} \nTipo Comic: {2}\n", base.ToString(), this.autor, this.tipoComic);
            return stringBuilder.ToString();
        }
            
    }
}
