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
    public partial class NumeroDiVolteLetti : Form
    {
        Libro Libro = new Libro();
        List<Bambino> bambinos = new List<Bambino>();
        public NumeroDiVolteLetti(Libro libro)
        {
            Libro = libro;
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Indietro_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NumeroDiVolteLetti_Load(object sender, EventArgs e)
        {
            BambiniLettoIlLibro.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            BambiniLettoIlLibro.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);
            TitoloLibroScelto.Text = Libro.Titolo;
            AutoreLibroScelto.Text = Libro.Autore;
            GenerelibroScelto.Text = Libro.Genere;
            Libro_pic.ImageLocation = Libro.Path;

            try
            {
                bambinos = Queries.getBambinichehannolettoillibro(Libro.ID);
                refresh();

                NLibroletto.Text = Queries.nVolteLibroLetto(Libro.ID).ToString();
            }
            catch
            {
                throw;
            }
        }

        private void refresh()
        {
            bsLibri.DataSource = bambinos;
            bsLibri.ResetBindings(true);
        }
    }
}
