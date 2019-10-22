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
        public ConfermaPresa()
        {
            InitializeComponent();
        }

        Cursor CursorON = new Cursor(Application.StartupPath + @"\MickyMouseOFF.cur");

        private void ConfermaPresa_Load(object sender, EventArgs e)
        {

            ok_button.Cursor = CursorON;
        }

        private void Ok_button_Click_1(object sender, EventArgs e)
        {
            GUIServices.ToPrendiRestituisci = true;
            Close();
        }
    }
}
