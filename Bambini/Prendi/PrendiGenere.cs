﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bambini.Prendi
{
    public partial class PrendiGeneree : Form
    {
        public PrendiGeneree()
        {
            InitializeComponent();
        }

        private void Prendi_Load(object sender, EventArgs e)
        {

        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sentimenti_button_Click(object sender, EventArgs e)
        {
            Librochoose librochoose = new Librochoose();
            librochoose.ShowDialog();
            Show();
            closingControl();
        }

        private void Scienze_button_Click(object sender, EventArgs e)
        {
            Librochoose librochoose = new Librochoose();
            librochoose.ShowDialog();
            Show();
            closingControl();
        }

        private void Animali_button_Click(object sender, EventArgs e)
        {
            Librochoose librochoose = new Librochoose();
            librochoose.ShowDialog();
            Show();
            closingControl();
        }

        private void Racconti_button_Click(object sender, EventArgs e)
        {
            Librochoose librochoose = new Librochoose();
            librochoose.ShowDialog();
            Show();
            closingControl();
        }

        private void Storie_button_Click(object sender, EventArgs e)
        {
            Librochoose librochoose = new Librochoose();
            librochoose.ShowDialog();
            Show();
            closingControl();
        }

        private void Cibo_button_Click(object sender, EventArgs e)
        {
            Librochoose librochoose = new Librochoose();
            librochoose.ShowDialog();
            Show();
            closingControl();
        }

        private void closingControl()
        {
            //Blocco che permette la chiusura del form se si arriva dalla conferma
            if (GUIServices.ToPrendiRestituisci)
            {
                Close();
            }
        }
    }
}
