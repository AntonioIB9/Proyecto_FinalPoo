﻿using System;
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
    public partial class Desafio : Form
    {
        public Desafio()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
            Nivel2 frm = new Nivel2();
            frm.Show();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Niveles frm = new Niveles();
            frm.Show();
        }
    }
}
