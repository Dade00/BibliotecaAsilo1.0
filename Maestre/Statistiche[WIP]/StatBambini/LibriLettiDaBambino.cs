using Classi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Maestre.Statistiche_WIP_
{
    public partial class LibriLettiDaBambino : Form
    {
        List<Bambino> bambinos = new List<Bambino>();
        public LibriLettiDaBambino()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void LibriLettiDaBambino_Load(object sender, EventArgs e)
        {
            TabellaBambini.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            TabellaBambini.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);
            try
            {
                Queries.getBambini(ref bambinos);
                refresh();
            }
            catch (Exception ex)
            {
                throw;
            }
            TabellaBambini.Rows[0].Cells[0].Selected = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Indietro_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RicercaStatBambini_Click(object sender, EventArgs e)
        {
            if (NomeBambino.Text != "" || CognomeBambino.Text != "")
                try
                {
                    bambinos = Queries.getBambino(NomeBambino.Text, CognomeBambino.Text);
                    refresh();
                }
                catch
                {
                    throw;
                }
            else
                try
                {
                    Queries.getBambini(ref bambinos);
                    refresh();
                }
                catch (Exception ex)
                {
                    throw;
                }

        }

        private void refresh()
        {
            bsLibri.DataSource = bambinos;
            bsLibri.ResetBindings(true);
        }

        private void TabellaBambini_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Hide();
            Statistiche_WIP_.LibriLetti libriLetti = new Statistiche_WIP_.LibriLetti((Bambino)bsLibri[bsLibri.Position]);
            libriLetti.ShowDialog();
            Show();
        }

        private void TabellaBambini_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Libro libro = new Libro();
                libro = (Libro)bsLibri[bsLibri.Position];
            }
            catch
            { }
        }
    }
}
