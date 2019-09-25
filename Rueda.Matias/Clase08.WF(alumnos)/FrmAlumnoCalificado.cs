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
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        private AlumnoCalificado alumnoNota;

        public AlumnoCalificado GetAlumnoNota { get { return this.alumnoNota; } }

        public FrmAlumnoCalificado()
        {
            InitializeComponent();


        }

        //constructor para el calificar
        public FrmAlumnoCalificado(Alumnos alum):this()
        {          

            base.txtApellido.Enabled = false;
            base.txtNombre.Enabled = false;
            base.txtLegajo.Enabled = false;
            base.cmbTipoExamen.Enabled = false;

            this.txtApellido.Text = alum.Apellido;
            this.txtNombre.Text = alum.Nombre;
            this.txtLegajo.Text = alum.Legajo.ToString();
            this.cmbTipoExamen.SelectedItem = alum.Examen;
            

        }

        protected override void buttonAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int legajo = int.Parse(txtLegajo.Text);
            ETipoExamen examen = (ETipoExamen)cmbTipoExamen.SelectedIndex;

            if(double.TryParse(txtNota.Text, out double nota))
            {
                alumnoNota = new AlumnoCalificado(nombre, apellido, legajo, examen, nota);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nota no numerica");
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
