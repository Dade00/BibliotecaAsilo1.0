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

        Cursor CursorOFF = new Cursor(Bambini.Properties.Resources.Cursore1);
        Cursor CursorON = new Cursor(Bambini.Properties.Resources.Cursore2);

        private void Homepage_Load(object sender, EventArgs e)
        {
            maestre_button.Cursor = CursorOFF;
            bambini_button.Cursor = CursorOFF;
            Esci_button.Cursor = CursorOFF;
            crediti_button.Cursor = CursorOFF;

            //Se primo avvio creazione della cartella di destinazione delle immagini/cursori/oggetti vari da salvare
            //Sottocartella IMMAGINI_LIBRI 

        }

        private void Bambini_button_MouseUp(object sender, MouseEventArgs e)
        {
            bambini_button.Cursor = CursorOFF;
        }

        private void Bambini_button_MouseDown(object sender, MouseEventArgs e)
        {
            bambini_button.Cursor = CursorON;
        }

        private void Maestre_button_MouseDown(object sender, MouseEventArgs e)
        {
            maestre_button.Cursor = CursorON;
        }

        private void Maestre_button_MouseUp(object sender, MouseEventArgs e)
        {
            maestre_button.Cursor = CursorOFF;
        }

        private void Esci_button_MouseDown(object sender, MouseEventArgs e)
        {
            Esci_button.Cursor = CursorON;
        }

        private void Esci_button_MouseUp(object sender, MouseEventArgs e)
        {
            Esci_button.Cursor = CursorON;
        }

        private void Crediti_button_MouseUp(object sender, MouseEventArgs e)
        {
            crediti_button.Cursor = CursorOFF;
        }

        private void Crediti_button_MouseDown(object sender, MouseEventArgs e)
        {
            crediti_button.Cursor = CursorON;
        }

        private void Crediti_button_Click(object sender, EventArgs e)
        {
            FormCrediti formCrediti = new FormCrediti();
            formCrediti.Show();
        }
    }
}
