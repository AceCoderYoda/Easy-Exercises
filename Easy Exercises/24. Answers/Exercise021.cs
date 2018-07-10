using System;
using System.Globalization;

namespace Easy_Exercises
{

public class Exercise021
{
    public static void Main()
    {
        string[] formats = {"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt",
            "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
            "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
            "M/d/yyyy h:mm", "M/d/yyyy h:mm",
            "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm"};
        string[] dateStrings = {"8/1/2016 6:32 PM", "08/01/2016 6:32:05 PM",
            "8/1/2016 6:32:00", "08/01/2016 06:32",
            "08/01/2016 06:32:00 PM", "08/01/2016 06:32:00"};
        DateTime dateValue;

        foreach (string dateString in dateStrings)
        {
            if (DateTime.TryParseExact(dateString, formats,
                new CultureInfo("zh-CN"),
                DateTimeStyles.None,
                out dateValue))
                Console.WriteLine("Converted '{0}' to {1}.", dateString, dateValue);
            else
                Console.WriteLine("Unable to convert '{0}' to a date.", dateString);
        }
    }
    }
}
