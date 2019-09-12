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
    public partial class Librochoose : Form
    {
        public Librochoose()
        {
            InitializeComponent();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            Hide();
            ConfermaRestituzione confermaRestituzione = new ConfermaRestituzione();
            confermaRestituzione.ShowDialog();
            Show();
        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Librochoose_VisibleChanged(object sender, EventArgs e)
        {
            if (GUIServices.ToPrendiRestituisci)
            {
                Close();
            }
        }
    }
}
