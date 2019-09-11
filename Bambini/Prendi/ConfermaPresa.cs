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
    public partial class ConfermaPresa : Form
    {
        public ConfermaPresa()
        {
            InitializeComponent();
        }

        private void ConfermaPresa_Load(object sender, EventArgs e)
        {

        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
