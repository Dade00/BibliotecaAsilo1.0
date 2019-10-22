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
                selectedId = (int)dataGridView1.SelectedCells[0].Value;
                int i = 0;
                while (listaBambini[i].ID != selectedId)
                    i++;
                NomeModBambini.Text = listaBambini[i].Nome;
                CognomeModBambini.Text = listaBambini[i].Cognome;
                ClasseModBambini.Text = listaBambini[i].Classe;
                nascitaModificaBambini.Value = listaBambini[i].DataNascita;
                ofdFoto.FileName = listaBambini[i].Path;
                pictureBox1.Image = new Bitmap(ofdFoto.FileName);
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
                    pictureBox1.Image = new Bitmap(ofdFoto.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                ofdFoto.FileName = "";
        }
    }
}
