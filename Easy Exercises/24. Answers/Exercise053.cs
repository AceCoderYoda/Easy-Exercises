using System;

namespace Easy_Exercises
{

public class Exercise053
{
    static void Main()
    {
        int yr, mn, dt;
        Console.Write("\n\n Find the first day of a week against a given date :\n");
        Console.Write("--------------------------------------------------------\n");

        Console.Write(" Input the Day : ");
        dt = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Input the Month : ");
        mn = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Input the Year : ");
        yr = Convert.ToInt32(Console.ReadLine());
        DateTime d = new DateTime(yr, mn, dt);
        Console.WriteLine(" The formatted Date is : {0}", d.ToString("dd/MM/yyyy"));
        Console.WriteLine(" The first day of the week for the above date is : {0}\n", FirstDayOfWeek(d).ToString("dd/MM/yyyy"));
    }
    public static DateTime FirstDayOfWeek(DateTime dt)
    {
        var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
        var diff = dt.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
        if (diff < 0)
            diff += 7;
        return dt.AddDays(-diff).Date;
    }
    }
}
