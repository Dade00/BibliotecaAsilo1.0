using System;
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

            /*
            Hide();
            Statistiche_WIP_.Home home = new Statistiche_WIP_.Home();
            home.ShowDialog();
            Show();
            */
        }

        private void Bambini_button_Click(object sender, EventArgs e)
        {

            /*
            Hide();
            Bambini.HomeBambini homeBambini = new Bambini.HomeBambini();
            homeBambini.ShowDialog();
            Show();
            */
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            /*
            Hide();
            Libri.HomeLibri homeLibri = new Libri.HomeLibri();
            homeLibri.ShowDialog();
            Show();
            */
        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AggiungiLibro_Click(object sender, EventArgs e)
        {
            Hide();
            Libri.AggiungiLibro aggiungiLibro = new Libri.AggiungiLibro();
            aggiungiLibro.ShowDialog();
            Show();
        }

        private void ModificaLibro_Click(object sender, EventArgs e)
        {
            Hide();
            Libri.ModificaLibro modificaLibro = new Libri.ModificaLibro();
            modificaLibro.ShowDialog();
            Show();
        }

        private void EliminaLibro_Click(object sender, EventArgs e)
        {
            Hide();
            Libri.EliminaLibro eliminaLibro = new Libri.EliminaLibro();
            eliminaLibro.ShowDialog();
            Show();
        }

        private void AggiungiBambino_Click(object sender, EventArgs e)
        {
            Hide();
            Bambini.AggiungiBambino aggiungiBambino = new Bambini.AggiungiBambino();
            aggiungiBambino.ShowDialog();
            Show();
        }

        private void ModificaBambino_Click(object sender, EventArgs e)
        {
            Hide();
            Bambini.ModificaBambino modificaBambino = new Bambini.ModificaBambino();
            modificaBambino.ShowDialog();
            Show();
        }

        private void StatBambini_Click_1(object sender, EventArgs e)
        {
            Hide();
            Statistiche_WIP_.LibriLettiDaBambino libriLettiDaBambino = new Statistiche_WIP_.LibriLettiDaBambino();
            libriLettiDaBambino.ShowDialog();
            Show();
        }

        private void StatLibri_Click_1(object sender, EventArgs e)
        {
            Hide();
            Statistiche_WIP_.BambiniLettoUnLibro bambiniLettoUnLibro = new Statistiche_WIP_.BambiniLettoUnLibro();
            bambiniLettoUnLibro.ShowDialog();
            Show();
        }

        private void Libri_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Libri_radio.Checked)
            {
                Libri_radio.BackgroundImage = Maestre.Properties.Resources.Libri_ON;
                TabControl.SelectedIndex = 1;
            }
            else
            {
                Libri_radio.BackgroundImage = Maestre.Properties.Resources.Libri;
            }
        }

        private void Statistiche_radio_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Statistiche_radio.Checked)
            {
                Statistiche_radio.BackgroundImage = Maestre.Properties.Resources.Statistiche_ON;
                TabControl.SelectedIndex = 2;
            }
            else
            {
                Statistiche_radio.BackgroundImage = Maestre.Properties.Resources.Statistiche;
            }
        }

        private void Bambini_radio_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Bambini_radio.Checked)
            {
                Bambini_radio.BackgroundImage = Maestre.Properties.Resources.Bambini_ON;
                TabControl.SelectedIndex = 0;
            }
            else
            {
                Bambini_radio.BackgroundImage = Maestre.Properties.Resources.Bambini;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 3;
        }

        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 3;
            //De-seleziona il radio selezionato prima di ritornare indietro, per poterne selezionare un'altro
            Bambini_radio.Checked = false;
            Libri_radio.Checked = false;
            Statistiche_radio.Checked = false;
        }

        private void EliminaBambino_Click(object sender, EventArgs e)
        {
            Hide();
            Bambini.CancellaBambino cancellaBambino = new Bambini.CancellaBambino();
            cancellaBambino.ShowDialog();
            Show();
        }

        private void Bambini_page_Click(object sender, EventArgs e)
        {

        }
    }
}
