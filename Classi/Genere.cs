namespace Classi
{
    public class Genere
    {
        public int ID { get; set; }
        public string NomeGenere { get; set; }
        public string Colore { get; set; }

        public Genere() { }
        public Genere(int ID)
        {
            this.ID = ID;
        }
    }
}
