using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestre
{
    public partial class Messagebox : Form
    {
        bool ok;
        public Messagebox(string Text, string Title, bool OK)
        {
            testo.Text = Text;
            Titolo.Text = Title;
            ok = OK;
            InitializeComponent();
        }

        private void Messagebox_Load(object sender, EventArgs e)
        {
            if(ok)
            {
                this.BackgroundImage = Maestre.Properties.Resources.Sfondo_Msg_Bello;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Sfondo_Msg_Brutto;
            }
        }
    }
}
