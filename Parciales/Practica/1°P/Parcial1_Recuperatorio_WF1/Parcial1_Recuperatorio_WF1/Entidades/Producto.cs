using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Producto
  {
    #region Atributos
    public string nombre;
    public int stock;
    #endregion

    #region Contructor
    /// <summary>
    /// Constructor que inicializara con los parametros pasados
    /// </summary>
    /// <param name="nombre">Nombre a inicializar</param>
    /// <param name="stock">Stock a inicializar</param>
    public Producto(string nombre, int stock)
    {
      this.nombre = nombre;
      this.stock = stock;
    }
    #endregion
  }
}
