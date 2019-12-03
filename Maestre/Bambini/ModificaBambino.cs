using System;
using Classi;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Maestre.Bambini
{
    public partial class ModificaBambino : Form
    {
        List<Bambino> listaBambini;
        Bambino bambino = new Bambino(); //Bambino selezionato nel datagridview
        bool ModFoto = false, click = false;
        bool SelectionOK = false;

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
                if (!Queries.editBambino(new Bambino(bambino.ID, NomeBambini.Text, CognomeBambini.Text, nascitaBambini.Value, ClasseBambini.Text.ToUpper(), "")))
                {
                    MessageBox.Show("Errore");
                }
                else
                {
                    Queries.getBambini(ref listaBambini);
                    refresh();
                    if (ModFoto)
                    {
                        ModFoto = false;
                        ofdFoto.Dispose();
                        File.Delete(bambino.Path);
                        Bambini_pic.Image.Save(bambino.Path, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    NomeBambini.Text = "";
                    CognomeBambini.Text = "";
                    nascitaBambini.Value = DateTime.Now;
                    ClasseBambini.Text = "";
                    nome_tb.Text = "";
                    cognome_tb.Text = "";
                    Bambini_pic.Image = Maestre.Properties.Resources.No_image;
                } 
        }


        private void CercaFotoBambini_Click(object sender, EventArgs e)
        {
            //La foto è già selezionata (Path della foto del bambino) ed è solo eventualmente da modificare
            ModFoto = true;

            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bambini_pic.ImageLocation = ofdFoto.FileName;
                    Bambini_pic.Show();
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
            AiutoModBambino aiutoModBambino = new AiutoModBambino();
            aiutoModBambino.ShowDialog();
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
            TabellaBambini.Rows[0].Cells[0].Selected = false;
        }

        private void refresh()
        {
            bsBambini.DataSource = listaBambini;
            bsBambini.ResetBindings(true);
        }

        private void TabellaBambini_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectionOK == false)
            {
                Seleziona();
            }
            SelectionOK = true;
        }

        private void TabellaBambini_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectionOK)
            {
                Seleziona();
            }
        }

        private void Seleziona()
        {
            bambino = (Bambino)bsBambini[bsBambini.Position];
            NomeBambini.Text = bambino.Nome;
            CognomeBambini.Text = bambino.Cognome;
            ClasseBambini.Text = bambino.Classe;
            nascitaBambini.Value = bambino.DataNascita;
            if (bambino.Path != "")
            {
                try
                {
                    ofdFoto.FileName = bambino.Path;
                    Bambini_pic.ImageLocation = ofdFoto.FileName;
                }
                catch
                {
                    Bambini_pic.Image = Maestre.Properties.Resources.No_image;
                    ofdFoto.FileName = bambino.Path;
                }
            }
            else
            {
                Bambini_pic.Image = Maestre.Properties.Resources.No_image;
                ofdFoto.FileName = bambino.Path;
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (nome_tb.Text != "" || cognome_tb.Text != "")
            {
                try
                {
                    listaBambini = Queries.getBambino(nome_tb.Text, cognome_tb.Text);
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
                    Queries.getBambini(ref listaBambini);
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
