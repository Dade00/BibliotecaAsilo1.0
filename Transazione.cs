using System;

public class Transazione
{
    public int ID { get; set; }
    public int ID_Bambino { get; set; }
    public int ID_Libro { get; set; }
    public DateTime DataPrestito { get; set; }
    public DateTime DataPrevista { get; set; }
    public DateTime DataRestituzione { get; set; }

    public Transazione() { }
    public Transazione(int ID)
    {
        this.ID = ID;
    }
}
