using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestre.Bambini
{
    public partial class CancellaBambino : Form
    {
        public CancellaBambino()
        {
            InitializeComponent();
        }

        private void Libro_label_Click(object sender, EventArgs e)
        {

        }

        private void AnnullaEliminaBambini_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
