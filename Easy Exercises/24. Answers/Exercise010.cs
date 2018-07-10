using System;

namespace Easy_Exercises
{

public class Exercise010
{
    public static void Main()
    {

        // Calculate what day of the week is 40 days from this instant.
        DateTime today = DateTime.Now;
        DateTime answer = today.AddDays(40);
        Console.WriteLine("Today: {0:dddd}", today);
        Console.WriteLine("40 days from today: {0:dddd}", answer);
    }
    }
}
