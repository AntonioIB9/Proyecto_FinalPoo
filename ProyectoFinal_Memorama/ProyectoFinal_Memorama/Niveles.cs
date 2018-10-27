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
    public partial class Niveles : Form
    {
        public Niveles()
        {
            InitializeComponent();
        }

        private void Niveles_Load(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile(@"D:\Mis Documentos\Escritorio\ProyectoFinal_Memorama\Equilibrio.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nivel1 frm = new Nivel1();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Nivel2 frm = new Nivel2();
            frm.Show();

        }
    }
}
