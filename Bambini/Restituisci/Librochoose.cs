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

namespace Bambini.Restituiusci
{
    public partial class Librochoose : Form
    {
        Bambino bambinoresituente = new Bambino();

        public Librochoose(Bambino bambinologgato)
        {
            bambinoresituente = bambinologgato;
            InitializeComponent();
        }

        Cursor CursorOFF = new Cursor(Properties.Resources.Cursore1);
        Cursor CursorON = new Cursor(Properties.Resources.Cursore2);

        private void Ok_button_Click(object sender, EventArgs e)
        {
            Hide();
            ConfermaRestituzione confermaRestituzione = new ConfermaRestituzione();
            confermaRestituzione.ShowDialog();
            Show();
        }

        private void Indietro_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Librochoose_VisibleChanged(object sender, EventArgs e)
        {
            if (GUIServices.ToPrendiRestituisci)
            {
                Close();
            }
        }

        private void Librochoose_Load(object sender, EventArgs e)
        {
            up_button.Cursor = CursorOFF;
            down_button.Cursor = CursorOFF;
            avanti_button.Cursor = CursorOFF;
            indietro_button.Cursor = CursorOFF;

            //Modifica font datagrid
            ElencoLibri.DefaultCellStyle.Font = new Font("GROBOLD", 15);
            ElencoLibri.ColumnHeadersDefaultCellStyle.Font = new Font("GROBOLD", 13);

            //Controllo se questo bambino ha una transazione senza data di restituzione, se ne ha almeno una vado a prendere il libro collegato altrimenti Popup non hai libri da restituire e close()

        }


        private void Up_button_MouseUp(object sender, MouseEventArgs e)
        {
            up_button.Cursor = CursorOFF;
        }

        private void Up_button_MouseDown(object sender, MouseEventArgs e)
        {
            up_button.Cursor = CursorON;
        }

        private void Down_button_MouseUp(object sender, MouseEventArgs e)
        {
            down_button.Cursor = CursorOFF;
        }

        private void Down_button_MouseDown(object sender, MouseEventArgs e)
        {
            down_button.Cursor = CursorON;
        }

        private void Indietro_button_MouseDown(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorON;
        }

        private void Indietro_button_MouseUp(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorOFF;
        }

        private void Avanti_button_MouseUp(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorOFF;
        }

        private void Avanti_button_MouseDown(object sender, MouseEventArgs e)
        {
            indietro_button.Cursor = CursorON;
        }
    }
}
