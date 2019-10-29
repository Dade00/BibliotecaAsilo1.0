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
    public partial class Librochoose : Form
    {
        public Librochoose()
        {
            InitializeComponent();
        }

        Cursor CursorOFF = new Cursor(Properties.Resources.Cursore1);
        Cursor CursorON = new Cursor(Properties.Resources.Cursore2);

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            Hide();
            ConfermaPresa confermaPresa = new ConfermaPresa();
            confermaPresa.ShowDialog();
            Show();

            
        }

        private void Librochoose_VisibleChanged(object sender, EventArgs e)
        {
            //Blocco che permette la chiusura del form se si arriva dalla conferma
            if (GUIServices.ToPrendiRestituisci)
            {
                Close();
            }
        }

        private void Up_button_Click(object sender, EventArgs e)
        {

        }

        private void Down_button_Click(object sender, EventArgs e)
        {

        }

        private void Librochoose_Load(object sender, EventArgs e)
        {
            up_button.Cursor = CursorOFF;
            down_button.Cursor = CursorOFF;
            avanti_button.Cursor = CursorOFF;
            indietro_button.Cursor = CursorOFF;
        }

        private void Up_button_MouseUp(object sender, MouseEventArgs e)
        {
            up_button.Cursor = CursorOFF;
        }

        private void Up_button_MouseDown(object sender, MouseEventArgs e)
        {
            up_button.Cursor = CursorON;
        }

        private void Down_button_MouseUp(object sender, MouseEventArgs e)
        {
            down_button.Cursor = CursorOFF;
        }

        private void Down_button_MouseDown(object sender, MouseEventArgs e)
        {
            down_button.Cursor = CursorON;
        }

        private void Indietro_button_MouseDown(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorON;
        }

        private void Indietro_button_MouseUp(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorOFF;
        }

        private void Avanti_button_MouseUp(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorOFF;
        }

        private void Avanti_button_MouseDown(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorON;
        }
    }
}
