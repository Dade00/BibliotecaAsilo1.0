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

namespace Maestre.Libri
{
    public partial class AggiungiLibro : Form
    {
        public AggiungiLibro()
        {
            InitializeComponent();
        }

        List<Libro> listaLibri = new List<Libro>();

        bool GUIUpdate = false;


        private void AnnullaModificaLibro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfermaModificaLibro_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            bool flagInserimento = false;
            try
            {
                libro.Autore = AutoreAddLibro.Text;
                libro.Titolo = TitoloAddLibro.Text;
                libro.Genere = genereCB.Text;
                libro.Path = "path";
                Queries.addLibro(libro);

                libro.ID = Queries.getMaxIDfromLibri();
                libro.Path = @"C:\BibliotecaAsilo\IMMAGINI_LIBRI\" + libro.Genere + @"\" + libro.ID + ".jpg";

                flagInserimento = Queries.editLibro(libro.Path, libro.ID);
            }
            catch (Exception ex)
            {
                throw;
            }

            if (flagInserimento)
            {
                MessageBox.Show("Inserimento avvenuto!");
            }
            else
                return;

            GUIUpdate = true;

            Libri_pic.Image.Save(libro.Path, System.Drawing.Imaging.ImageFormat.Jpeg);

            

        }

        private void AggiungiLibro_Load(object sender, EventArgs e)
        {
            Libri_pic.Image = Maestre.Properties.Resources.No_image;
            Libri.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            Libri.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);
            Libri.ClearSelection();

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
                List<string> itemsGenere2 = new List<string>(itemsGenere);
                genereCB.DataSource = itemsGenere;
                genereCB_2.DataSource = itemsGenere2;
                refresh();
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

        private void InserisciFotoLibro_Click(object sender, EventArgs e)
        {
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Libri_pic.Image = new Bitmap(ofdFoto.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                ofdFoto.FileName = "foto";
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if(titolo_tb.Text != "" || autore_tb.Text != "" || genereCB_2.Text != "")
            {
                try
                {
                    listaLibri =  Queries.getLibri(titolo_tb.Text, autore_tb.Text, genereCB_2.Text); ;
                    refresh();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            if(GUIUpdate)
            {
                GUIUpdate = false;
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
        }

        private void AiutoModificaLibro_Click(object sender, EventArgs e)
        {
            AiutoAddLibri aiutoAddLibri = new AiutoAddLibri();
            aiutoAddLibri.ShowDialog();
            Show();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            titolo_tb.Text = "";
            autore_tb.Text = "";
            genereCB_2.SelectedIndex = 0;
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

        private void titolo_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void genereCB_2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Libri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Libri_SelectionChanged(object sender, EventArgs e)
        {
            Libri.ClearSelection();
        }
    }
}
