using System;
using System.Globalization;

namespace Easy_Exercises
{

public class Exercise038
{
    public static void Main()
    {
        String[] formats = { "G", "MM/yyyy", @"MM\/dd\/yyyy HH:mm",
            "yyyyMMdd" };
        String[] cultureNames = { "en-CA", "sv-FI" };
        DateTime date = new DateTime(2016, 5, 17, 13, 31, 17);
        foreach (var cultureName in cultureNames)
        {
            var culture = new CultureInfo(cultureName);

            Console.WriteLine(culture.NativeName);
            foreach (var format in formats)
                Console.WriteLine("   {0}: {1}", format,
                    date.ToString(format));
            Console.WriteLine();
        }
    }
    }
}
