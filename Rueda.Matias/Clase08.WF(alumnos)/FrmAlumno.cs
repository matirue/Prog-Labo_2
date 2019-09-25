using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase08.Entidades_alumnos_;

namespace Clase08.WF_alumnos_
{
    public partial class FrmAlumno : Form
    {

        public Alumnos alumno;

        public Alumnos GetAlumnos { get { return this.alumno; } }

        

        public FrmAlumno()
        {
            InitializeComponent();

            foreach(ETipoExamen tipo in ETipoExamen.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoExamen.Items.Add(tipo);
            }

            this.cmbTipoExamen.SelectedItem = ETipoExamen.Final;
            
            
        }

        //constructor para el modificar
        public FrmAlumno(Alumnos alum) : this()
        {
            this.txtApellido.Text = alum.Apellido;
            this.txtNombre.Text = alum.Nombre;
            this.txtLegajo.Text = alum.Legajo.ToString();
            this.cmbTipoExamen.SelectedItem = alum.Examen;

            this.txtLegajo.Enabled = false;
        }

        //private void buttonAceptar_Click(object sender, EventArgs e)
        protected virtual void buttonAceptar_Click(object sender, EventArgs e)
        {
            //alumno = new Alumnos(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text), (ETipoExamen)cmbTipoExamen.SelectedItem);
            if(int.TryParse(this.txtLegajo.Text, out int a)) //agregar funcion para que en nombre y apellido solo ingresen letras
            {
                alumno = new Alumnos(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text), (ETipoExamen)this.cmbTipoExamen.SelectedItem);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Datos invalidos");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
