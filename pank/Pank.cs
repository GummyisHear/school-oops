namespace oops.pank;

public interface ITööline
{
    double ArvutaPalk();
}

public class Pank
{
    private double _saldo;

    public double Saldo
    {
        get => _saldo;        
        set 
        {
            if (value >= 0)
                _saldo = value; 
        }
    }

    public void LisaRaha(double summa)
    {
        Console.WriteLine($"Lisame kontole {summa} eurot.");

        if (summa > 0)
            Saldo += summa;

        Console.WriteLine($"Teie kontol on {Saldo} eurot.");
    }

    public bool VõtaRaha(double summa)
    {
        Console.WriteLine($"Võtame kontolt {summa} eurot.");

        if (summa > 0 && summa <= Saldo)
        {
            Saldo -= summa;
            Console.WriteLine($"Teie kontol on {Saldo} eurot.");
            return true;
        }

        Console.WriteLine($"Teie kontol pole piisavalt raha. Kontol on {Saldo} eurot.");
        return false;
    }
}
