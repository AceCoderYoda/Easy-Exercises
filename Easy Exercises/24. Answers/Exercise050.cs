using System;

namespace Easy_Exercises
{

public class Exercise050
{
    static void Main()
    {
        Console.Write("\n\n Display the name of the first three letters of month of a year :\n");
        Console.Write("---------------------------------------------------------------------\n");
        DateTime now = DateTime.Now;
        Console.WriteLine(" The date of Today : {0}", now.ToString("dd/MM/yyyy"));
        Console.WriteLine(" The twelve months are :");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine(" {0}", now.ToString("MMM"));
            now = now.AddMonths(1);
        }
        Console.WriteLine();
    }
    }
}
