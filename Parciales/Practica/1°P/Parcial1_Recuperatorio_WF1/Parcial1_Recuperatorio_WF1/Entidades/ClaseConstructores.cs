using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
  public class ClaseConstructores
  {
    //Crear una clase (ClaseConstructores) que al instanciarse:
    //    1)pase por un constructor estático
    //    2)pase por un constructor que reciba 2 parámetros (privado)
    //    3)pase por un constructor publico (default)
    //    4)pase por una propiedad de sólo escritura
    //    5)pase por una propiedad de sólo lectura
    //    6)pase por un método de instancia
    //    7)pase por un método de clase
    //NOTA: el orden no se puede alterar.
    //NOTA: por cada lugar que pase, mostrar con un MessageBox.Show dicho lugar
    //NOTA: agregar la referencia a System.Windows.Form; para poder acceder a la clase MessageBox.
    //NOTA: NO MAS DE 2 LINEAS DE CODIGO POR METODO/PROPIEDAD/CONSTRUCTOR

    private int propEscritura;
    private int propLectura;

    /// <summary>
    /// Constructor de clase
    /// </summary>
    static ClaseConstructores()
    {
      MessageBox.Show("Constructor Estatico");
    }

    /// <summary>
    /// Constructor con dos parametros
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    private ClaseConstructores(string a, string b)
    {
      MessageBox.Show("Constructor privado con dos parametros");
    }

    /// <summary>
    /// Constructor por defecto
    /// </summary>
    public ClaseConstructores() : this("a", "b")
    {
      MessageBox.Show("Constructor default");
      this.PropEscritura = 5;

    }

    /// <summary>
    /// Propiedad de escritura
    /// </summary>
    public int PropEscritura
    {
      set
      {
        MessageBox.Show("Propiedad de escritura");
        propEscritura = this.PropLectura;
      }
    }

    /// <summary>
    /// Propiedad de lectura
    /// </summary>
    public int PropLectura
    {
      get
      {
        MessageBox.Show("Propiedad de lectura");
        return MetodoDeInstancia();
      }
    }

    /// <summary>
    /// Metodo de instancia
    /// </summary>
    /// <returns></returns>
    public int MetodoDeInstancia()
    {
      MessageBox.Show("Metodo de instancia");
      return MetodoDeClase();

    }

    /// <summary>
    /// Metodo de clase
    /// </summary>
    /// <returns></returns>
    public static int MetodoDeClase()
    {
      MessageBox.Show("Metodo de clase");
      return 1;
    }



  }
}
