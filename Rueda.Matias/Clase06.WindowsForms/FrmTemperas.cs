using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase06.Entidades.V1;

namespace Clase06.WindowsForms
{
    public partial class FrmTemperas : Form
    {
        private Tempera temp;

        #region PROPIEDADES
        //propiedad de escritura y lectura para tempera
        //esto es lo q me permitira recuperar el objeto desde el formpaleta
        //en este caso es solo una prop de lectura, x eso comento el set
        public Tempera MiTempera
        {
            get
            {
                return this.temp;
            }
            //set;
        }
        #endregion

       

        public FrmTemperas (Tempera temp)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            foreach (ConsoleColor col in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBoxColor.Items.Add(col); //aca lo añade
            }
            textBoxMarca.Text = temp.GetMarca;
            textBoxCantidad.Text = temp.GetCantidad.ToString();
            comboBoxColor.SelectedItem = temp.GetColor;
        }

        

        public FrmTemperas()
        {
            InitializeComponent();
            //al inicio aparece en el centro
            //this.StartPosition = FormStartPosition.CenterScreen;

            //este foreach me carga en el comboboxcolor la lista de los colores
            foreach(ConsoleColor col in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBoxColor.Items.Add(col); //aca lo añade
            }

            //inicio el comboboxcolor con el magenta
            this.comboBoxColor.SelectedItem = ConsoleColor.Magenta;

            //bloqueo el combobox para q el ususario no pueda escribir un color q no este en la lista
            this.comboBoxColor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int cantidad;

            if(!string.IsNullOrEmpty(this.textBoxMarca.Text)  &&  int.TryParse(this.textBoxCantidad.Text, out cantidad))
            {
                //si marca no es null y en cantidad se ingreso numeros cargo el objeto
                temp = new Tempera((ConsoleColor)this.comboBoxColor.SelectedItem, this.textBoxMarca.Text, cantidad);
                //lo muesto en una ventana 
                MessageBox.Show((string)temp);

                this.DialogResult = DialogResult.OK;//apretando aceptar retorno ok
            }
            else
            {
                MessageBox.Show("ERROR. Datos Incorrectos");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;//retorna cancel 
            this.Close();//cierra la ventana
        }
    }
}
