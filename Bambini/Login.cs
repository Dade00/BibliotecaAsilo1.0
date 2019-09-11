using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bambini
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void Login_page_Load(object sender, EventArgs e)
        {
            
        }

        private void Avanti_button_Click(object sender, EventArgs e)
        {
            Hide();
            seitu seitu = new seitu();
            seitu.ShowDialog();
            Show();
        }


        private void Return_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Help_button_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
