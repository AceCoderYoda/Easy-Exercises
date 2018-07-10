using System;

namespace Easy_Exercises
{

public class Exercise009
{
    public static void Main()
    {

        System.DateTime today = System.DateTime.Now;
        System.Console.WriteLine("Today = " + System.DateTime.Now);
        System.TimeSpan duration = new System.TimeSpan(40, 0, 0, 0);
        System.DateTime answer = today.Add(duration);
        System.Console.WriteLine("{0:dddd}", answer);
    }
    }
}
