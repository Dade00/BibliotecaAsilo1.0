using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Classi;

namespace Maestre.Bambini
{
    public partial class AggiungiBambino : Form
    {
        public List<Bambino> listaBambini;


        public AggiungiBambino()
        {
            InitializeComponent();
            if(listaBambini == null)
                listaBambini = new List<Bambino>();
        }

        private void AnnullaModificaBambini_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
        private void CercaFotoBambini_Click(object sender, EventArgs e)
        {
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bambini_pic.Image = new Bitmap(ofdFoto.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                ofdFoto.FileName = "foto";
        }
        private void ConfermaModificaBambini_Click(object sender, EventArgs e)
        {
            Bambino bambino = new Bambino();

            try
            {
                if (NomeAddBambini.Text == "" || NomeAddBambini.Text == null)
                {
                    MessageBox.Show("Inserire prima il nome del bambino");
                    return;
                }

                if (CognomeAddBambini.Text == "" || CognomeAddBambini.Text == null)
                {
                    MessageBox.Show("Inserire prima il cognome del bambino");
                    return;
                }

                if (ClasseAddBambini.Text == "" || ClasseAddBambini.Text == null)
                {
                    MessageBox.Show("Inserire prima la classe del bambino");
                    return;
                }

                if (DateTime.Now.Subtract(nascitaAddBambini.Value) < new TimeSpan(365, 0, 0, 0, 0))
                {
                    MessageBox.Show("Inserire prima la data di nascita del bambino");
                    return;
                }

                if (ofdFoto.FileName == "" || ofdFoto.FileName == null)
                {
                    MessageBox.Show("Selezionare prima la foto");
                    return;
                }
                
                bambino.Nome = NomeAddBambini.Text;
                bambino.Cognome = CognomeAddBambini.Text;
                bambino.DataNascita = nascitaAddBambini.Value;
                bambino.Classe = ClasseAddBambini.Text;
                bambino.Path = "path";

                Queries.addBambino(bambino);

                bambino.ID = Queries.getMaxIDfromBambini();
                bambino.Path = @"C:\BibliotecaAsilo\IMMAGINI_BAMBINI\" + bambino.Nome + bambino.Cognome + bambino.ID + ".jpg";
                Queries.editBambino(bambino);

                MessageBox.Show("Bambino aggiunto!");

                Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            Bambini_pic.Image.Save(bambino.Path, System.Drawing.Imaging.ImageFormat.Jpeg);

        }    
        private void AggiungiBambino_Load(object sender, EventArgs e)
        {
            Bambini_pic.Image = Maestre.Properties.Resources.No_image;
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

        private void libro_label_Click(object sender, EventArgs e)
        {

        }

        private void AiutoAggiungiBambini_Click(object sender, EventArgs e)
        {
            AiutoAddBambino aiutoAddBambino = new AiutoAddBambino();
            aiutoAddBambino.ShowDialog();
            Show();
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
        }
    }
}