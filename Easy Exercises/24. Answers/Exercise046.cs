using System;

namespace Easy_Exercises
{

public class Exercise046
{
    static void Main()
    {
        int dt, mn, yr;
        Console.Write("\n\n Find  the first day of a year against a date :\n");
        Console.Write("---------------------------------------------------\n");
        Console.WriteLine(" The First day of the current year is : {0} \n", FirstDayOfYear().ToString("dd/MM/yyyy"));
        Console.Write(" Input the Day : ");
        dt = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Input the Month : ");
        mn = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Input the Year : ");
        yr = Convert.ToInt32(Console.ReadLine());
        DateTime d = new DateTime(yr, mn, dt);
        Console.WriteLine(" The formatted Date is : {0}", d.ToString("dd/MM/yyyy"));
        DateTime nd = FirstDayOfYear(d);
        Console.WriteLine(" The First day of the year {0} is : {1}\n", yr, nd.ToString("dd/MM/yyyy"));
    }
    static DateTime FirstDayOfYear()
    {
        return FirstDayOfYear(DateTime.Today);
    }
    static DateTime FirstDayOfYear(DateTime y)
    {
        return new DateTime(y.Year, 1, 1);
    }
    }
}
