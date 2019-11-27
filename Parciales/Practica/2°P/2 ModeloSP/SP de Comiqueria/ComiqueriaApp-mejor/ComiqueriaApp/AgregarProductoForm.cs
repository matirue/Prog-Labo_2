using System;
using System.Windows.Forms;
using ComiqueriaLogic.Entidades;

namespace ComiqueriaApp
{
    public partial class AgregarProductoForm : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public AgregarProductoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador del evento OnChange del txtPrecio. Cargará el lblError con un string vacío.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {
            this.lblError.Text = String.Empty;
        }

        /// <summary>
        /// Manejador del evento OnClick del btnAgregar. 
        /// Agrega un nuevo producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string nuevaDescripcion = this.txtDescripcion.Text;
                double nuevoPrecio = Convert.ToDouble(this.txtPrecio.Text);
                int nuevoStock = (int)this.txtStock.Value;

                // Punto 4A - Insertar los datos del nuevo producto en la tabla de productos.
                ProductoDAO.Guardar(nuevaDescripcion, nuevoPrecio, nuevoStock);

                this.Close();
            }
        }

        /// <summary>
        /// Valida los datos ingresados para el nuevo producto.
        /// Cargará el lblError con una descripción del error en caso de que algún dato no sea válido.
        /// </summary>
        /// <returns>true si es válido, false si no lo es.</returns>
        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(this.txtDescripcion.Text))
            {
                this.lblError.Text = "Error. Debe ingresar una descripción.";
                return false;
            }

            double nuevoPrecio;
            if (!Double.TryParse(this.txtPrecio.Text, out nuevoPrecio))
            {
                this.lblError.Text = "Error. Debe ingresar un precio válido.";
                return false;
            }

            if (this.txtStock.Value < 0)
            {
                this.lblError.Text = "Error. El stock debe ser mayor o igual a 0.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Manejador del evento OnClick del btnCancelar. 
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
