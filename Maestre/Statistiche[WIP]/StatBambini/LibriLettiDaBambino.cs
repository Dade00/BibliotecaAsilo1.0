﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestre.Statistiche_WIP_
{
    public partial class LibriLettiDaBambino : Form
    {
        public LibriLettiDaBambino()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void LibriLettiDaBambino_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Indietro_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RicercaStatBambini_Click(object sender, EventArgs e)
        {
            Hide();
            Statistiche_WIP_.LibriLetti libriLetti = new Statistiche_WIP_.LibriLetti();
            libriLetti.ShowDialog();
            Show();
        }
    }
}