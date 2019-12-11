using ComiqueriaLogic;
using System;
using System.Windows.Forms;
using ComiqueriaLogic.Entidades;

namespace ComiqueriaApp
{
    public partial class PrincipalForm : Form
    {
        private Comiqueria comiqueria;
        //Utilice este campo para acceder al producto seleccionado actualmente. 
        private Producto productoSeleccionado;

        #region No modificar este código
        /// <summary>
        /// Constructor. 
        /// </summary>
        /// <param name="comiqueria"></param>
        public PrincipalForm()
        {
            InitializeComponent();
            this.comiqueria = new Comiqueria();
            this.comiqueria.productosListChanged += ActualizarLista;
        }

        /// <summary>
        /// Manejador del evento Load del formulario. Inicializará los controles del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            this.InicializarFechaHora();
            this.ActualizarLista();
            this.AsignarHora();
        }

        /// <summary>
        /// Actualiza el ListBox de productos y la lista de ventas.
        /// </summary>
        private void ActualizarLista()
        {
            try
            {
                this.richTextBoxVentas.Text = this.comiqueria.ListarVentas();
                this.listBoxProductos.DataSource = null;
                this.listBoxProductos.Refresh();
                this.listBoxProductos.DataSource = this.comiqueria.Productos;
                this.listBoxProductos.DisplayMember = "Descripcion";

                if (this.comiqueria.Productos.Count > 0)
                {
                    this.listBoxProductos.SelectedIndex = 0;
                    this.ActualizarProductoSeleccionado();
                }
            }
            catch (Exception ex)
            {
                this.ManejarExcepciones(ex);
            }
        }

        /// <summary>
        /// Actualiza el campo ProductoSeleccionado cuando se selecciona otro producto de la lista.
        /// </summary>
        private void ActualizarProductoSeleccionado()
        {
            try
            {
                this.productoSeleccionado = (Producto)this.listBoxProductos.SelectedValue;
                if (productoSeleccionado != null)
                {
                    this.richTextBoxDetalle.Text = this.productoSeleccionado.ToString();
                }
            }
            catch (Exception ex)
            {
                this.ManejarExcepciones(ex);
            }
        }

        /// <summary>
        /// Manejador del evento SelectedIndexChanged del ListBox de productos. 
        /// Mantendrá el campo "productoSeleccionado" actualizado con el producto seleccionado actualmente por el usuario.
        /// Y actualizará el texto del richTextBox de detalle. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarProductoSeleccionado();
        }

        /// <summary>
        /// Manejador del evento click del botón vender. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnVenderClick(object sender, EventArgs e)
        {
            try
            {
                Form ventasForm = new VentasForm(this.comiqueria, productoSeleccionado);
                DialogResult result = ventasForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.richTextBoxVentas.Text = this.comiqueria.ListarVentas();
                }
            }
            catch (Exception ex)
            {
                this.ManejarExcepciones(ex);
            }
        }

        /// <summary>
        /// Manejador del evento OnClick del btnModificar.
        /// Abre el ModificarProductoForm. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarProductoForm form = new ModificarProductoForm(this.productoSeleccionado);
            form.ShowDialog();
        }

        /// <summary>
        /// Manejador del evento OnClick del btnAgregar.
        /// Abre el AgregarProductoForm. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProductoForm form = new AgregarProductoForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Abre el ExcepcionesForm para mostrar el error al usuario.
        /// </summary>
        /// <param name="ex"></param>
        private void ManejarExcepciones(Exception ex)
        {
            ExcepcionesForm form = new ExcepcionesForm(ex);
            form.ShowDialog();
        }
        #endregion

        /// <summary>
        /// Manejador del evento OnClick del btnEliminar.
        /// Elimina el producto seleccionado de la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Seguro desea eliminar el producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // 4B - Realizar una baja física del producto seleccionado en la tabla de productos. 
                    ProductoDAO.Borrar(productoSeleccionado.Codigo);
                }
            }
            catch (Exception ex)
            {
                this.ManejarExcepciones(ex);
            }
        }

        /// <summary>
        /// Inicializa el hilo que mantiene actualizada la fecha y la hora.
        /// </summary>
        private void InicializarFechaHora()
        {
            // Punto 9. Instanciar y correr un nuevo hilo que ejecute un método que actualice el “lblFechaHora” cada 1 segundo con la fecha y la hora actual. 
        }

        private void timerUnSegundo_Tick(object sender, EventArgs e)
        {
            this.AsignarHora();
        }

        private void AsignarHora()
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }
    }
}
