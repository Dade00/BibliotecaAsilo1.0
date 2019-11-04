namespace Classi
{
    public class Libro
    {
        public int ID { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public string Genere { get; set; }
        public string Path { get; set; }
        public bool Prestito { get; set; }

        public Libro() { }
        public Libro(int ID)
        {
            this.ID = ID;
        }

        public Libro(string Titolo, string Autore, string Genere, bool Prestito)
        {
            this.Titolo = Titolo;
            this.Autore = Autore;
            this.Genere = Genere;
            this.Prestito = Prestito;
        }
    }
}