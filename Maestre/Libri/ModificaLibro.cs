using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using Classi;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestre.Libri
{
    public partial class ModificaLibro : Form
    {
        Libro libro = new Libro();
        List<Libro> listaLibri = new List<Libro>();
        bool ModFoto = false;
        bool GUIUpdate = false;
        public ModificaLibro()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            bsLibri.DataSource = listaLibri;
            bsLibri.ResetBindings(true);
        }

        private void Libro_label_Click(object sender, EventArgs e)
        {

        }

        private void AnnullaModificaLibro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TabellaBambini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AiutoAggiungiLibro_Click(object sender, EventArgs e)
        {
            AiutoModLibri aiutoModLibri = new AiutoModLibri();
            aiutoModLibri.ShowDialog();
            Show();
        }

        private void ModificaLibro_Load(object sender, EventArgs e)
        {
            Libri_pic.Image = Maestre.Properties.Resources.No_image;
            ElencoLibri.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            ElencoLibri.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);

            try
            {
                listaLibri = Queries.getLibri();
                bsLibri.DataSource = listaLibri;
                bsLibri.ResetBindings(true);
                List<string> vs = new List<string>();
                vs = Queries.getGenere();
                genere_cb.DataSource = vs;
            }
            catch (Exception ex)
            {
                throw;
            }

            try
            {
                List<string> itemsGenere = Queries.getGenere();
                List<string> itemsGenere2 = new List<string>(itemsGenere);
                genereCB_2.DataSource = itemsGenere2;
                refresh();
            }
            catch (Exception ex)
            {
                throw;
            }
            ElencoLibri.Rows[0].Cells[0].Selected = false;
        }

        private void ElencoLibri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            libro = (Libro)bsLibri[bsLibri.Position];
            TitotloModLibro.Text = libro.Titolo;
            AutoreModLibro.Text = libro.Autore;
            genere_cb.Text = libro.Genere;
            if (libro.Path != "foto")
            {
                ofdFoto.FileName = libro.Path;
                Libri_pic.ImageLocation = ofdFoto.FileName;
            }
            else
            {
                Libri_pic.Image = Maestre.Properties.Resources.No_image;
                ofdFoto.FileName = libro.Path;
            }

        }

        private void CercaFotoLibro_Click(object sender, EventArgs e)
        {
            //La foto è già selezionata (Path della foto del libro) ed è solo eventualmente da modificare
            ModFoto = true;

            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Libri_pic.ImageLocation = ofdFoto.FileName;
                    ofdFoto.FileName = "foto";
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            else
                ofdFoto.FileName = "";
        }

        private void AnnullaModifica_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfermaButton_Click(object sender, EventArgs e)
        {
            if (libro != null)
            {
                Libro Libro_mod = new Libro();
                Libro_mod.ID = libro.ID;
                Libro_mod.Titolo = TitotloModLibro.Text;
                Libro_mod.Autore = AutoreModLibro.Text;
                Libro_mod.Genere = genere_cb.Text;


                if (!Queries.editLibro(Libro_mod))
                {
                    MessageBox.Show("Errore");
                }
                else
                {
                    listaLibri = Queries.getLibri();
                    refresh();
                    if (ModFoto)
                    {
                        ModFoto = false;
                        ofdFoto.Dispose();
                        File.Delete(libro.Path);
                        Libri_pic.Image.Save(libro.Path, System.Drawing.Imaging.ImageFormat.Jpeg);
                        
                    }
                }
                
            }
        }


        private void Search_button_Click(object sender, EventArgs e)
        {
            if (titolo_tb.Text != "" || autore_tb.Text != "" || genereCB_2.Text != "")
            {
                try
                {
                    listaLibri = Queries.getLibri(titolo_tb.Text, autore_tb.Text, genereCB_2.Text); ;
                    refresh();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
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


        private void ElencoLibri_SelectionChanged(object sender, EventArgs e)
        {
            libro = (Libro)bsLibri[bsLibri.Position];
            TitotloModLibro.Text = libro.Titolo;
            AutoreModLibro.Text = libro.Autore;
            genere_cb.Text = libro.Genere;
            if (libro.Path != "foto")
            {
                ofdFoto.FileName = libro.Path;
                Libri_pic.ImageLocation = ofdFoto.FileName;
            }
            else
            {
                ofdFoto.FileName = libro.Path;
            }
        }
    }
}
