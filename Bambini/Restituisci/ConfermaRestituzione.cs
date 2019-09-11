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
    public partial class ConfermaRestituzione : Form
    {
        public ConfermaRestituzione()
        {
            InitializeComponent();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            Hide();
            PrendiRestituisci prendiRestituisci = new PrendiRestituisci();
            prendiRestituisci.ShowDialog();
            Show();
        }
    }
}
