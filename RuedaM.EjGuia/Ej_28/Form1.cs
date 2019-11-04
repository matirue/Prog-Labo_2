using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_28
{
    public partial class Frm_ContadorDePalabras : Form
    {
        public Frm_ContadorDePalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dicccionario = new Dictionary<string, int>();
            string[] palabra=richTextBox1.Text.Split(' ');

            foreach(string p in palabra)
            {
                if (dicccionario.ContainsKey(p))
                    dicccionario[p] += 1;
                else
                    dicccionario.Add(p, 1);                
            }

            int max = 0;
            bool flag = false;
            foreach(int cant in dicccionario.Values)
            {
                if (flag == false)
                {
                    max = cant;
                    flag = true;
                }
                if (cant > max)
                {
                    max = cant;
                }
            }

            string mensaje = "";
            foreach (KeyValuePair<string, int> item in dicccionario.OrderByDescending(keyValuePair => keyValuePair.Value).Take(3))
            {
                mensaje = mensaje + item.Key + " = " + item.Value + "\n";
            }

            MessageBox.Show(mensaje);
        }
    }
}
