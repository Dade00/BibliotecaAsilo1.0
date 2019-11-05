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

        


        private void AnnullaModificaLibro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfermaModificaLibro_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro(); 

            try
            {
                libro.Autore = AutoreAddLibro.Text;
                libro.Titolo = TitoloAddLibro.Text;
                libro.Genere = genereCB.Text;
                libro.Path = ofdFoto.FileName;

                Queries.addLibro(libro);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void AggiungiLibro_Load(object sender, EventArgs e)
        {
            Libri_pic.Image = Maestre.Properties.Resources.No_image;
            Libri.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            Libri.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);

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
                genereCB.DataSource = itemsGenere;
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

        }
    }
}
