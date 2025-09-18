using oops.inimene;
using oops.loom;

namespace oops;

internal class Program
{
    static void Main(string[] args)
    {
        var inimene = new Inimene();
        inimene.Nimi = "Juku";
        inimene.Vanus = 21;
        inimene.Tervita();

        var inimene2 = new Inimene("Mari", 25);
        inimene2.Tervita();

        var tootaja = new Tootaja();
        tootaja.Nimi = "Kati";
        tootaja.Vanus = 30;
        tootaja.Ametikoht = "Arendaja";
        tootaja.Tervita();
        tootaja.Tootan();

        var tootaja2 = new Tootaja("Peeter", 35, "Juhataja");
        tootaja2.Tervita();
        tootaja2.Tootan();

        var loom = new Loom();
        loom.Nimi = "Loom";
        loom.Liik = "";
        loom.TeeHaal();

        var koer = new Koer();
        koer.Nimi = "Kutsikas";
        koer.Liik = "Koer";
        koer.TeeHaal();

        var kass = new Kass();
        kass.Nimi = "Mõmmik";
        kass.Liik = "Kass";
        kass.TeeHaal();
    }
}