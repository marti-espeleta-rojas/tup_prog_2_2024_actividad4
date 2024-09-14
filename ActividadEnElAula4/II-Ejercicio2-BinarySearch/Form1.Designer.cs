namespace II_Ejercicio2_BinarySearch
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
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerAlta = new System.Windows.Forms.Button();
            this.tbMostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(58, 64);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(144, 20);
            this.tbDNI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            // 
            // btnVerAlta
            // 
            this.btnVerAlta.Location = new System.Drawing.Point(248, 62);
            this.btnVerAlta.Name = "btnVerAlta";
            this.btnVerAlta.Size = new System.Drawing.Size(113, 23);
            this.btnVerAlta.TabIndex = 2;
            this.btnVerAlta.Text = "Ver/Alta Persona";
            this.btnVerAlta.UseVisualStyleBackColor = true;
            this.btnVerAlta.Click += new System.EventHandler(this.btnVerAlta_Click);
            // 
            // tbMostrar
            // 
            this.tbMostrar.Location = new System.Drawing.Point(58, 121);
            this.tbMostrar.Multiline = true;
            this.tbMostrar.Name = "tbMostrar";
            this.tbMostrar.Size = new System.Drawing.Size(303, 152);
            this.tbMostrar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnVerAlta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 307);
            this.Controls.Add(this.tbMostrar);
            this.Controls.Add(this.btnVerAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDNI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerAlta;
        private System.Windows.Forms.TextBox tbMostrar;
    }
}

