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

        int TabIndex = 0; //0=nulla, 1 = bambini, 2=libri, 3 = statistiche
        public Home()
        {
            InitializeComponent();
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
                this.BackgroundImage = Maestre.Properties.Resources.Sfondo_maestre_con_menu;
                TabIndex = 2;
                AllButtonsOff();
                LibriVisibile();
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
                this.BackgroundImage = Maestre.Properties.Resources.Sfondo_maestre_con_menu;
                AllButtonsOff();
                StatVisible();
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
                this.BackgroundImage = Maestre.Properties.Resources.Sfondo_maestre_con_menu;
                TabIndex = 1;
                AllButtonsOff();
                BambinoVisible();
            }
            else
            {
                Bambini_radio.BackgroundImage = Maestre.Properties.Resources.Bambini;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Inizializzazione tasti
            //Aggiungi sezione
            AggiungiLibro.Location = AggiungiBambino.Location;
            StatLibri.Location = AggiungiBambino.Location;

            //Modifica sezione
            ModificaLibro.Location = ModificaBambino.Location;
            StatBambini.Location = ModificaBambino.Location;

            //Rimuovi sezione
            EliminaLibro.Location = EliminaBambino.Location;
            DelStat.Location = EliminaBambino.Location;

            this.BackgroundImage = Maestre.Properties.Resources.Sfondo_maestre;

            AllButtonsOff();
        }

        private void LibriVisibile()
        {
            AggiungiLibro.Visible = true;
            ModificaLibro.Visible = true;
            EliminaLibro.Visible = true;
        }

        private void BambinoVisible()
        {
            AggiungiBambino.Visible = true;
            ModificaBambino.Visible = true;
            EliminaBambino.Visible = true;
        }
        private void StatVisible()
        {
            DelStat.Visible = true;
            StatLibri.Visible = true;
            StatBambini.Visible = true;
        }

        private void AllButtonsOff()
        {
            AggiungiBambino.Visible = false;
            AggiungiLibro.Visible = false;
            StatLibri.Visible = false;
            ModificaBambino.Visible = false;
            ModificaLibro.Visible = false;
            StatBambini.Visible = false;
            EliminaBambino.Visible = false;
            EliminaLibro.Visible = false;
            DelStat.Visible = false;
        }

        private void Home_VisibleChanged(object sender, EventArgs e)
        {
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

        private void Home_Click(object sender, EventArgs e)
        {
            AllButtonsOff();
            this.BackgroundImage = Maestre.Properties.Resources.Sfondo_maestre;
            Libri_radio.BackgroundImage = Maestre.Properties.Resources.Libri;
            Bambini_radio.BackgroundImage = Maestre.Properties.Resources.Bambini;
            Statistiche_radio.BackgroundImage = Maestre.Properties.Resources.Statistiche;
            Libri_radio.Checked = false;
            Bambini_radio.Checked = false;
            Statistiche_radio.Checked = false;
        }
    }
}
