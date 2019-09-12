using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestre.Statistiche_WIP_
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            Statistiche_WIP_.LibriLettiDaBambino libriLettiDaBambino = new Statistiche_WIP_.LibriLettiDaBambino();
            libriLettiDaBambino.ShowDialog();
            Show();
        }

        private void StatLibri_Click(object sender, EventArgs e)
        {
            Hide();
            Statistiche_WIP_.BambiniLettoUnLibro bambiniLettoUnLibro = new Statistiche_WIP_.BambiniLettoUnLibro();
            bambiniLettoUnLibro.ShowDialog();
            Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
