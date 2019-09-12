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
    public partial class BambiniLettoUnLibro : Form
    {
        public BambiniLettoUnLibro()
        {
            InitializeComponent();
        }

        private void RicercaStatLibro_Click(object sender, EventArgs e)
        {
            Hide();
            Statistiche_WIP_.NumeroDiVolteLetti numeroDiVolteLetti = new Statistiche_WIP_.NumeroDiVolteLetti();
            numeroDiVolteLetti.ShowDialog();
            Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
