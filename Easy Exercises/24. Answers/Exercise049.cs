using System;

namespace Easy_Exercises
{

public class Exercise049
{
    static void Main()
    {
        Console.Write("\n\n Display the month no. and name for the current date :\n");
        Console.Write("---------------------------------------------------------\n");
        DateTime now = DateTime.Now;
        Console.WriteLine(" The current Month No. is : {0} ", now.Month);
        Console.WriteLine(" The current Month is : {0}\n", now.ToString("MMMM"));
    }
    }
}
