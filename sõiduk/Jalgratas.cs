namespace oops.sõiduk;

internal class Jalgratas : ISoiduk
{
    public double Km;

    public Jalgratas(double km)
    {
        Km = km;
    }

    public double ArvutaKulu()
    {
        return 0;
    }

    public double ArvutaVahemaa()
    {
        return Km;
    }

    public string Export()
    {
        return $"Jalgratas, {Km}";
    }

    public override string ToString()
    {
        return $"Jalgratas Km: {Km}";
    }
}
