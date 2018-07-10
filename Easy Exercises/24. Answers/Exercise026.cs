using System;

namespace Easy_Exercises
{

public class Exercise026
{
    public static void Main(String[] argv)
    {
        DateTime may12 = new DateTime(2016, 5, 12, 5, 23, 15, 16);

        IFormatProvider culture =
            new System.Globalization.CultureInfo("ja-JP", true);
        // Get the short date formats using the "ja-JP" culture.
        string[] frenchmay12Formats =
            may12.GetDateTimeFormats(culture);

        // Display may12 in various formats using "ja-JP" culture.
        foreach (string format in frenchmay12Formats)
        {
            Console.WriteLine(format);
        }
    }
    }
}
