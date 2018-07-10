using System;

namespace Easy_Exercises
{

public class Exercise022
{
    public static void Main()
    {
        DateTime date1 = new DateTime(2016, 3, 14, 2, 30, 00);
        Console.WriteLine("Invalid Time: {0}",
            TimeZoneInfo.Local.IsInvalidTime(date1));
        long ft = date1.ToFileTime();
        DateTime date2 = DateTime.FromFileTime(ft);
        Console.WriteLine("{0} -> {1}", date1, date2);
    }
    }
}
