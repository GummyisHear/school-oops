using oops.geomeetria;

public class Kolmnurk : IKujund
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Kolmnurk(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double ArvutaÜmbermõõt() => A + B + C;

    public double ArvutaPindala()
    {
        double s = ArvutaÜmbermõõt() / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C)); // Heroni valem
    }
}