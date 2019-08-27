using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_16
{
    class Alumno
    {
        //atributos
        

        //los atributos privados se inician con un _
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;

        public string apelledo;
        public int legajo;
        public string nombre;


        //metodos
        public Alumno(string nom, string ape, int leg)
        {
            this.nombre = nom;
            this.apelledo = ape;
            this.legajo = leg;
        }

        public void CalcularFinal()
        {
            if(this._nota1 >=4 && this._nota2 >= 4)
            {   //le doy un valor aleatorio a notaFinal
                Random aleatorio = new Random(); //Random es una objeto de tipo clase que no conosco, genera un numero aleatorio
                this._notaFinal = aleatorio.Next(4, 10); //Next() me devuelve un entero aleatorio no negativo
                                                         //por eso le doy el rango entre 4 y 10
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

       
        public string Mostrar()
        {
            string retorno = "  " + this.legajo.ToString() + "     " + this.apelledo + "  " + this.nombre + "  " + this._nota1 + "  " + this._nota2 + "  ";

            if (this._notaFinal == -1)
            {
                retorno += " Alumno desaprobado\n";
            }
            else
            {
                retorno += this._notaFinal + "\n";
            }
            
            return retorno;

        }
        
    }
}
