namespace oops.loom;

public class Lehm : Loom
{
    public override void Eat()
    {
        Console.WriteLine("Lehm sööb rohtu.");
    }

    public override void Move()
    {
        Console.WriteLine("Lehm liigub väga aeglaselt.");
    }

    public override void TeeHaal()
    {
        Console.WriteLine($"{Nimi}: Muu, muu!");
    }
}
