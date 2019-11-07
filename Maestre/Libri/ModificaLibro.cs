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
    public partial class ModificaLibro : Form
    {
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
            Maestre.Libri.ModificaLibro modificaLibro = new Maestre.Libri.ModificaLibro();
            modificaLibro.ShowDialog();
            Show();
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

        private void Libri_pic_Click(object sender, EventArgs e)
        {

        }

        private void ModificaLibro_Load(object sender, EventArgs e)
        {

        }

        private void CercaFotoLibro_Click(object sender, EventArgs e)
        {

        }
    }
}
