using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bambini
{
    public partial class PrendiRestituisci : Form
    {
        public PrendiRestituisci()
        {
            InitializeComponent();
        }

        Cursor CursorOFF = new Cursor(Properties.Resources.Cursore1);
        Cursor CursorON = new Cursor(Properties.Resources.Cursore2);
        private void Prendi_button_Click(object sender, EventArgs e)
        {
            Hide();
            Prendi.PrendiGeneree prendiGeneree = new Prendi.PrendiGeneree();
            prendiGeneree.ShowDialog();
            Show();
        }

        private void Restituisci_button_Click(object sender, EventArgs e)
        {
            Hide();
            Restituiusci.RestituisciGenere restituisciGenere = new Restituiusci.RestituisciGenere();
            restituisciGenere.ShowDialog();
            Show();
        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrendiRestituisci_VisibleChanged(object sender, EventArgs e)
        {
            GUIServices.ToPrendiRestituisci = false;
        }

        private void PrendiRestituisci_Load(object sender, EventArgs e)
        {
            //Cursore
            prendi_button.Cursor = CursorOFF;
            restituisci_button.Cursor = CursorOFF;
            indietro_button.Cursor = CursorOFF;
            help_button.Cursor = CursorOFF;

        }

        private void Indietro_button_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = CursorON;
        }

        private void Indietro_button_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = CursorOFF;
        }

        private void Prendi_button_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = CursorON;
        }

        private void Prendi_button_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = CursorOFF;
        }

        private void Restituisci_button_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = CursorON;
        }

        private void Restituisci_button_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = CursorOFF;
        }

        private void Help_button_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = CursorOFF;
        }

        private void Help_button_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = CursorON;
        }

        private void Help_button_Click(object sender, EventArgs e)
        {
            AiutoPrendiRestituisci aiutoPrendiRestituisci = new AiutoPrendiRestituisci();
            aiutoPrendiRestituisci.ShowDialog();
            Show();
        }
    }
}
