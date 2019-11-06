using Classi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Maestre.Libri
{
    public partial class EliminaLibro : Form
    {
        List<Libro> listaLibri = new List<Libro>();
        bool updateGUI = false, resetButton = false;
        public EliminaLibro()
        {
            InitializeComponent();
        }

        private void Libro_label_Click(object sender, EventArgs e)
        {

        }

        private void Nome_label_Click(object sender, EventArgs e)
        {

        }

        private void AnnullaEliminaLibro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfermaEliminaLibro_Click(object sender, EventArgs e)
        {
            Libro libri = new Libro();
            libri = (Libro)bsLibri[bsLibri.Position];
            updateGUI = Queries.delLibro(libri.ID);
            if(updateGUI)
            {
                MessageBox.Show("Libro eliminato");
            }
        }

        private void EliminaLibro_Load(object sender, EventArgs e)
        {
            Libri_pic.Image = Maestre.Properties.Resources.No_image;
            ElencoLibri.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            ElencoLibri.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);

            try
            {
                listaLibri = Queries.getLibri();
                refresh();
            }
            catch (Exception ex)
            {
                throw;
            }

            try
            {
                List<string> itemsGenere = Queries.getGenere();
                Genere_CB.DataSource = itemsGenere;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void refresh()
        {
            bsLibri.DataSource = listaLibri;
            bsLibri.ResetBindings(true);
        }

        private void Cerca_button_Click(object sender, EventArgs e)
        {
            resetButton = false;

            try
            {
                listaLibri = Queries.getLibri(titolo_tb.Text, autore_tb.Text, Genere_CB.Text);
                refresh();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            titolo_tb.Text = "";
            autore_tb.Text = "";
            Genere_CB.SelectedIndex = 0;
            resetButton = true;
            try
            {
                listaLibri = Queries.getLibri();
                refresh();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void ElencoLibri_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Libro libri = new Libro();
                libri = (Libro)bsLibri[bsLibri.Position];
                Libri_pic.ImageLocation = libri.Path;

            }
            catch
            { }
        }

        private void UpdateDATA_Tick(object sender, EventArgs e)
        {
            if (updateGUI)
            {
                updateGUI = false;
                if (resetButton)
                {
                    try
                    {
                        listaLibri = Queries.getLibri();
                        refresh();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
                else
                {
                    try
                    {
                        listaLibri = Queries.getLibri(titolo_tb.Text, autore_tb.Text, Genere_CB.Text);
                        refresh();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }
    }
}
