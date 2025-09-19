namespace oops.loom;

public class Koer : Loom
{
    public override void Eat()
    {
        Console.WriteLine("Koer sööb liha.");
    }

    public override void Move()
    {
        Console.WriteLine("Koer jookseb kiiresti.");
    }

    public override void TeeHaal()
    {
        Console.WriteLine($"{Nimi}: Auh auh!");
    }
}
