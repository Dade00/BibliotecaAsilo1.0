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


        Cursor CursorOFF = new Cursor(Properties.Resources.Cursore1);
        Cursor CursorON = new Cursor(Properties.Resources.Cursore2);

        private void Avanti_button_Click(object sender, EventArgs e)
        {
            int anni = -1;

            if (radioButton1.Checked)
                anni = 3;
            else if (radioButton2.Checked)
                anni = 4;
            else if (radioButton3.Checked)
                anni = 5;
            else
            {
                MessageBox.Show("Inserisci l'età");
                return;
            }

            if (nome_textbox.Text == "" || nome_textbox.Text == "")
            {
                MessageBox.Show("Inserire prima il nome");
                return;
            }

            if (cognome_textbox.Text == "" || cognome_textbox.Text == "")
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

            Hide();
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
            AiutoLogin aiutoLogin = new AiutoLogin();
            aiutoLogin.ShowDialog();
            Show();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                radioButton1.BackgroundImage = Properties.Resources._3anni_acceso;
            else
                radioButton1.BackgroundImage = Properties.Resources._3anni_button;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                radioButton2.BackgroundImage = Bambini.Properties.Resources._4anni_acceso;
            else
                radioButton2.BackgroundImage = Bambini.Properties.Resources._4anni_button;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                radioButton3.BackgroundImage = Bambini.Properties.Resources._5anni_acceso;
            else
                radioButton3.BackgroundImage = Bambini.Properties.Resources._5anni_button;
        }

        private void Chisei_label_Click(object sender, EventArgs e)
        {

        }

        private void Login_page_Load(object sender, EventArgs e)
        {
            //Inserimento nella directory del programma i cursori personalizzati
            radioButton1.Cursor = CursorOFF;
            radioButton2.Cursor = CursorOFF;
            radioButton3.Cursor = CursorOFF;
            return_button.Cursor = CursorOFF;
            avanti_button.Cursor = CursorOFF;
            help_button.Cursor = CursorOFF;
        }

        private void RadioButton2_MouseUp(object sender, MouseEventArgs e)
        {
            radioButton2.Cursor = CursorOFF;
        }

        private void RadioButton2_MouseDown(object sender, MouseEventArgs e)
        {
           radioButton2.Cursor = CursorON;
        }

        private void RadioButton1_MouseUp(object sender, MouseEventArgs e)
        {
            radioButton1.Cursor = CursorOFF;
        }

        private void RadioButton1_MouseDown(object sender, MouseEventArgs e)
        {
            radioButton1.Cursor = CursorON;
        }

        private void RadioButton3_MouseUp(object sender, MouseEventArgs e)
        {
            radioButton3.Cursor = CursorOFF;
        }

        private void RadioButton3_MouseDown(object sender, MouseEventArgs e)
        {
            radioButton3.Cursor = CursorON;
        }

        private void Help_button_MouseUp(object sender, MouseEventArgs e)
        {
            help_button.Cursor = CursorOFF;
        }

        private void Help_button_MouseDown(object sender, MouseEventArgs e)
        {
            help_button.Cursor = CursorON;
        }

        private void Avanti_button_MouseUp(object sender, MouseEventArgs e)
        {
            avanti_button.Cursor = CursorOFF;
        }

        private void Avanti_button_MouseDown(object sender, MouseEventArgs e)
        {
            avanti_button.Cursor = CursorON;
        }

        private void Return_button_MouseUp(object sender, MouseEventArgs e)
        {
            return_button.Cursor = CursorOFF;
        }

        private void Return_button_MouseDown(object sender, MouseEventArgs e)
        {
            return_button.Cursor = CursorON;
        }
    }
}
