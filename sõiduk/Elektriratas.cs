namespace oops.sõiduk;

internal class Elektriratas : ISoiduk
{
    public double Kütusekulu;
    public double Km;

    public Elektriratas(double kutusekulu, double km)
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
        return $"Elektriratas, {Kütusekulu}, {Km}";
    }
}
