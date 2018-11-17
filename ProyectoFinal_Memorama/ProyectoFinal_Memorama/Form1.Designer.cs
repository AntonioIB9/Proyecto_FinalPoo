namespace ProyectoFinal_Memorama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAyuda = new System.Windows.Forms.Button();
            this.BtnNiveles = new System.Windows.Forms.Button();
            this.BtnNosotros = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Memorama";
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAyuda.Location = new System.Drawing.Point(29, 379);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(97, 32);
            this.BtnAyuda.TabIndex = 2;
            this.BtnAyuda.Text = "Ayuda";
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // BtnNiveles
            // 
            this.BtnNiveles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNiveles.Location = new System.Drawing.Point(165, 379);
            this.BtnNiveles.Name = "BtnNiveles";
            this.BtnNiveles.Size = new System.Drawing.Size(97, 32);
            this.BtnNiveles.TabIndex = 3;
            this.BtnNiveles.Text = "Niveles";
            this.BtnNiveles.UseVisualStyleBackColor = false;
            this.BtnNiveles.Click += new System.EventHandler(this.BtnNiveles_Click);
            // 
            // BtnNosotros
            // 
            this.BtnNosotros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnNosotros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNosotros.Location = new System.Drawing.Point(29, 425);
            this.BtnNosotros.Name = "BtnNosotros";
            this.BtnNosotros.Size = new System.Drawing.Size(97, 32);
            this.BtnNosotros.TabIndex = 5;
            this.BtnNosotros.Text = "Nosotros";
            this.BtnNosotros.UseVisualStyleBackColor = false;
            this.BtnNosotros.Click += new System.EventHandler(this.BtnNosotros_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(165, 425);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(97, 32);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(309, 469);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnNosotros);
            this.Controls.Add(this.BtnNiveles);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memorama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAyuda;
        private System.Windows.Forms.Button BtnNiveles;
        private System.Windows.Forms.Button BtnNosotros;
        private System.Windows.Forms.Button BtnSalir;
    }
}

