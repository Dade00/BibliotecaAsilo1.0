using Classi;
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

            if (nome_textbox.Text == "" || nome_textbox.Text == null)
            {
                MessageBox.Show("Inserire prima il nome");
                return;
            }

            if (cognome_textbox.Text == "" || cognome_textbox.Text == null)
            {
                MessageBox.Show("Inserire prima il cognome");
                return;
            }

            Bambino daPassare = Queries.getBambino(new Bambino(nome_textbox.Text, cognome_textbox.Text), anni);

            if(daPassare == null)
            {
                MessageBox.Show("Bambino non trovato");
                return;
            }

            seitu seitu = new seitu(daPassare);
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
