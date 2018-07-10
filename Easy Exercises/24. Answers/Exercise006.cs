using System;
using System.Globalization;

namespace Easy_Exercises
{

public class Exercise006
{
    public static void Main()
    {
        DateTime localDate = DateTime.Now;
        DateTime utcDate = DateTime.UtcNow;
        String[] cultureNames = { "en-JM", "en-NZ", "fr-BE",
            "de-CH", "nl-NL" };

        foreach (var cultureName in cultureNames)
        {
            var culture = new CultureInfo(cultureName);
            Console.WriteLine("{0}:", culture.NativeName);
            Console.WriteLine("   Local date and time: {0}, {1:G}",
                localDate.ToString(culture), localDate.Kind);
            Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                utcDate.ToString(culture), utcDate.Kind);
        }
    }
    }
}
