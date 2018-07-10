using System;

namespace Easy_Exercises
{

public class Exercise057
{
    static void Main()
    {
        int yr, mn, dt;

        Console.Write("\n\n Find the day for a given date :\n");
        Console.Write("------------------------------------\n");

        Console.Write(" Input the Day : ");
        dt = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Input the Month : ");
        mn = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Input the Year : ");
        yr = Convert.ToInt32(Console.ReadLine());
        DateTime d = new DateTime(yr, mn, dt);
        Console.WriteLine(" The formatted Date is : {0}", d.ToString("dd/MM/yyyy"));
        DateTime pp;
        pp = DayOfWeek(d);
        Console.WriteLine(" The day for the date is : {0}\n ", pp.DayOfWeek);
    }
    public static DateTime DayOfWeek(DateTime dt)
    {
        DateTime ss = new DateTime(dt.Year, dt.Month, dt.Day);
        return ss;
    }
}
}
