using System;

namespace Easy_Exercises
{

public class Exercise012
{
    public static void Main()
    {
        string dateFormat = "MM/dd/yyyy hh:mm:ss.fffffff";
        DateTime date1 = new DateTime(2016, 8, 16, 16, 0, 0);
        Console.WriteLine("Original date: {0} ({1:N0} ticks)\n",
            date1.ToString(dateFormat), date1.Ticks);

        DateTime date2 = date1.AddMilliseconds(1);
        Console.WriteLine("Second date:   {0} ({1:N0} ticks)",
            date2.ToString(dateFormat), date2.Ticks);
        Console.WriteLine("Difference between dates: {0} ({1:N0} ticks)\n",
            date2 - date1, date2.Ticks - date1.Ticks);

        DateTime date3 = date1.AddMilliseconds(2.5);
        Console.WriteLine("Third date:    {0} ({1:N0} ticks)",
            date3.ToString(dateFormat), date3.Ticks);
        Console.WriteLine("Difference between dates: {0} ({1:N0} ticks)",
            date3 - date1, date3.Ticks - date1.Ticks);

    }
    }
}
