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
        string nome { get; set; }
        string cognome { get; set; }
        int anni { get; set; }


        public seitu(Classi.bambino)
        {
            InitializeComponent();
        }

        private void Avanti_button_Click(object sender, EventArgs e)
        {
            Hide();
            PrendiRestituisci PrendiRestituisci = new PrendiRestituisci();
            PrendiRestituisci.ShowDialog();
            Show();
        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Seitu_Load(object sender, EventArgs e)
        {

        }
    }
}
