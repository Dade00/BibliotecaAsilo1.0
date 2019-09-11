using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bambini.Prendi
{
    public partial class Librochoose : Form
    {
        public Librochoose()
        {
            InitializeComponent();
        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            ConfermaPresa confermaPresa = new ConfermaPresa();
            confermaPresa.ShowDialog();
            Show();
        }
    }
}
