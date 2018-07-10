using System;
using System.Globalization;

namespace Easy_Exercises
{

public class Exercise039
{
    public static void Main()
    {
        // Create an array of all supported standard date and time format specifiers.
        string[] formats = {"d", "D", "f", "F", "g", "G", "m", "o", "r",
            "s", "t", "T", "u", "U", "Y"};
        // Create an array of four cultures.                                 
        CultureInfo[] cultures = {CultureInfo.CreateSpecificCulture("zh-HK"),
            CultureInfo.CreateSpecificCulture("en-US"),
            CultureInfo.CreateSpecificCulture("es-GB"),
            CultureInfo.CreateSpecificCulture("fr-CA")};
        // Define date to be displayed.
        DateTime dateToDisplay = new DateTime(2015, 10, 16, 17, 4, 32);

        // Iterate each standard format specifier.
        foreach (string formatSpecifier in formats)
        {
            foreach (CultureInfo culture in cultures)
                Console.WriteLine("{0} Format Specifier {1, 10} Culture {2, 40}",
                    formatSpecifier, culture.Name,
                    dateToDisplay.ToString(formatSpecifier, culture));
            Console.WriteLine();
        }
    }
    }
}
