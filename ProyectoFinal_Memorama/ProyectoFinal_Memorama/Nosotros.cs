using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Memorama
{
    public partial class Nosotros : Form
    {
        public Nosotros()
        {
            InitializeComponent();
        }

        private void Nosotros_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image=Image.FromFile(@"C:\Users\Familia\Desktop\ProyectoFinal_Memorama\ProyectoFinal_Memorama\Imagenes\sentarse.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
