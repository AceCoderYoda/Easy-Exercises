using System;

namespace Easy_Exercises
{

public class Exercise008
{
    public static void Main()
    {
        // Get the current date.
        DateTime thisDay = DateTime.Today;
        Console.WriteLine("General format " + thisDay.ToString());
        Console.WriteLine("Display the date in a variety of formats: ");
        Console.WriteLine(thisDay.ToString("d"));
        Console.WriteLine(thisDay.ToString("D"));
        Console.WriteLine(thisDay.ToString("g"));
    }
    }
}
