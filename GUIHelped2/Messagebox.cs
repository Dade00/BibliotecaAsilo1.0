using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIHelped2
{
    public partial class Messagebox : Form
    {
        bool ok;
        public Messagebox()
        {
            InitializeComponent();
        }
        public Messagebox(string Text, string Title, bool OK)
        {
            InitializeComponent();
            testo.Text = Text;
            Titolo.Text = Title;
            ok = OK;
        }

        private void Messagebox_Load(object sender, EventArgs e)
        {
            if(ok)
            {
                BackgroundImage = GUIHelped2.Properties.Resources.Sfondo_Msg_Bello;
               //BackgroundImage = 
            }
            else
            {
                //this.BackgroundImage = Properties.Resources.Sfondo_Msg_Brutto;
                BackgroundImage = GUIHelped2.Properties.Resources.Sfondo_Msg_Brutto;
            }
        }

        private void Testo_Click(object sender, EventArgs e)
        {

        }
    }
}
