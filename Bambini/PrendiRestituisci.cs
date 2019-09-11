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
    }
}
