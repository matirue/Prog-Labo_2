using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase04.Entidades;

namespace Clase04.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textEntero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //leo lo q esta en textEntero y lo guardo en entero, lo mismo paa las demas
            int entero = int.Parse(this.textEntero.Text);
            string cadena = this.textCadena.Text;
            DateTime fecha = Convert.ToDateTime(this.textFecha.Text);

            Cosa objeto = new Cosa(cadena, fecha, entero); //creo y cargo el objeto

            // lo muestro
            lstLista.Items.Add(objeto.Mostrar());  //lo muestro en el lstLista
            //MessageBox.Show(objeto.Mostrar());    // lo muestro en pantalla emergente
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int entero = int.Parse(this.lblEntero.Text);
            string cadena = this.lblCadena.Text;
            DateTime fecha = Convert.ToDateTime(this.lblFecha.Text);

            Cosa objeto = new Cosa(cadena, fecha, entero);

            //this.lstLista.Items.Add = objeto.Mostrar();
        }
    }
}
