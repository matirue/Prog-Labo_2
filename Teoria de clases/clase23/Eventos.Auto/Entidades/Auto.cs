using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void delegado1(object sender, AutoEventArgs e);

    public class Auto
    {
        private string _marca;
        private double _combustible;
        private double _reserva;

        public event delegado1 ReservaCombustible;

        public event delegado1 SinCombustible;

        public event delegado1 AvanceKm;

        public Auto(string marca)
        {
            this._marca = marca;
            this.LlenarTanque();
        }


        public string Marca 
        {
            get
            {
                return this._marca;
            }
            set
            {
                this._marca = value;
            }

        }

        public double Conbustible
        {
            get
            {
                return this._combustible;
            }
            set
            {
                this._combustible = value;
            }
            
        }

        public double Autonomia { get { return this._combustible * 10; } }

        public void ConducirMejorado(int Kilometros)
        {
            //Consumo del auto 1litro = 10 Km

            double consumo = 1;
            int litrosViaje = Kilometros / 10;

            for (int i = litrosViaje; i >= 0; i--)
            {

                this._combustible -= consumo;

                if (this._combustible > 0 && this._combustible <= 10)
                {
                    AutoEventArgs e = new AutoEventArgs();
                    e.CombustibleEnElTanque = this._combustible;
                    ReservaCombustible(this, e);
                }

                if (this._combustible <= 0)
                {
                    AutoEventArgs e = new AutoEventArgs();
                    e.CombustibleEnElTanque = this._combustible;
                    i = 0;
                    
                    SinCombustible(this, e);

                }
                AutoEventArgs e1 = new AutoEventArgs();
                AvanceKm(i, e1);
            }

        }

        public void LlenarTanque()
        {
            this._combustible = 60;
        }

        public override string ToString()
{
    StringBuilder sb = new StringBuilder();
    sb.AppendLine();       
    sb.AppendLine("--Estado del Auto--");
    sb.AppendLine("Marca: " + this.Marca);
    sb.AppendLine("Combustible: " + this._combustible + " Litros");
    sb.AppendLine("Autonomía: " + this.Autonomia + " Km");
    sb.AppendLine();
 	 return sb.ToString();
}
        
            
        

        //public void Conducir(int Kilometros)
        //{
        //    //Consumo del auto 1litro = 10 Km

        //    this._combustible -= Kilometros / 10;

        //    if (this._combustible > 0 && this._combustible <= 10)
        //    {
        //        AutoEventArgs e = new AutoEventArgs();
        //        e.CombustibleEnElTanque = this._combustible;
        //        ReservaCombustible(this, e);
        //    }

        //    if (this._combustible <= 0)
        //    {
        //        AutoEventArgs e = new AutoEventArgs();
        //        e.CombustibleEnElTanque = this._combustible;
        //        SinCombustible(this, e);
        //        this._combustible = 0;
        //    }

        //}

    






    }
}
