using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AutoForm
{
    public partial class Form1 : Form
    {
        private Auto miAuto = new Auto("Renault");
        private System.Drawing.Color ColorOriginal;


        public Form1()
        {
            InitializeComponent();
            this.ColorOriginal = this.txtCombustible.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MostrarAuto();
            this.txtDistancia.Focus();

            miAuto.ReservaCombustible += ManejadorReserva;
            miAuto.SinCombustible += ManejadorEmpty;
            miAuto.AvanceKm += miAuto_AvanceKm;
         
        }

        void miAuto_AvanceKm(object sender, AutoEventArgs e)
        {
            pgbRecorrido.Value = (int)sender;
        }

        private void ManejadorReserva(object sender, AutoEventArgs e)
        {
            this.MostrarAuto();
            this.txtCombustible.BackColor = Color.Yellow;

            if (MessageBox.Show("Llenar el tanque? ", "Reserva de Combustible", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.CargarCombustible();
            }
        }

        private void ManejadorEmpty(object sender, AutoEventArgs e)
        {
            this.MostrarAuto();
            this.txtCombustible.BackColor = Color.Red;

            MessageBox.Show("Quedan " + e.CombustibleEnElTanque + " Litros", "Sin Combustible", MessageBoxButtons.OK, MessageBoxIcon.Stop);                  
                          
        }

        private void btnConducir_Click(object sender, EventArgs e)
        {
            if (this.txtDistancia.Text != "")
            {
                int km = 0;
                int.TryParse(this.txtDistancia.Text, out km);
                this.pgbRecorrido.Maximum = km;
                this.pgbRecorrido.Value = km;

                miAuto.ConducirMejorado(km);
                this.MostrarAuto();
                this.txtDistancia.Text = "";
                this.txtDistancia.Focus();
            }
            else
            {
                MessageBox.Show("Debe ingresar una distancia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtDistancia.Focus();

            }

        }

        private void MostrarAuto()
        {

            this.lblMarca.Text = miAuto.Marca;
            this.txtCombustible.Text = miAuto.Conbustible.ToString();
            this.txtAutonomia.Text = miAuto.Autonomia.ToString();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            if (this.miAuto.Conbustible == 60)            
                MessageBox.Show("No es necesario", "Tanque Lleno");            
            else
                this.CargarCombustible();

        }

        private void CargarCombustible()
        {
            this.miAuto.LlenarTanque();
            this.txtCombustible.BackColor = this.ColorOriginal;
            this.MostrarAuto();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    



        
    }
}
