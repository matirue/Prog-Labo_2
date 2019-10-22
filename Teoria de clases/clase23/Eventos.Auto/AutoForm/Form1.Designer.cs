namespace AutoForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.gpbViaje = new System.Windows.Forms.GroupBox();
            this.btnConducir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCombustible = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutonomia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.pgbRecorrido = new System.Windows.Forms.ProgressBar();
            this.gpbViaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // gpbViaje
            // 
            this.gpbViaje.Controls.Add(this.pgbRecorrido);
            this.gpbViaje.Controls.Add(this.btnConducir);
            this.gpbViaje.Controls.Add(this.label2);
            this.gpbViaje.Controls.Add(this.txtDistancia);
            this.gpbViaje.Location = new System.Drawing.Point(40, 96);
            this.gpbViaje.Name = "gpbViaje";
            this.gpbViaje.Size = new System.Drawing.Size(259, 93);
            this.gpbViaje.TabIndex = 1;
            this.gpbViaje.TabStop = false;
            this.gpbViaje.Text = "Viaje";
            // 
            // btnConducir
            // 
            this.btnConducir.Location = new System.Drawing.Point(22, 25);
            this.btnConducir.Name = "btnConducir";
            this.btnConducir.Size = new System.Drawing.Size(75, 23);
            this.btnConducir.TabIndex = 2;
            this.btnConducir.Text = "Conducir";
            this.btnConducir.UseVisualStyleBackColor = true;
            this.btnConducir.Click += new System.EventHandler(this.btnConducir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Km";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(118, 27);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 0;
            this.txtDistancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Combustible";
            // 
            // txtCombustible
            // 
            this.txtCombustible.Location = new System.Drawing.Point(158, 207);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.ReadOnly = true;
            this.txtCombustible.Size = new System.Drawing.Size(52, 20);
            this.txtCombustible.TabIndex = 4;
            this.txtCombustible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Litros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Autonomía";
            // 
            // txtAutonomia
            // 
            this.txtAutonomia.Location = new System.Drawing.Point(158, 238);
            this.txtAutonomia.Name = "txtAutonomia";
            this.txtAutonomia.ReadOnly = true;
            this.txtAutonomia.Size = new System.Drawing.Size(52, 20);
            this.txtAutonomia.TabIndex = 7;
            this.txtAutonomia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Km";
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(46, 278);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(91, 23);
            this.btnLlenar.TabIndex = 9;
            this.btnLlenar.Text = "Llenar Tanque";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(212, 278);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(83, 40);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 13);
            this.lblMarca.TabIndex = 2;
            // 
            // pgbRecorrido
            // 
            this.pgbRecorrido.Location = new System.Drawing.Point(22, 59);
            this.pgbRecorrido.Name = "pgbRecorrido";
            this.pgbRecorrido.Size = new System.Drawing.Size(225, 23);
            this.pgbRecorrido.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 324);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAutonomia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCombustible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.gpbViaje);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "frmAuto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbViaje.ResumeLayout(false);
            this.gpbViaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbViaje;
        private System.Windows.Forms.Button btnConducir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCombustible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutonomia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ProgressBar pgbRecorrido;
    }
}

