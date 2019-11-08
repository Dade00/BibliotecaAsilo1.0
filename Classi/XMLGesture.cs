using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Xml;

namespace Classi
{
    class XMLGesture
    {
        private XmlTextReader inizializeReaderXML()
        {
            XmlTextReader reader = new XmlTextReader(@"C:\BibliotecaAsilo\SQL\Credenziali.xml");
            return reader;
        }

        public string ServerAddress()
        {
            string server = "";
            XmlTextReader reader = inizializeReaderXML();
            int i = 0;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text && i==0)
                {
                    server = reader.Value;
                    i++;
                }
                else if (reader.NodeType == XmlNodeType.Text)
                    i++;
            }
            inizializeReaderXML().Close();
            return server;
        }

        public string initialCatalog()
        {
            string iCat = "";
            XmlTextReader reader = inizializeReaderXML();
            int i = 0;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text && i == 1)
                {
                    iCat = reader.Value;
                    i++;
                }
                else if (reader.NodeType == XmlNodeType.Text)
                    i++;
            }
            inizializeReaderXML().Close();
            return iCat;
        }

        public string user ()
        {
            string user = "";
            XmlTextReader reader = inizializeReaderXML();
            int i = 0;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text && i == 2)
                {
                    user = reader.Value;
                    i++;
                }
                else if (reader.NodeType == XmlNodeType.Text)
                    i++;
            }
            inizializeReaderXML().Close();
            return user;
        }

        public string pw()
        {
            string pw = "";
            XmlTextReader reader = inizializeReaderXML();
            int i = 0;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text && i == 3)
                {
                    pw = reader.Value;
                    i++;
                }
                else if (reader.NodeType == XmlNodeType.Text)
                    i++;
            }
            inizializeReaderXML().Close();
            return pw;
        }


    }
}
