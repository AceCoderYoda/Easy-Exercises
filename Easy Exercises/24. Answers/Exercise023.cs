using System;

namespace Easy_Exercises
{

public class Exercise023
{
    public static void Main(String[] argv)
    {
        DateTime dt = DateTime.FromFileTimeUtc(12123123123123123);
        System.Console.WriteLine(dt);
    }
    }
}
