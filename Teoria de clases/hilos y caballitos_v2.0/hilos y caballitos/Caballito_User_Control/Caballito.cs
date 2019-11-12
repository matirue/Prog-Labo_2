using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caballo
{
    public partial class Caballito : UserControl
    {
        private Spritesheet ssImagen;

        public Caballito()
        {
            InitializeComponent();

            this.ssImagen = new Spritesheet(Properties.Resources.HorseSpriteSheetWhite_2, 208, 129);
            this.pbLienzo.Image = this.ssImagen.curState;
        }

        public void MoverCaballito()
        {
            this.ssImagen.playSprite(5, 5, 3);
            this.pbLienzo.Image = this.ssImagen.curState;
        }

    }
}
