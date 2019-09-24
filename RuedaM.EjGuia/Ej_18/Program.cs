using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_18//prueba de gemetria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJ_18";

            


            Console.ReadKey();
        }
    }
}

namespace Geometria
{
    public class Punto
    {
        #region Atributo
        private int _x;
        private int _y;
        #endregion

        #region Constructor
        public Punto(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        #endregion

        #region Metodos
        public int GetX()
        {
            return this._x;
        }

        public int GetY()
        {
            return this._y;
        }
        
        #endregion
    }


    public class Rectangulo
    {
        #region Atributo
        private float _area;
        private float _perimetro;
        private Punto _vertice1;
        private Punto _vertice2;
        private Punto _vertice3;
        private Punto _vertice4;
        #endregion

        #region Metodos
        public float Area()
        {
            return this._area = (Math.Abs(this._vertice3.GetX() - this._vertice1.GetX()) * (Math.Abs(this._vertice2.GetY() - this._vertice4.GetY())));
        }

        public float Perimetro()
        {
            return this._perimetro = 2*(Math.Abs(this._vertice3.GetX() - this._vertice1.GetX()) * (Math.Abs(this._vertice2.GetY() - this._vertice4.GetY())));
        }

        #region Constructor
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this._vertice1 = vertice1;
            this._vertice3 = vertice3;
            this._vertice2 = new Punto(Math.Abs(vertice1.GetX()), Math.Abs(vertice3.GetY()));
            this._vertice4 = new Punto(Math.Abs(vertice3.GetX()), Math.Abs(vertice1.GetY()));

        }
        #endregion
        #endregion
    }

}


