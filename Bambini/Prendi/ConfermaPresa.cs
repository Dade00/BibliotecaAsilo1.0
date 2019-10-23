using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bambini.Prendi
{
    public partial class ConfermaPresa : Form
    {

        Cursor CursorOFF = new Cursor(Properties.Resources.Cursore1);
        Cursor CursorON = new Cursor(Properties.Resources.Cursore2);

        public ConfermaPresa()
        {
            InitializeComponent();
        }


        private void ConfermaPresa_Load(object sender, EventArgs e)
        {

            ok_button.Cursor = CursorOFF;
        }

        private void Ok_button_Click_1(object sender, EventArgs e)
        {
            GUIServices.ToPrendiRestituisci = true;
            Close();
        }
    }
}
