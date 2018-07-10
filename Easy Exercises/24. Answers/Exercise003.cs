using System;

namespace Easy_Exercises
{

public class Exercise003
{
    public static void Main()
    {
        // Assume the current system  is en-US.
        DateTime dt = new DateTime(2016, 7, 11);
        Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
    }
    }
}
