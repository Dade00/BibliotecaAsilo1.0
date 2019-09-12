using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestre.Bambini
{
    public partial class HomeBambini : Form
    {
        public HomeBambini()
        {
            InitializeComponent();
        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AggiungiBambino_Click(object sender, EventArgs e)
        {
            Bambini.AggiungiBambino aggiungiBambino = new Bambini.AggiungiBambino();
            aggiungiBambino.ShowDialog();
            Show();
        }

        private void ModificaBambino_Click(object sender, EventArgs e)
        {
            Bambini.ModificaBambino modificaBambino = new Bambini.ModificaBambino();
            modificaBambino.ShowDialog();
            Show();
        }

        private void EliminaBambino_Click(object sender, EventArgs e)
        {
            Bambini.CancellaBambino cancellaBambino = new Bambini.CancellaBambino();
            cancellaBambino.ShowDialog();
            Show();
        }
    }
}
