﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestre
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            Statistiche_WIP_.Home home = new Statistiche_WIP_.Home();
            home.ShowDialog();
            Show();
        }

        private void Bambini_button_Click(object sender, EventArgs e)
        {
            Hide();
            Bambini.HomeBambini homeBambini = new Bambini.HomeBambini();
            homeBambini.ShowDialog();
            Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();
            Libri.HomeLibri homeLibri = new Libri.HomeLibri();
            homeLibri.ShowDialog();
            Show();
        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
