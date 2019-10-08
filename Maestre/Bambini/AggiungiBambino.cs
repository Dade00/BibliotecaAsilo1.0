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

                Queries.addBambino(new Bambino(NomeAddBambini.Text, CognomeAddBambini.Text, nascitaAddBambini.Value, ClasseAddBambini.Text, ofdFoto.FileName));
                MessageBox.Show("Bambino aggiunto!");
                Close();
            }
            catch (Exception)
            {
                throw;
            }
        }    
        private void AggiungiBambino_Load(object sender, EventArgs e)
        {
            try
            {
                Queries.
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
