using oops.inimene;
using oops.loom;

namespace oops;

internal class Program
{
    static void Main(string[] args)
    {
        //var inimene = new Inimene();
        //inimene.Nimi = "Juku";
        //inimene.Vanus = 21;
        //inimene.Tervita();

        //var inimene2 = new Inimene("Mari", 25);
        //inimene2.Tervita();

        var tootaja = new Tootaja();
        tootaja.Nimi = "Kati";
        tootaja.Vanus = 30;
        tootaja.Ametikoht = "Arendaja";
        tootaja.Tervita();

        tootaja.Tunnid = 160;
        var palk = tootaja.ArvutaPalk();

        Console.WriteLine($"Algne konto on {tootaja.Konto.Saldo} eurot.");
        tootaja.Konto.Saldo += 1000;
        Console.WriteLine($"Pärast palka on kontol {tootaja.Konto.Saldo} eurot.");
        tootaja.Konto.VõtaRaha(200);
        tootaja.Konto.LisaRaha(500);

        //var tootaja2 = new Tootaja("Peeter", 35, "Juhataja");
        //tootaja2.Tervita();

        //var koer = new Koer();
        //koer.Nimi = "Kutsikas";
        //koer.Liik = "Koer";
        //koer.TeeHaal();

        //var kass = new Kass();
        //kass.Nimi = "Mõmmik";
        //kass.Liik = "Kass";
        //kass.TeeHaal();
        //kass.Eat();
        //kass.Move();
    }
}