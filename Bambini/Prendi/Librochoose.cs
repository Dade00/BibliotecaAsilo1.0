using Classi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bambini.Prendi
{
    public partial class Librochoose : Form
    {
        string GeneredaPassare = "";
        public Librochoose(string Genere)
        {
            GeneredaPassare = Genere;
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
            //Passare la classe del libro selezionato al form successivo che andrà ad effettuare la transazione

            Libro libroSelezionato = new Libro();
            libroSelezionato = (Libro)bsLibri[bsLibri.Position];
            if (libroSelezionato != null)
            {
                Hide();
                ConfermaPresa confermaPresa = new ConfermaPresa(libroSelezionato);
                confermaPresa.ShowDialog();
                Show();
            }
            else
                return;


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

            //Modifica font datagrid
            ElencoLibri.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            ElencoLibri.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);

            //Recupero i libri
            List<Libro> libros = new List<Libro>();
            libros = Queries.getLibribyGenereNOTin_prestito(GeneredaPassare);
            bsLibri.DataSource = libros;
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

        private void ElencoLibri_CurrentCellChanged(object sender, EventArgs e)
        {
            Libro libri = new Libro();
            libri = (Libro)bsLibri[bsLibri.Position];
            immagineLibro.ImageLocation = libri.Path;
        }
    }
}
