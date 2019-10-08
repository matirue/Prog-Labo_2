using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ej_20;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverEuro_Click(object sender, EventArgs e)
        {
            
            Moneda.Euro euro = new Moneda.Euro(double.Parse(txtEuro.Text));
            Moneda.Dolar dolar = new Moneda.Dolar(0);
            Moneda.Peso peso = new Moneda.Peso(0);

            Moneda.Euro aux = new Moneda.Euro(0);

            aux = euro;
            peso = (Moneda.Peso)euro;
            dolar = (Moneda.Dolar)euro;

            txtEuroAEuro.Text = (aux.GetCantidad()).ToString();
            txtEuroADolar.Text = (dolar.GetCantidad()).ToString();
            txtEuroAPeso.Text = (peso.GetCantidad()).ToString();
        }

        private void btnConverDolar_Click(object sender, EventArgs e)
        {
            Moneda.Euro euro = new Moneda.Euro(0);
            Moneda.Dolar dolar = new Moneda.Dolar(double.Parse(txtDolar.Text));
            Moneda.Peso peso = new Moneda.Peso(0);

            Moneda.Dolar aux = new Moneda.Dolar(0);

            aux = dolar;
            peso = (Moneda.Peso)dolar;
            euro = (Moneda.Euro)dolar;

            txtDolarAEuro.Text = (euro.GetCantidad()).ToString();
            txtDolarADolar.Text = (aux.GetCantidad()).ToString();
            txtDolarAPeso.Text = (peso.GetCantidad()).ToString();
        }

        private void btnConvetPeso_Click(object sender, EventArgs e)
        {
            Moneda.Euro euro = new Moneda.Euro(0);
            Moneda.Dolar dolar = new Moneda.Dolar(0);
            Moneda.Peso peso = new Moneda.Peso(double.Parse(txtPeso.Text));

            Moneda.Peso aux = new Moneda.Peso(0);

            aux = peso;
            dolar = (Moneda.Dolar)peso;
            euro = (Moneda.Euro)peso;

            txtPesoAEuro.Text = (euro.GetCantidad()).ToString();
            txtPesoADolar.Text = (dolar.GetCantidad()).ToString();
            txtPesoAPeso.Text = (aux.GetCantidad()).ToString();
        }
    }
}
