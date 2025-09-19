namespace oops.sõiduk;

internal class Auto : ISoiduk
{
    public double Kütusekulu;
    public double Km;

    public Auto(double kutusekulu, double km)
    {
        Kütusekulu = kutusekulu;
        Km = km;
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
        return $"Auto, {Kütusekulu}, {Km}";
    }

    public override string ToString()
    {
        return $"Auto Kütusekulu: {Kütusekulu} Km: {Km}";
    }
}
