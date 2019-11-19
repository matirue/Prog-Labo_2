using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase24.test;
using Entidades.Clase24;

namespace Clase24.WF
{
    public partial class FrmEmpleado : Form
    {

        Empleado empleado;


        public FrmEmpleado()
        {
            InitializeComponent();


            this.cmbManejador.DropDownStyle = ComboBoxStyle.DropDownList;
            //this.cmbManejador.SelectedItem = "Manejador...";

            foreach(TipoManejador m in TipoManejador.GetValues(typeof(TipoManejador)))
            {
                this.cmbManejador.Items.Add(m);
            }

            this.cmbManejador.SelectedItem = TipoManejador.LimiteSueldo;
            this.txtNombre.Text = "nom1";
            this.txtApelldo.Text = "ape1";
            this.txtLegajo.Text = "111";
            this.txtSueldo.Text = "12345";
            
        }

        #region click error
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion


        public void ManejadorLimiteSueldo(double sueldo, Empleado empleado)
        {
            //Console.WriteLine("El empleado: " + empleado.apelido + " - Leegajo: " + empleado.legajo + "  Se quiso agregar $" + sueldo);
            MessageBox.Show("El empleado \n" + empleado.ToString() + "\n  Se quiso agregar $" + sueldo);
        }

        public static void ManejadorLimiteSueldoMejorado(Empleado empleado, EmpleadoEventArgs empEA)
        {
            //Console.Write("El empleado: " + empleado.apelido + " - Leegajo: " + empleado.legajo + "  Se quiso agregar $" + empEA.SueldoAsignado);
            MessageBox.Show("El empleado \n" + empleado.ToString() + "\n  Se quiso agregar $" + empEA.SueldoAsignado);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {         
            try
            {
                this.empleado = new Empleado(this.txtNombre.Text, this.txtApelldo.Text, int.Parse(this.txtLegajo.Text));

                //empleado.limiteSueldo += new LimiteSueldoDelegado(empleado.ManejadorLimiteSueldo);
                //empleado.limiteSueldoMejor += new LimiteSueldoMejoradoDel(Empleado.ManejadorLimiteSueldoMejorado);

                empleado.Sueldo = Convert.ToDouble(this.txtSueldo.Text);

                
                switch (this.cmbManejador.SelectedItem)
                {
                    case TipoManejador.LimiteSueldo:
                        this.empleado.limiteSueldo -= new LimiteSueldoDelegado(ManejadorLimiteSueldo);
                        this.empleado.limiteSueldo += new LimiteSueldoDelegado(ManejadorLimiteSueldo);
                        break;

                    case TipoManejador.LimiteSueldoMejorado:
                        this.empleado.limiteSueldoMejor -= new LimiteSueldoMejoradoDel(ManejadorLimiteSueldoMejorado);
                        this.empleado.limiteSueldoMejor += new LimiteSueldoMejoradoDel(ManejadorLimiteSueldoMejorado);
                        break;

                    case TipoManejador.Todos:
                        this.empleado.limiteSueldo -= new LimiteSueldoDelegado(ManejadorLimiteSueldo);
                        this.empleado.limiteSueldo += new LimiteSueldoDelegado(ManejadorLimiteSueldo);

                        this.empleado.limiteSueldoMejor -= new LimiteSueldoMejoradoDel(ManejadorLimiteSueldoMejorado);
                        this.empleado.limiteSueldoMejor += new LimiteSueldoMejoradoDel(ManejadorLimiteSueldoMejorado);
                        break;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtApelldo.Clear();
            this.txtNombre.Clear();
            this.txtLegajo.Clear();
            this.txtSueldo.Clear();

            this.Close();
        }
    }
}
