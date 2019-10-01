namespace Classi
{
    public class Libro
    {
        public int ID { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int ID_Genere { get; set; }
        public string Path { get; set; }

        public Libro() { }
        public Libro(int ID)
        {
            this.ID = ID;
        }
    }
}