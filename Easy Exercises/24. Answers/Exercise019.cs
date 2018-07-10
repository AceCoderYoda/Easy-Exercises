using System;

namespace Easy_Exercises
{

public class Exercise019
{
    static void Main()
    {
        const int July = 7;
        const int Feb = 2;

        int daysInJuly = System.DateTime.DaysInMonth(2016, July);
        Console.WriteLine(daysInJuly);

        // 2013 was not a leap year.
        int daysInFeb = System.DateTime.DaysInMonth(2013, Feb);
        Console.WriteLine(daysInFeb);

        // 2004 was a leap year.
        int daysInFebLeap = System.DateTime.DaysInMonth(2004, Feb);
        Console.WriteLine(daysInFebLeap);
    }
    }
}
