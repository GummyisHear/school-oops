namespace oops.sõiduk;

internal class Buss : ISoiduk
{
    public double Kütusekulu;
    public double Km;
    public int Reisijad;

    public Buss(double kütusekulu, double km, int reisijad)
    {
        Kütusekulu = kütusekulu;
        Km = km;
        Reisijad = reisijad;
    }

    public double ArvutaKulu()
    {
        return Kütusekulu;
    }

    public double ArvutaVahemaa()
    {
        return Km;
    }

    public string Export()
    {
        return $"Buss, {Kütusekulu}, {Km}, {Reisijad}";
    }

    public override string ToString()
    {
        return $"Buss Kütusekulu: {Kütusekulu} Km: {Km} Reisijad: {Reisijad}";
    }
}
