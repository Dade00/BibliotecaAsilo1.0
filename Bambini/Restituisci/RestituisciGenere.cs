using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classi;

namespace Bambini.Restituiusci
{
    public partial class RestituisciGenere : Form
    {
        Bambino bambinoLoggato = new Bambino();
        public RestituisciGenere(Bambino da)
        {
            bambinoLoggato = da;
            InitializeComponent();
        }

        Cursor CursorOFF = new Cursor(Properties.Resources.Cursore1);
        Cursor CursorON = new Cursor(Properties.Resources.Cursore2);

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RestituisciGenere_Load(object sender, EventArgs e)
        {
            sentimenti_button.Cursor = CursorOFF;
            storie_button.Cursor = CursorOFF;
            scienze_button.Cursor = CursorOFF;
            animali_button.Cursor = CursorOFF;
            cibo_button.Cursor = CursorOFF;
            racconti_button.Cursor = CursorOFF;
            indietro_button.Cursor = CursorOFF;
            aiuto_button.Cursor = CursorOFF;
        }

        private void Sentimenti_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose("Sentimenti");
            librochoose.ShowDialog();
            Show();
        }

        private void Scienze_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose("Scienze");
            librochoose.ShowDialog();
            Show();
        }

        private void Animali_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose("Animali");
            librochoose.ShowDialog();
            Show();
        }

        private void Racconti_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose("Racconti");
            librochoose.ShowDialog();
            Show();
        }

        private void Storie_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose("Storie");
            librochoose.ShowDialog();
            Show();
        }

        private void Cibo_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose("Cibo");
            librochoose.ShowDialog();
            Show();
        }

        private void RestituisciGenere_VisibleChanged(object sender, EventArgs e)
        {
            if (GUIServices.ToPrendiRestituisci)
            {
                Close();
            }
        }


        private void Aiuto_button_MouseUp(object sender, MouseEventArgs e)
        {
            aiuto_button.Cursor = CursorOFF;
        }

        private void Aiuto_button_MouseDown(object sender, MouseEventArgs e)
        {
            aiuto_button.Cursor = CursorON;
        }

        private void Sentimenti_button_MouseUp(object sender, MouseEventArgs e)
        {
            sentimenti_button.Cursor = CursorOFF;
        }

        private void Sentimenti_button_MouseDown(object sender, MouseEventArgs e)
        {
            sentimenti_button.Cursor = CursorON;
        }

        private void Racconti_button_MouseUp(object sender, MouseEventArgs e)
        {
            racconti_button.Cursor = CursorOFF;
        }

        private void Racconti_button_MouseDown(object sender, MouseEventArgs e)
        {
            racconti_button.Cursor = CursorON;
        }

        private void Storie_button_MouseUp(object sender, MouseEventArgs e)
        {
            storie_button.Cursor = CursorOFF;
        }

        private void Storie_button_MouseDown(object sender, MouseEventArgs e)
        {
            storie_button.Cursor = CursorON;
        }

        private void Scienze_button_MouseUp(object sender, MouseEventArgs e)
        {
            scienze_button.Cursor = CursorOFF;
        }

        private void Scienze_button_MouseDown(object sender, MouseEventArgs e)
        {
            scienze_button.Cursor = CursorON;
        }

        private void Animali_button_MouseUp(object sender, MouseEventArgs e)
        {
            animali_button.Cursor = CursorOFF;
        }

        private void Animali_button_MouseDown(object sender, MouseEventArgs e)
        {
            animali_button.Cursor = CursorON;
        }

        private void Cibo_button_MouseUp(object sender, MouseEventArgs e)
        {
            cibo_button.Cursor = CursorOFF;
        }

        private void Cibo_button_MouseDown(object sender, MouseEventArgs e)
        {
            cibo_button.Cursor = CursorON;
        }

        private void Indietro_button_MouseUp(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorOFF;
        }

        private void Indietro_button_MouseDown(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorON;
        }

        private void Aiuto_button_Click(object sender, EventArgs e)
        {
            Restituisci.AiutoGenere aiutoGenere = new Restituisci.AiutoGenere();
            aiutoGenere.ShowDialog();
            Show();
        }

    }
}
