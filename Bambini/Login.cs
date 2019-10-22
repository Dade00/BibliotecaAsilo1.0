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

        private void Avanti_button_Click(object sender, EventArgs e)
        {
            Hide();

            int anni = -1;
            if (radioButton1.Checked)
                anni = 3;
            else if (radioButton1.Checked)
                anni = 4;
            else if (radioButton1.Checked)
                anni = 5;
            else
                return;

            if (nome_label.Text == "" || cognome_label.Text == null)
            {
                MessageBox.Show("Inserire prima il nome");
                return;
            }



            // query = select * from bambini where nome = ?
            // if(cognome!=null) query .= AND cognome = ?

            // QUERY PER PRENDERE UN BAMBINO CON

            seitu seitu = new seitu(new Classi.bambino());
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
    }
}
