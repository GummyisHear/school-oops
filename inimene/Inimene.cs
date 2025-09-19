using oops.pank;

namespace oops.inimene;

public abstract class Inimene
{
    public string Nimi;
    public int Vanus;
    public Pank Konto { get; set; }

    public Inimene() 
    {
        Konto = new Pank();
    }

    public Inimene(string nimi, int vanus)
    {
        Nimi = nimi;
        Vanus = vanus;
        Konto = new Pank();
    }

    public abstract void Tervita();
}
