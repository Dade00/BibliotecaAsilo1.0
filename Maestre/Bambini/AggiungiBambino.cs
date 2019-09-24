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
    public partial class AggiungiBambino : Form
    {
        public AggiungiBambino()
        {
            InitializeComponent();
        }

        private void AnnullaModificaBambini_Click(object sender, EventArgs e)
        {
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
        }
    }
}
