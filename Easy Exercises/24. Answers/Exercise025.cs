using System;

namespace Easy_Exercises
{

public class Exercise025
{
    public static void Main()
    {
        DateTime august14 = new DateTime(2009, 8, 14, 5, 23, 15);

        // Get the long date formats using the current culture.
        string[] longaugust14Formats =
            august14.GetDateTimeFormats('D');

        // Display all long date formats.
        foreach (string format in longaugust14Formats)
        {
            Console.WriteLine(format);
        }
    }
    }
}
