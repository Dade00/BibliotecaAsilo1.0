﻿using Classi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Maestre.Bambini
{
    public partial class CancellaBambino : Form
    {

        Bambino bambino = new Bambino();
        List<Bambino> listaBambini = new List<Bambino>();
        bool updateGUI = false;
        public CancellaBambino()
        {
            InitializeComponent();
        }

        private void AnnullaEliminaBambini_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfermaEliminaBambini_Click(object sender, EventArgs e)
        {
            Bambino bambino = new Bambino();
            bambino = (Bambino)bsBambini[bsBambini.Position];
            updateGUI = Queries.delBambino(bambino.ID);
            if (updateGUI)
            {
                try
                {
                    Bambini_pic.ImageLocation = "";
                    Bambini_pic.Refresh();
                    File.Delete(bambino.Path);
                }
                catch (Exception ex)
                { }
                MessageBox.Show("Bambino eliminato");
            }
        }

        private void CancellaBambino_Load(object sender, EventArgs e)
        {
            TabellaBambini.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            TabellaBambini.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);
            try
            {
                Queries.getBambini(ref listaBambini);
                refresh();
            }
            catch (Exception ex)
            {
                throw;
            }
            TabellaBambini.Rows[0].Cells[0].Selected = false;
        }

        private void refresh()
        {
            bsBambini.DataSource = listaBambini;
            bsBambini.ResetBindings(true);
        }

        private void AiutoCancellaBambino_Click(object sender, EventArgs e)
        {
            AiutoDelBambino cancellaBambino = new AiutoDelBambino();
            cancellaBambino.ShowDialog();
            Show();
        }

        private void Cerca_button_Click(object sender, EventArgs e)
        {
            if (NomeDelBambini.Text == "" && CognomeDelBambini.Text == "")
            {
                try
                {
                    listaBambini.Clear();
                    Queries.getBambini(ref listaBambini);
                    refresh();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            else  //
            {
                try
                {
                    listaBambini.Clear();
                    listaBambini = Queries.getBambino(NomeDelBambini.Text, CognomeDelBambini.Text);
                    refresh();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        private void UpdateDATA_Tick(object sender, EventArgs e)
        {
            if (updateGUI)
            {
                updateGUI = false;

                try
                {
                    Queries.getBambini(ref listaBambini);
                    refresh();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void TabellaBambini_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Bambino bambino = new Bambino();
                bambino = (Bambino)bsBambini[bsBambini.Position];
                Bambini_pic.ImageLocation = bambino.Path;
            }
            catch
            {
                Bambini_pic.Image = Maestre.Properties.Resources.No_image;
            }
        }
    }
}
