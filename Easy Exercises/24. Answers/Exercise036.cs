using System;
using System.Globalization;
using System.Threading;

namespace Easy_Exercises
{

public class Exercise036
{
    public static void Main()
    {
        CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
        DateTime exampleDate = new DateTime(2016, 5, 16, 18, 32, 6);

        // Display the date using the current (en-US) culture.
        Console.WriteLine(exampleDate.ToString());

        // Change the current culture to fr-FR and display the date.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("fr-FR");
        Console.WriteLine(exampleDate.ToString());

        // Change the current culture to ja-JP and display the date.
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ja-JP");
        Console.WriteLine(exampleDate.ToString());

        // Restore the original culture
        Thread.CurrentThread.CurrentCulture = currentCulture;
    }
    }
}
