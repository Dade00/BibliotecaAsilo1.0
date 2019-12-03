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

namespace Maestre.Statistiche_WIP_
{
    public partial class BambiniLettoUnLibro : Form
    {
        List<Libro> libros = new List<Libro>();
        public BambiniLettoUnLibro()
        {
            InitializeComponent();
        }

        private void RicercaStatLibro_Click(object sender, EventArgs e)
        {
            try
            {
                libros = Queries.getLibri(titolotb.Text, autore_tb.Text, generetb.Text);
                refresh();
            }
            catch
            {
                throw;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                libros = Queries.getLibri();
                refresh();
                titolotb.Text = "";
                autore_tb.Text = "";
            }
            catch
            {
                throw;
            }
        }

        private void LibroTabella_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Hide();
            Statistiche_WIP_.NumeroDiVolteLetti numeroDiVolteLetti = new Statistiche_WIP_.NumeroDiVolteLetti((Libro)bsLibri[bsLibri.Position]);
            numeroDiVolteLetti.ShowDialog();
            Show();
        }

        private void BambiniLettoUnLibro_Load(object sender, EventArgs e)
        {
            LibroTabella.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            LibroTabella.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);
            try
            {
                libros = Queries.getLibri();
                refresh();
                generetb.DataSource = Queries.getGenere();
            }
            catch
            {
                throw;
            }
            LibroTabella.Rows[0].Cells[0].Selected = false;
        }

        private void refresh()
        {
            bsLibri.DataSource = libros;
            bsLibri.ResetBindings(true);
        }

        private void LibroTabella_SelectionChanged(object sender, EventArgs e)
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
