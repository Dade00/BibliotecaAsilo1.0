using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Xml;

namespace Classi
{
    class XMLGesture
    {
        private XmlTextReader reader()
        {
            XmlTextReader reader = new XmlTextReader(@"C:\BibliotecaAsilo\SQL\Credenziali.xml");
        }

        public string ServerAddress()
        {
            string server = "";
            return server;
        }

        public string initialCatalog()
        {
            string iCat = "";
            return iCat;
        }

        public string user ()
        {
            string user = "";
            return user;
        }

        public string pw()
        {
            string pw = "";
            return pw;
        }


    }
}
