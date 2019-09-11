using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maestre;
using Bambini;

namespace BibliotecaAsilo
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Bambini_button_Click(object sender, EventArgs e)
        {
            Login_page login_Page = new Login_page();
            login_Page.ShowDialog();
            Show();
        }

        private void Maestre_button_Click(object sender, EventArgs e)
        {
            Home home = new Maestre.Home();
            home.ShowDialog();
            Show();
        }

        private void Esci_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
