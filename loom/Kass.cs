namespace oops.loom;

public class Kass : Loom
{
    public override void Eat()
    {
        Console.WriteLine("Kass sööb kala.");
    }

    public override void Move()
    {
        Console.WriteLine("Kass liigub vaikselt.");
    }

    public override void TeeHaal()
    {
        Console.WriteLine($"{Nimi}: Mjäu mjäu!");
    }
}
