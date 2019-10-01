using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classi;

namespace Maestre.Bambini
{
    public partial class AggiungiBambino : Form
    {
        public List<Bambino> listaBambini { get; set; }


        public AggiungiBambino()
        {
            InitializeComponent();
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
                ofdFoto.FileName = "";
        }

        private void ConfermaModificaBambini_Click(object sender, EventArgs e)
        {
            if (NomeAddBambini.Text != "" || NomeAddBambini.Text != null)
            {
                if (CognomeAddBambini.Text != "" || CognomeAddBambini.Text != null)
                {
                    if (ClasseAddBambini.Text != "" || ClasseAddBambini.Text != null)
                    {
                        if (DateTime.Now.Subtract(nascitaAddBambini.Value) < new TimeSpan(365, 0, 0, 0, 0))
                        {
                            if (ofdFoto.FileName != "" || ofdFoto.FileName != null)
                            {
                                
                            }
                            else
                                MessageBox.Show("Selezionare prima la foto");
                        }
                        else
                            MessageBox.Show("Inserire prima la data di nascita del bambino");
                    }
                    else
                        MessageBox.Show("Inserire prima la classe del bambino");
                }
                else
                    MessageBox.Show("Inserire prima il cognome del bambino");
            }
            else
                MessageBox.Show("Inserire prima il nome del bambino");
        }

        private void RefreshDgv()
        {
            bsBambini.DataSource = listaBambini;
            bsBambini.ResetBindings(true);
        }
    }
}
