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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea realmente salir? ", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
              this.Close();
                Application.Exit();
            }
            else
            {
                
            }

        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayuda frm = new Ayuda();
            frm.Show();

        }

        private void BtnNosotros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nosotros frm = new Nosotros();
            frm.Show();
        }

        private void BtnNiveles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Niveles frm = new Niveles();
            frm.Show();
        }
    }
}
