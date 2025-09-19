namespace oops.utils;

public static class Utils
{
    public static string ToCommaSepString<T>(this IEnumerable<T> list, string delim = ", ") => string.Join(delim, list);

    public static string Ask(string question)
    {
        Console.Write(question);
        return Console.ReadLine() ?? "";
    }

    public static int AskInt(string question, int length = -1, int min = -1, int max = -1)
    {
        while (true)
        {
            Console.Write(question);
            var input = Console.ReadLine() ?? "";
            if (!int.TryParse(input, out var value))
            {
                Console.WriteLine("Sisesta ainult täisarved!");
                continue;
            }

            if (length != -1 && input.Length != length)
            {
                Console.WriteLine($"Sisesta täisarv, mis on {length} numbrit pikk!");
                continue;
            }

            if (min != -1 && value < min)
            {
                Console.WriteLine($"Sisesta täisarv, mis on vähemalt {min}!");
                continue;
            }

            return value;
        }
    }

    public static double AskDouble(string question, double min = -1, double max = -1)
    {
        while (true)
        {
            Console.Write(question);
            var input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out var value))
            {
                Console.WriteLine("Sisesta ainult arvud!");
                continue;
            }
            if (min != -1 && value < min)
            {
                Console.WriteLine($"Sisesta arv, mis on vähemalt {min}!");
                continue;
            }
            return value;
        }
    }

    public static List<string> LoeFail(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine($"Faili '{path}' ei leitud");
            return [];
        }

        var lines = File.ReadAllLines(path).ToList();
        return lines;
    }

    public static void KirjutaFail(string path, string content)
    {
        File.WriteAllText(path, content);
        Console.WriteLine($"Faili '{path}' on kirjutatud sisu '{content}'");
    }
}
