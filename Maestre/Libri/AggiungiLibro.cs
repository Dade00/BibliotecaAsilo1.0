using Classi;
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
    public partial class AggiungiLibro : Form
    {
        public AggiungiLibro()
        {
            InitializeComponent();
        }

        List<Libro> listaLibri = new List<Libro>();

        private void AnnullaModificaLibro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfermaModificaLibro_Click(object sender, EventArgs e)
        {
            Maestre.Libri.AggiungiLibro aggiungiLibro = new Maestre.Libri.AggiungiLibro();
            aggiungiLibro.ShowDialog();
            Show();
        }

        private void AggiungiLibro_Load(object sender, EventArgs e)
        {
            try
            {
                listaLibri = Queries.getLibri();
                refresh();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void refresh()
        {
            bsLibri.DataSource = listaLibri;
            bsLibri.ResetBindings(true);
        }
    }
}
