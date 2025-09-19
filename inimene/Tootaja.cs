using oops.pank;

namespace oops.inimene;

public class Tootaja : Inimene, ITööline
{
    public string Ametikoht;
    public double Tunnitasu = 15.50;
    public int Tunnid { get; set; }

    public Tootaja() { }

    public Tootaja(string nimi, int vanus, string ametikoht)
        : base(nimi, vanus)
    {
        Ametikoht = ametikoht;
    }

    public override void Tervita()
    {
        Console.WriteLine($"Töötan ametikohal {Ametikoht}.");
    }

    public double ArvutaPalk()
    {
        return Tunnitasu * Tunnid;
    }
}
