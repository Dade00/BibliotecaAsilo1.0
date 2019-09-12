using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bambini.Restituiusci
{
    public partial class RestituisciGenere : Form
    {
        public RestituisciGenere()
        {
            InitializeComponent();
        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RestituisciGenere_Load(object sender, EventArgs e)
        {

        }

        private void Sentimenti_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose();
            librochoose.ShowDialog();
            Show();
        }

        private void Scienze_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose();
            librochoose.ShowDialog();
            Show();
        }

        private void Animali_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose();
            librochoose.ShowDialog();
            Show();
        }

        private void Racconti_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose();
            librochoose.ShowDialog();
            Show();
        }

        private void Storie_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose();
            librochoose.ShowDialog();
            Show();
        }

        private void Cibo_button_Click(object sender, EventArgs e)
        {
            Hide();
            Librochoose librochoose = new Librochoose();
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
    }
}
