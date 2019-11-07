﻿using Classi;
using System;
using System.Windows.Forms;

namespace Bambini.Prendi
{
    public partial class ConfermaPresa : Form
    {

        Cursor CursorOFF = new Cursor(Properties.Resources.Cursore1);
        Cursor CursorON = new Cursor(Properties.Resources.Cursore2);

        Libro LibroDaConfermare = new Libro();
        Bambino bambinoLoggato = new Bambino();
        bool allOK = false;
        public ConfermaPresa(Libro libro, Bambino bambino)
        {
            bambinoLoggato = bambino;
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
            try
            {
                allOK = Queries.PrendiLibro(LibroDaConfermare, bambinoLoggato);
            }
            catch
            {
                MessageBox.Show("Errore, riprovare!");
                Close();
                return;
            }
            MessageBox.Show("Libro preso!");
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
