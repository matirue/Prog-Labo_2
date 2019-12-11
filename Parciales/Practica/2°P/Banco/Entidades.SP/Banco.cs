using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.SP
{
    public abstract class Banco
    {
        public string nombre;
        public Banco(string nombre)
        { this.nombre = nombre; }

        public abstract string Mostrar();
        public abstract string Mostrar(Banco b);
    }

    public class BancoNacional : Banco
    {
        public string pais;
        public BancoNacional(string nombre, string pais) : base(nombre)
        {
            this.pais = pais;            
        }
        
        public override string Mostrar()
            {
                return this.nombre;
            }

        public override string Mostrar(Banco b)
        {
            StringBuilder sb = new StringBuilder();
            if (b is BancoMunicipal)
                sb.AppendFormat("{0}-{1}-{2}-{3}", ((BancoMunicipal)b).nombre, ((BancoMunicipal)b).pais, ((BancoMunicipal)b).provincia, ((BancoMunicipal)b).municipio);            
            else if(b is BancoProvincial)
                sb.AppendFormat("{0}-{1}-{2}", ((BancoProvincial)b).nombre, ((BancoProvincial)b).pais, ((BancoProvincial)b).provincia);
            else if (b is BancoNacional)
                sb.AppendFormat("{0}-{1}", b.nombre, ((BancoNacional)b).pais);
            
            
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar(this);
        }
        
    }

    public class BancoProvincial : BancoNacional
    {
        public string provincia;
        public BancoProvincial(BancoNacional bn, string provincia) : base(bn.nombre, bn.pais)
        {
            this.provincia = provincia; 
        }

        public override string Mostrar()
        {
            return this.nombre;
        }

        public override string Mostrar(Banco b)
        {
            return base.Mostrar(b);
        }

        public override string ToString()
        {
            return this.Mostrar(this);
        }
    }

    public class BancoMunicipal : BancoProvincial
    {
        public string municipio;
        public BancoMunicipal(BancoProvincial bp, string municipio) : base(new BancoNacional(bp.nombre, bp.pais), bp.provincia)
        {
            this.municipio = municipio;
        }

        public override string Mostrar()
        {
            return this.nombre;
        }

        public override string Mostrar(Banco b)
        {
            return base.Mostrar(b);
        }

        public override string ToString()
        {
            return this.Mostrar(this);
        }
    }


}
