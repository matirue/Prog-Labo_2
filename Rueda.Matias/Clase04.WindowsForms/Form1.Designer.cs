namespace Clase04.WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEntero = new System.Windows.Forms.Label();
            this.lblCadena = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.textEntero = new System.Windows.Forms.TextBox();
            this.textCadena = new System.Windows.Forms.TextBox();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEntero
            // 
            this.lblEntero.AutoSize = true;
            this.lblEntero.Location = new System.Drawing.Point(42, 29);
            this.lblEntero.Name = "lblEntero";
            this.lblEntero.Size = new System.Drawing.Size(38, 13);
            this.lblEntero.TabIndex = 0;
            this.lblEntero.Text = "Entero";
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Location = new System.Drawing.Point(42, 68);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(44, 13);
            this.lblCadena.TabIndex = 1;
            this.lblCadena.Text = "Cadena";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(42, 106);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // textEntero
            // 
            this.textEntero.Location = new System.Drawing.Point(134, 22);
            this.textEntero.Name = "textEntero";
            this.textEntero.Size = new System.Drawing.Size(186, 20);
            this.textEntero.TabIndex = 3;
            this.textEntero.TextChanged += new System.EventHandler(this.textEntero_TextChanged);
            // 
            // textCadena
            // 
            this.textCadena.Location = new System.Drawing.Point(134, 61);
            this.textCadena.Name = "textCadena";
            this.textCadena.Size = new System.Drawing.Size(186, 20);
            this.textCadena.TabIndex = 4;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(134, 99);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(186, 20);
            this.textFecha.TabIndex = 5;
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(25, 191);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(295, 95);
            this.lstLista.TabIndex = 6;
            this.lstLista.SelectedIndexChanged += new System.EventHandler(this.lstLista_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(345, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.textCadena);
            this.Controls.Add(this.textEntero);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCadena);
            this.Controls.Add(this.lblEntero);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clase04.WindowsForms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntero;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox textEntero;
        private System.Windows.Forms.TextBox textCadena;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button button1;
    }
}

