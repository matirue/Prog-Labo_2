namespace Eventos.WindowsForm.Manejadores3
{
    partial class frmPasarManejador
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensaje = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(116, 42);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(218, 23);
            this.lblMensaje.TabIndex = 9;
            this.lblMensaje.Text = "Manejador en el button1";
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(331, 119);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(100, 21);
            this.Button4.TabIndex = 8;
            this.Button4.Text = "Button4";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(225, 119);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 21);
            this.Button3.TabIndex = 7;
            this.Button3.Text = "Button3";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(119, 119);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 21);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "Button2";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(13, 119);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 21);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // frmPasarManejador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 182);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "frmPasarManejador";
            this.Text = "Pasar Manejadores en tiempo de Ejecución";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPasarManejador_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblMensaje;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
    }
}

