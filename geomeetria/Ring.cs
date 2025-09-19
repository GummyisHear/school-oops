using oops.geomeetria;

public class Ring : IKujund
{
    public double Raadius { get; set; }

    public Ring(double raadius)
    {
        Raadius = raadius;
    }

    public double ArvutaPindala() => Math.PI * Raadius * Raadius;
    public double ArvutaÜmbermõõt() => 2 * Math.PI * Raadius;
}