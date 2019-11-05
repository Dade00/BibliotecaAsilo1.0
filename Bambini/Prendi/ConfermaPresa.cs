using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classi;

namespace Bambini.Prendi
{
    public partial class ConfermaPresa : Form
    {

        Cursor CursorOFF = new Cursor(Properties.Resources.Cursore1);
        Cursor CursorON = new Cursor(Properties.Resources.Cursore2);

        Libro LibroDaConfermare = new Libro();

        public ConfermaPresa(Libro libro)
        {
            LibroDaConfermare = libro;
            InitializeComponent();
        }


        private void ConfermaPresa_Load(object sender, EventArgs e)
        {
            ok_button.Cursor = CursorOFF;
            nomelibro_label.Text = LibroDaConfermare.Titolo;
            data_label.Text = DateTime.Now.ToString();
            pb_LIBRO.ImageLocation = LibroDaConfermare.Path;
        }

        private void Ok_button_Click_1(object sender, EventArgs e)
        {
            GUIServices.ToPrendiRestituisci = true;
            Close();
        }

        private void Ok_button_MouseUp(object sender, MouseEventArgs e)
        {
            ok_button.Cursor = CursorOFF;
        }

        private void Ok_button_MouseDown(object sender, MouseEventArgs e)
        {
            ok_button.Cursor = CursorON;
        }
    }
}
