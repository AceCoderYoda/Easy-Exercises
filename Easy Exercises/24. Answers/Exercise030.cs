using System;

namespace Easy_Exercises
{

public class Exercise030
{
    public static void Main()
    {
        //establish DateTimes
        DateTime start = new DateTime(2010, 6, 14);
        DateTime end = new DateTime(2016, 08, 14);

        TimeSpan difference = end - start; //create TimeSpan object

        Console.WriteLine("Difference in days: " + difference.Days); //Extract days, write to Console.
    }
    }
}
