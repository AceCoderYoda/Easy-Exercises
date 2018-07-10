using System;

namespace Easy_Exercises
{

public class Exercise013
{
    public static void Main()
    {
        string dateFormat = "MM/dd/yyyy hh:mm:ss";
        DateTime date1 = new DateTime(2016, 8, 15, 16, 0, 0);
        Console.WriteLine("Original date: {0} ({1:N0} ticks)\n",
            date1.ToString(dateFormat), date1.Ticks);

        DateTime date2 = date1.AddSeconds(30);
        Console.WriteLine("Second date:   {0} ({1:N0} ticks)",
            date2.ToString(dateFormat), date2.Ticks);
        Console.WriteLine("Difference between dates: {0} ({1:N0} ticks)\n",
            date2 - date1, date2.Ticks - date1.Ticks);

        // Add 1 day's worth of seconds (60 secs. * 60 mins * 24 hrs.
        DateTime date3 = date1.AddSeconds(60 * 60 * 24);
        Console.WriteLine("Third date:    {0} ({1:N0} ticks)",
            date3.ToString(dateFormat), date3.Ticks);
        Console.WriteLine("Difference between dates: {0} ({1:N0} ticks)",
            date3 - date1, date3.Ticks - date1.Ticks);
    }
    }
}
