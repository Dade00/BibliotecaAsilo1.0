using Classi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Maestre.Statistiche_WIP_
{
    public partial class LibriLetti : Form
    {
        Bambino Bambino = new Bambino();
        public LibriLetti(Bambino bambino)
        {
            Bambino = bambino;
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LibriLetti_Load(object sender, EventArgs e)
        {
            List<Libro> libros = new List<Libro>();
            NomeStudScelto.Text = Bambino.Nome;
            CogomeStudScelto.Text = Bambino.Cognome;
            ClasseStudScelto.Text = Bambino.Classe;
            Bambini_pic.ImageLocation = Bambino.Path;
            TabellaBambini.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            TabellaBambini.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);
            try
            {
                List<Transazione> Transaziones = Queries.getTransazionibyBambino(Bambino.ID);
                for (int i = 0; i < Transaziones.Count; i++)
                {
                    libros.AddRange(Queries.getLibri(Transaziones[i].ID_Libro));
                }
                libros = libros.Distinct(new ItemEqualityComparer()).ToList();
                bsLibri.DataSource = libros;
                NLibriLabel.Text = libros.Count.ToString();
            }
            catch
            {
                throw;
            }
        }

        class ItemEqualityComparer : IEqualityComparer<Libro>
        {
            public bool Equals(Libro x, Libro y)
            {
                // Two items are equal if their keys are equal.
                return x.ID == y.ID;
            }

            public int GetHashCode(Libro obj)
            {
                return obj.ID.GetHashCode();
            }
        }
    }
}
