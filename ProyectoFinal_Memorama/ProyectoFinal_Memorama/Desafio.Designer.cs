namespace ProyectoFinal_Memorama
{
    partial class Desafio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelDesa = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.PictureDesafio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDesafio)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDesa
            // 
            this.LabelDesa.AutoSize = true;
            this.LabelDesa.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesa.Location = new System.Drawing.Point(46, 206);
            this.LabelDesa.Name = "LabelDesa";
            this.LabelDesa.Size = new System.Drawing.Size(248, 38);
            this.LabelDesa.TabIndex = 0;
            this.LabelDesa.Text = "\"Realmente tienes el valor para \r\nenfrentar al nivel 2?\"";
            this.LabelDesa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(50, 275);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(76, 32);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "Si";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Red;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(208, 275);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(76, 32);
            this.BtnRegresar.TabIndex = 3;
            this.BtnRegresar.Text = "No";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // PictureDesafio
            // 
            this.PictureDesafio.Image = global::ProyectoFinal_Memorama.Properties.Resources.Asustar;
            this.PictureDesafio.InitialImage = global::ProyectoFinal_Memorama.Properties.Resources.Asustar;
            this.PictureDesafio.Location = new System.Drawing.Point(60, 35);
            this.PictureDesafio.Name = "PictureDesafio";
            this.PictureDesafio.Size = new System.Drawing.Size(224, 124);
            this.PictureDesafio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureDesafio.TabIndex = 1;
            this.PictureDesafio.TabStop = false;
            // 
            // Desafio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 362);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.PictureDesafio);
            this.Controls.Add(this.LabelDesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desafio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desafio";
            ((System.ComponentModel.ISupportInitialize)(this.PictureDesafio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDesa;
        private System.Windows.Forms.PictureBox PictureDesafio;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnRegresar;
    }
}