using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestre.Libri
{
    public partial class HomeLibri : Form
    {
        public HomeLibri()
        {
            InitializeComponent();
        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AggiungiLibro_Click(object sender, EventArgs e)
        {
            Libri.AggiungiLibro aggiungiLibro = new Libri.AggiungiLibro();
            aggiungiLibro.ShowDialog();
            Show();
        }

        private void ModificaLibro_Click(object sender, EventArgs e)
        {
            Libri.ModificaLibro modificaLibro = new Libri.ModificaLibro();
            modificaLibro.ShowDialog();
            Show();
        }

        private void EliminaLibro_Click(object sender, EventArgs e)
        {
            Libri.EliminaLibro eliminaLibro = new Libri.EliminaLibro();
            eliminaLibro.ShowDialog();
            Show();
        }
    }
}
