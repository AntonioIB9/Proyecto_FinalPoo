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
    public partial class Nivel1 : Form
    {
        Random random = new Random();
        List<string> imagenes = new List<string>()
        {
            "p","p","N","N",",",",","k","k",
            "b","b","v","v","w","w","z","z"
        };

        Label primerclick, segundoclick;
        public Nivel1()
        {
            InitializeComponent();
            MecanicaJuego();
        }
       
        private void MecanicaJuego()
        {
            Label label;
            int numerorandom; 

            for (int i=0; i<tableLayoutPanel1.Controls.Count;i++)
            {
                if(tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                } 
                else
                {
                    continue;
                }

                numerorandom = random.Next(0, imagenes.Count);
                label.Text = imagenes[numerorandom];

                imagenes.RemoveAt(numerorandom);
            }
        }


        private void Label_Click(object sender, EventArgs e)
        {
            if(primerclick!=null && segundoclick != null)
            {
                return;
            }

            Label LabelClickeado = sender as Label; 

            if (LabelClickeado==null)
            {
                return;
            }

            if(LabelClickeado.ForeColor==Color.Black)
            {
                return;
            } 

            if (primerclick == null)
            {
                primerclick = LabelClickeado;
                primerclick.ForeColor = Color.Black;
                return; 
            }

            segundoclick = LabelClickeado;
            segundoclick.ForeColor = Color.Black;

            Ganador();
            if(primerclick.Text==segundoclick.Text)
            {
                    primerclick = null;
                    segundoclick = null; 
            } 
            else 
            Timer.Start();
        } 

        private void Ganador()
        {
            Label label;
            for (int i=0; i<tableLayoutPanel1.Controls.Count;i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }
            MessageBox.Show("Felicidades haz logrado completar el nivel :)");

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();

            primerclick.ForeColor = primerclick.BackColor;
            segundoclick.ForeColor = segundoclick.BackColor;

            primerclick = null;
            segundoclick = null;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Niveles frm = new Niveles();
            frm.Show();

        }



       
    }
}
