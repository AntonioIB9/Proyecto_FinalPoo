namespace ProyectoFinal_Memorama
{
    partial class Niveles
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnN1 = new System.Windows.Forms.Button();
            this.BtnN2 = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige el nivel que desees...";
            // 
            // BtnN1
            // 
            this.BtnN1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnN1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnN1.Location = new System.Drawing.Point(95, 232);
            this.BtnN1.Name = "BtnN1";
            this.BtnN1.Size = new System.Drawing.Size(88, 33);
            this.BtnN1.TabIndex = 1;
            this.BtnN1.Text = "Nivel 1";
            this.BtnN1.UseVisualStyleBackColor = false;
            this.BtnN1.Click += new System.EventHandler(this.BtnN1_Click);
            // 
            // BtnN2
            // 
            this.BtnN2.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnN2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnN2.Location = new System.Drawing.Point(95, 304);
            this.BtnN2.Name = "BtnN2";
            this.BtnN2.Size = new System.Drawing.Size(88, 33);
            this.BtnN2.TabIndex = 2;
            this.BtnN2.Text = "Nivel 2";
            this.BtnN2.UseVisualStyleBackColor = false;
            this.BtnN2.Click += new System.EventHandler(this.BtnN2_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(0, 384);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(91, 26);
            this.BtnRegresar.TabIndex = 3;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal_Memorama.Properties.Resources.Equilibrio;
            this.pictureBox1.Location = new System.Drawing.Point(56, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Niveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnN2);
            this.Controls.Add(this.BtnN1);
            this.Controls.Add(this.label1);
            this.Name = "Niveles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Niveles";
            this.Load += new System.EventHandler(this.Niveles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnN1;
        private System.Windows.Forms.Button BtnN2;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}