using System;
using Classi;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Maestre.Bambini
{
    public partial class ModificaBambino : Form
    {
        int selectedId;
        List<Bambino> listaBambini;

        public ModificaBambino()
        {
            selectedId = -1;
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
            if (selectedId >= 0)
                Queries.editBambino(new Bambino(selectedId, NomeModBambini.Text, CognomeModBambini.Text, nascitaModificaBambini.Value, ClasseModBambini.Text, ofdFoto.FileName));
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedId = (int)TabellaBambini.SelectedCells[0].Value;
                int i = 0;
                while (listaBambini[i].ID != selectedId)
                    i++;
                NomeModBambini.Text = listaBambini[i].Nome;
                CognomeModBambini.Text = listaBambini[i].Cognome;
                ClasseModBambini.Text = listaBambini[i].Classe;
                nascitaModificaBambini.Value = listaBambini[i].DataNascita;
                ofdFoto.FileName = listaBambini[i].Path;
                Bambini_pic.Image = new Bitmap(ofdFoto.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CercaFotoBambini_Click(object sender, EventArgs e)
        {
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

        private void ConfermaModificaBambini_Click_1(object sender, EventArgs e)
        {

        }

        private void AiutoModificaBambini_Click(object sender, EventArgs e)
        {
            Maestre.Bambini.ModificaBambino modificaBambino= new Maestre.Bambini.ModificaBambino();
            modificaBambino.ShowDialog();
            Show();
        }
    }
}
