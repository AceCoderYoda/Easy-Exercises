using System;

namespace Easy_Exercises
{

public class Exercise054
{
    static void Main()
    {
        int yr, mn, dt;
        Console.Write("\n\n Find the first day of the month against a given date :\n");
        Console.Write("-----------------------------------------------------------\n");

        Console.Write(" Input the Day : ");
        dt = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Input the Month : ");
        mn = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Input the Year : ");
        yr = Convert.ToInt32(Console.ReadLine());
        DateTime d = new DateTime(yr, mn, dt);
        Console.WriteLine(" The formatted Date is : {0}", d.ToString("dd/MM/yyyy"));
        Console.WriteLine(" The first day of the month for the above date is : {0}\n", FirstDayOfMonth(d).ToString("dd/MM/yyyy"));
    }
    public static DateTime FirstDayOfMonth(DateTime dt)
    {
        return new DateTime(dt.Year, dt.Month, 1);
    }
    }
}
