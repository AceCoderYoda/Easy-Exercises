using System;

namespace Easy_Exercises
{

public class Exercise043
{
    static void Main()
    {
        int yr, mn, dt;

        Console.Write("\n\n Check whether the given year, month and day is the current or not :\n");
        Console.Write("------------------------------------------------------------------------\n");

        Console.Write(" Input the Day : ");
        dt = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Input the Month : ");
        mn = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Input the Year : ");
        yr = Convert.ToInt32(Console.ReadLine());
        DateTime value = new DateTime(yr, mn, dt);
        Console.WriteLine(" The formatted Date is : {0}", value.ToString("dd/MM/yyyy"));
        Console.WriteLine(" The current date status : {0}\n", value == DateTime.Today);
    }
    }
}
