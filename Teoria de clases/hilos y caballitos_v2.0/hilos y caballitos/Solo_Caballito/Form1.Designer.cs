namespace Solo_Caballito
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
            this.caballito1 = new Caballo.Caballito();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caballito1
            // 
            this.caballito1.Location = new System.Drawing.Point(37, 35);
            this.caballito1.Name = "caballito1";
            this.caballito1.Size = new System.Drawing.Size(208, 129);
            this.caballito1.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(81, 234);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(121, 45);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 314);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.caballito1);
            this.Name = "Form1";
            this.Text = "Caballito";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Caballo.Caballito caballito1;
        private System.Windows.Forms.Button btnIniciar;
    }
}

