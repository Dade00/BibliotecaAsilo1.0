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
    public partial class EliminaLibro : Form
    {
        public EliminaLibro()
        {
            InitializeComponent();
        }

        private void Libro_label_Click(object sender, EventArgs e)
        {

        }

        private void Nome_label_Click(object sender, EventArgs e)
        {

        }

        private void AnnullaEliminaLibro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfermaEliminaLibro_Click(object sender, EventArgs e)
        {
            Maestre.Libri.EliminaLibro eliminaLibro = new Maestre.Libri.EliminaLibro();
            eliminaLibro.ShowDialog();
            Show();
        }

        private void AiutoAggiungiLibro_Click(object sender, EventArgs e)
        {
            AiutoDelLibri aiutoDelLibri = new AiutoDelLibri();
            aiutoDelLibri.ShowDialog();
            Show();
        }
    }
}
