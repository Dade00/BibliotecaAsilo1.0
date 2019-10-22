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
            if (radioButton1.Checked)
                radioButton1.Image = Bambini.Properties.Resources._3anni_acceso;
            else
                radioButton1.Image = Bambini.Properties.Resources._3anni_button;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                radioButton2.Image = Bambini.Properties.Resources._4anni_acceso;
            else
                radioButton2.Image = Bambini.Properties.Resources._4anni_button;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                radioButton3.Image = Bambini.Properties.Resources._5anni_acceso;
            else
                radioButton3.Image = Bambini.Properties.Resources._5anni_button;
        }
    }
}
