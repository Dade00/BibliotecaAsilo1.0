using Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bambini // BASSANO SEI TU?
{
    public partial class seitu : Form
    {
        Bambino bambinoDaConfermare;

        Cursor CursorOFF = new Cursor(Properties.Resources.Cursore1);
        Cursor CursorON = new Cursor(Properties.Resources.Cursore2);

        public seitu(Bambino da)
        {
            bambinoDaConfermare = da;
            InitializeComponent();
        }

        private void Avanti_button_Click(object sender, EventArgs e)
        {
            Hide();
            PrendiRestituisci PrendiRestituisci = new PrendiRestituisci(bambinoDaConfermare);
            PrendiRestituisci.ShowDialog();
            Show();
        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Seitu_Load(object sender, EventArgs e)
        {
            avanti_button.Cursor = CursorOFF;
            indietro_button.Cursor = CursorOFF;
            lblNome.Text = bambinoDaConfermare.Nome;
            lblCognome.Text = bambinoDaConfermare.Cognome;
            if(bambinoDaConfermare.Path == "")
            {
                pbFoto.BackgroundImage = Bambini.Properties.Resources.No_image;
            }
            else
            {
                pbFoto.ImageLocation = bambinoDaConfermare.Path;
            }
        }

        private void Indietro_button_MouseDown(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorON;
        }

        private void Indietro_button_MouseUp(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorOFF;
        }

        private void Avanti_button_MouseUp(object sender, MouseEventArgs e)
        {
            avanti_button.Cursor = CursorOFF;
        }

        private void Avanti_button_MouseDown(object sender, MouseEventArgs e)
        {
            avanti_button.Cursor = CursorON;
        }
    }
}
