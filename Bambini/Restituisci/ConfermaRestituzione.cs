using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bambini.Restituiusci
{
    public partial class ConfermaRestituzione : Form
    {
        string nomedellibro = "";
        public ConfermaRestituzione(string NomeLibro)
        {
            nomedellibro = NomeLibro;
            InitializeComponent();
        }

        Cursor CursorOFF = new Cursor(Properties.Resources.Cursore1);
        Cursor CursorON = new Cursor(Properties.Resources.Cursore2);

        private void Ok_button_Click(object sender, EventArgs e)
        {
            GUIServices.ToPrendiRestituisci = true;
            Close();
        }

        private void Ok_button_MouseUp(object sender, MouseEventArgs e)
        {
            ok_button.Cursor = CursorOFF;
        }

        private void Ok_button_MouseDown(object sender, MouseEventArgs e)
        {
            ok_button.Cursor = CursorON;
        }

        private void ConfermaRestituzione_Load(object sender, EventArgs e)
        {
            ok_button.Cursor = CursorOFF;
            nomelibro_label.Text = nomedellibro;
            data_label.Text = DateTime.Now.ToShortDateString();
        }
    }
}
