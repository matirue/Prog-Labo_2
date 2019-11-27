using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class BancoProvincial:BancoNacional
  {
    //BancoProvincial(bancoNacional, provincia)


    public string provincia;

    public BancoProvincial(BancoNacional nacional, string provincia):base(nacional.nombre,nacional.pais)
    {
      this.provincia = provincia;
    }


    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("Nombre : {0}", this.nombre);
      return sb.ToString();
    }

    public override string Mostrar(Banco b)
    {
      StringBuilder sb = new StringBuilder();
      if(b is BancoProvincial)
      {
        sb.Append(((BancoProvincial)b).pais);
      }

      return sb.ToString();
     
    }

  }
}
