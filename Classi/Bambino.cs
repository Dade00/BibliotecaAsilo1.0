using System;

namespace Classi
{
    public class Bambino
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string Classe { get; set; }
        public string Path { get; set; }

        public Bambino() { }
        public Bambino(int ID)
        {
            this.ID = ID;
        }
        public Bambino(string Nome, string Cognome)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
        }
        public Bambino(string Nome, string Cognome, DateTime DataNascita, string Classe, string Path)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.DataNascita = DataNascita;
            this.Classe = Classe;
            this.Path = Path;
        }
        public Bambino(int ID, string Nome, string Cognome, DateTime DataNascita, string Classe, string Path)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.DataNascita = DataNascita;
            this.Classe = Classe;
            this.Path = Path;
        }
    }
}