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
            Hide();
            ConfermaPresa confermaPresa = new ConfermaPresa();
            confermaPresa.ShowDialog();
            Show();

            
        }

        private void Librochoose_Load(object sender, EventArgs e)
        {
            //Blocco che permette la chiusura del form se si arriva dalla conferma
            if (GUIServices.ToPrendiRestituisci)
            {
                Close();
            }
        }

        private void Librochoose_VisibleChanged(object sender, EventArgs e)
        {
            //Blocco che permette la chiusura del form se si arriva dalla conferma
            if (GUIServices.ToPrendiRestituisci)
            {
                Close();
            }
        }
    }
}
