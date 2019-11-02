using System;
using Classi;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Maestre.Bambini
{
    public partial class ModificaBambino : Form
    {
        List<Bambino> listaBambini;
        Bambino bambino = new Bambino(); //Bambino selezionato nel datagridview

        public ModificaBambino()
        {
            if (listaBambini == null)
                listaBambini = new List<Bambino>();
            InitializeComponent();
        }

        private void AnnullaModificaBambini_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfermaModificaBambini_Click(object sender, EventArgs e)
        {
            if (bambino != null)
                if (!Queries.editBambino(new Bambino(bambino.ID, NomeBambini.Text, CognomeBambini.Text, nascitaBambini.Value, ClasseBambini.Text, ofdFoto.FileName)))
                {
                    MessageBox.Show("Errore");
                }
                else
                    Close();


        }


        private void CercaFotoBambini_Click(object sender, EventArgs e)
        {
            //La foto è già selezionata (Path della foto del bambino) ed è solo eventualmente da modificare

            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bmp = new Bitmap(ofdFoto.FileName);
                    if (bmp.Width <= 350 && bmp.Height <= 350)
                        Bambini_pic.Image = bmp;
                    else
                        MessageBox.Show("La foto selezionata deve essere al massimo 350x350");
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


        private void AiutoModificaBambini_Click(object sender, EventArgs e)
        {
            ModificaBambino modificaBambino = new ModificaBambino();
            modificaBambino.ShowDialog();
            Show();
        }

        private void ModificaBambino_Load(object sender, EventArgs e)
        {
            TabellaBambini.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            TabellaBambini.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);
            try
            {
                Queries.getBambini(ref listaBambini);
                refresh();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void refresh()
        {
            bsBambini.DataSource = listaBambini;
            bsBambini.ResetBindings(true);
        }

        private void TabellaBambini_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bambino = (Bambino)bsBambini[bsBambini.Position];
            NomeBambini.Text = bambino.Nome;
            CognomeBambini.Text = bambino.Cognome;
            ClasseBambini.Text = bambino.Classe;
            nascitaBambini.Value = bambino.DataNascita;
            if(bambino.Path != "foto")
            {
                ofdFoto.FileName = bambino.Path;
                Bambini_pic.Image = new Bitmap(ofdFoto.FileName);
            }
            else
            {
                Bambini_pic.Image = Maestre.Properties.Resources.No_image;
                ofdFoto.FileName = bambino.Path;
            }

        }
    }
}
