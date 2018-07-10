using System;
using System.Globalization;

namespace Easy_Exercises
{

public class Exercise037
{
    public static void Main()
    {
        CultureInfo[] cultures = new CultureInfo[] {CultureInfo.InvariantCulture,
            new CultureInfo("en-ZA"),
            new CultureInfo("ko-KR"),
            new CultureInfo("de-DE"),
            new CultureInfo("es-ES"),
            new CultureInfo("en-US")};

        DateTime thisDate = new DateTime(2016, 5, 17, 9, 0, 0);

        foreach (CultureInfo culture in cultures)
        {
            string cultureName;
            if (string.IsNullOrEmpty(culture.Name))
                cultureName = culture.NativeName;
            else
                cultureName = culture.Name;

            Console.WriteLine("In {0}, {1}",
                cultureName, thisDate.ToString(culture));
        }
    }
    }
}
