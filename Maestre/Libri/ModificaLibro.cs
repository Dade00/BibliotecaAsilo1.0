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
        public ModificaLibro()
        {
            InitializeComponent();
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

        private void ConfermaModificaLibro_Click(object sender, EventArgs e)
        {
            if (libro != null)
            {
                Libro Libro_mod = new Libro();
                Libro_mod.ID = libro.ID;
                Libro_mod.Titolo = TitotloModLibro.Text;
                Libro_mod.Autore = AutoreModLibro.Text;
                Libro_mod.Genere = GenereModLibro.Text;


                if (!Queries.editLibro(Libro_mod))
                {
                    MessageBox.Show("Errore");
                }
                else
                {
                    Close();
                }
                File.Delete(libro.Path);
                Libri_pic.Image.Save(libro.Path, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
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
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void ElencoLibri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            libro = (Libro)bsLibri[bsLibri.Position];
            TitotloModLibro.Text = libro.Titolo;
            AutoreModLibro.Text = libro.Autore;
            GenereModLibro.Text = libro.Genere;
            if (libro.Path != "foto")
            {
                ofdFoto.FileName = libro.Path;
                Libri_pic.Image = new Bitmap(ofdFoto.FileName);
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

            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bmp = new Bitmap(ofdFoto.FileName);
                    Libri_pic.Image = new Bitmap(ofdFoto.FileName);
                    bmp.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
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
                Libro_mod.Genere = GenereModLibro.Text;


                if (!Queries.editLibro(Libro_mod))
                {
                    MessageBox.Show("Errore");
                }
                else
                {
                    Close();
                }
                File.Delete(libro.Path);
                Libri_pic.Image.Save(libro.Path, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}
