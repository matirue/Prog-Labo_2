using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
  public abstract class Banco
  {
    //Crear jerarquía que contenga los siguientes constructores (1 por clase):
    //Banco(nombre)
   
    public string nombre;

    public Banco(string nombreAux)
    {
      this.nombre = nombreAux;
    }

    //Agregar en Banco el método Mostrar():string y Mostrar(Banco):string, ambos abstractos.

    public abstract string Mostrar();

    public abstract string Mostrar(Banco b);

    public override bool Equals(object obj)
    {

      bool flag = false;

      if (obj is Banco)
      {
        if (this.nombre == ((Banco)obj).nombre)
        {
          MessageBox.Show("Es un banco y tiene el mismo nombre");
          flag = true;
        }
        else
        {
          MessageBox.Show("Es un banco pero no tiene el mismo nombre");
        }
      }
      else if (obj is BancoNacional)
      {
        MessageBox.Show("Es un banco nacional");
      }
      else if (obj is BancoProvincial)
      {
        MessageBox.Show("Es un banco provincial");
      }
      else if (obj is BancoMunicipal)
      {
        MessageBox.Show("Es un banco municipal");
      }
      else
      {
        MessageBox.Show("No es ningun tipo de banco");
      }

      return flag;
    }

  }
}
