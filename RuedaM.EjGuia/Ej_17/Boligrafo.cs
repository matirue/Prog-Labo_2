using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_17
{
    public class Boligrafo
    {
        #region Atributos
        const short cantidadTintaMaxima=100;
        private ConsoleColor _color;
        private short _tinta;
        #endregion
        

        #region Metodos
        
        #region Constructor
        public Boligrafo (short tinta, ConsoleColor color)
        {
            this._color = color;
            this._tinta = tinta;
        }
        #endregion

        #region Propiedades
        public ConsoleColor GetColor { get { return this._color; } }
        public short GetTinta { get { return this._tinta; } }
        #endregion

        //string dibjo son los *usados hasta gastar la tinta
        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorna = false;
            
            dibujo = "";

            //if ( (this._tinta-gasto) > 0)
            //{
            //    for (int i = 0; i < this._tinta; i++)
            //    {
            //        dibujo += "*";
            //    }
            //    SetTinta((short)gasto);
            //    retorna = true;

            //}

            if (gasto > this.GetTinta)
            {
                for(int i = 0; i < this.GetTinta; i++)
                {
                    dibujo += "*";
                }
                SetTinta((short)gasto);
                retorna = false;

            }
            else
            {
                for(int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
                retorna = true;
            }
            return retorna;
        }

        //coloca tina al max
        public void Recaegar()
        {
            SetTinta(100);
        }

        //valida y carga el atributo t_inta
        private void SetTinta (short tinta)
        {
            //veo tinta para ver si resto o sumo tinta
            if (tinta > 0)
            {
                this._tinta += tinta;
            }
            else
            {
                this._tinta -= tinta;
            }

            //contro de rango de tinta
            if (this._tinta <= 0)
            {
                this._tinta = 0;
            }
            else if (this._tinta >= cantidadTintaMaxima)
            {
                this._tinta = cantidadTintaMaxima;
            }
        }
        #endregion


    }
}
