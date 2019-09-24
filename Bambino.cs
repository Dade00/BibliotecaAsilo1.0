using System;

public class Bambino
{
    public int ID { get; set; }
    public int Anni { get; set; }
    public string Cogome { get; set; }
    public string Nome { get; set; }
    public string Path { get; set; }
    
    public Bambino(){}

    public Bambino(int ID)
    {
        this.ID = ID;
    }
}
