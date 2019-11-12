using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace Pelotita_Con_Threads
{
    class Pelotita
    {
        private int _ctePropPelotita;
        private int _ctePropMov;
        private Bitmap _mapaBits;
        private int _posX;
        private int _posY;
        private int _radioX;
        private int _radioY;
        private int _movX;
        private int _movY;
        private int _anchoMapaBitsPelotita;
        private int _altoMapaBitsPelotita;
        private int _margernXMapaBits;
        private int _margenYmapaBits;
        private PictureBox _pictureBox;


        public Pelotita(PictureBox pb)
        {
            this._ctePropPelotita = 36;
            this._ctePropMov = 1;
            this._pictureBox = pb;
        }

        private void ConfigurarPelotita(Brush color)
        {
            Graphics g = this._pictureBox.CreateGraphics();
            g.Clear(this._pictureBox.BackColor);

            double min = Math.Min(this._pictureBox.ClientSize.Width / g.DpiX, this._pictureBox.ClientSize.Height / g.DpiY);
            double radioBola = min / this._ctePropPelotita;

            this._radioX = Convert.ToInt32(radioBola * g.DpiX);
            this._radioY = Convert.ToInt32(radioBola * g.DpiY);

            this._movX = Math.Max(2, this._radioX / this._ctePropMov);
            this._movY = Math.Max(2, this._radioY / this._ctePropMov);

            this._margernXMapaBits = this._movX;
            this._margenYmapaBits = this._movY;

            this._anchoMapaBitsPelotita = 2 * (this._radioX + this._margernXMapaBits);
            this._altoMapaBitsPelotita = 2 * (this._radioY + this._margenYmapaBits);

            this._mapaBits = new Bitmap(this._anchoMapaBitsPelotita, this._altoMapaBitsPelotita);

            g = Graphics.FromImage(this._mapaBits);
            g.Clear(this._pictureBox.BackColor);

            g.FillEllipse(Brushes.BlueViolet, new Rectangle(this._movX, this._movY, 2 * this._radioX, 2 * this._radioY));
            g.Dispose();

            this._posX = this._pictureBox.ClientSize.Width / 2;
            this._posY = this._pictureBox.ClientSize.Height / 2;
        }

        public void DoWork()
        {
            this.ConfigurarPelotita(Brushes.Black);

            do
            {
                Graphics g = this._pictureBox.CreateGraphics();
                g.DrawImage(this._mapaBits, this._posX - this._anchoMapaBitsPelotita / 2, this._posY - this._altoMapaBitsPelotita / 2, this._anchoMapaBitsPelotita, this._altoMapaBitsPelotita);

                this._posX += this._movX;
                this._posY += this._movY;

                if (this._posX + this._radioX >= this._pictureBox.ClientSize.Width || this._posX - this._radioX <= 0)
                {

                    this._movX = this._movX * (-1);
                }

                if (this._posY + this._radioY >= this._pictureBox.ClientSize.Height || this._posY - this._radioY <= 0)
                {
                    this._movY = this._movY * (-1);

                }

                for (int i = 0; i < 10000000; i++)
                {
                        
                }

            } while (true);
        }

    }
}
