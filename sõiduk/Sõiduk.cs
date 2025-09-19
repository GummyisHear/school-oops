using oops.utils;

namespace oops.sõiduk;

internal class Sõiduk
{
    public static void Run()
    {
        Console.WriteLine($">>>>>>> Sõidukite programm <<<<<<<");

        var soidukid = new List<ISoiduk>();

        var file = Utils.LoeFail("../../../sõiduk/sõidukid.txt");
        foreach (var line in file)
        {
            var split = line.Split(',').Select(i => i.Trim()).ToList();
            if (split.Count == 0)
                continue;

            try
            {
                var soiduk = split[0];
                switch (soiduk)
                {
                    case "Jalgratas":
                        soidukid.Add(new Jalgratas(double.Parse(split[1])));
                        break;
                    case "Buss":
                        soidukid.Add(new Buss(double.Parse(split[1]), double.Parse(split[2]), int.Parse(split[3])));
                        break;
                    case "Auto":

                        soidukid.Add(new Auto(double.Parse(split[1]), double.Parse(split[2])));
                        break;
                }
            }
            catch 
            {
                Console.WriteLine($"VIGA faili loemisel, real >>> {line} <<<");
            }
        }

        if (soidukid.Count > 0)
        {
            Console.WriteLine($"{soidukid.Count} sõidukid loetud failist.");
        }

        while (true)
        {
            Console.WriteLine("Vali sõiduki tüüp: 1 - auto, 2 - jalgratas, 3 - buss, 0 - lõpeta");
            var input = Console.ReadLine().ToLower();

            if (input == "0")
                break;

            switch (input)
            {
                case "1":
                    var autoKulu = Utils.AskDouble("Sisesta kütusekulu (liitrites): ", 0);
                    var autoVahemaa = Utils.AskDouble("Sisesta teepikkus (kilomeetrites): ", 0);
                    soidukid.Add(new Auto(autoKulu, autoVahemaa));
                    break;
                case "2":
                    var jalgrattaVahemaa = Utils.AskDouble("Sisesta teepikkus (kilomeetrites): ");
                    soidukid.Add(new Jalgratas(jalgrattaVahemaa));
                    break;
                case "3":
                    var bussKulu = Utils.AskDouble("Sisesta kütusekulu (liitrites): ");
                    var bussVahemaa = Utils.AskDouble("Sisesta teepikkus (kilomeetrites): ");
                    var reisijateArv = Utils.AskInt("Sisesta reisijate arv: ");
                    soidukid.Add(new Buss(bussKulu, bussVahemaa, reisijateArv));
                    break;

                default:
                    Console.WriteLine("Tundmatu valik.");
                    break;
            }
        }

        Console.WriteLine("\nSõidukite andmed:");
        foreach (var soiduk in soidukid)
        {
            Console.WriteLine($"{soiduk.ToString()} \n");
        }

        var koguKulu = soidukid.Sum(i => i.ArvutaKulu());
        Console.WriteLine($"Kõikide sõidukite kulu kokku on: {koguKulu} L");

        var writeLines = "";
        foreach (var soiduk in soidukid)
        {
            writeLines += soiduk.Export() + "\n";
        }

        Utils.KirjutaFail("../../../sõiduk/sõidukid.txt", writeLines);
    }
}
