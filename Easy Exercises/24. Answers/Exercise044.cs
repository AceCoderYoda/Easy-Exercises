using System;

namespace Easy_Exercises
{

public class Exercise044
{
    static void Main()
    {
        Console.Write("\n\n Compute what day was  Yesterday :\n");
        Console.Write("--------------------------------------\n");
        Console.WriteLine(" Today is : {0}", DateTime.Today.ToString("dd/MM/yyyy"));
        DateTime yd = GetYesterday();
        Console.WriteLine(" The Yesterday was : {0} \n", yd.ToString("dd/MM/yyyy"));
    }
    static DateTime GetYesterday()
    {
        return DateTime.Today.AddDays(-1);
    }
    }
}
