using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solo_Caballito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            do
            {
                caballito1.MoverCaballito();
                caballito1.Refresh();

                for (int i = 0; i < 10000000; i++)
                {
                }

            } while (true);
        }
    }
}
