namespace oops.inimene;

public class Tootaja : Inimene
{
    public string Ametikoht;

    public Tootaja() { }

    public Tootaja(string nimi, int vanus, string ametikoht)
        : base(nimi, vanus)
    {
        Ametikoht = ametikoht;
    }

    public void Tootan()
    {
        Console.WriteLine($"Töötan ametikohal {Ametikoht}.");
    }
}
