using System;

namespace Easy_Exercises
{

public class Exercise014
{
    public static void Main()
    {
        var dat = new DateTime(2016, 8, 31);
        for (int ctr = 0; ctr <= 15; ctr++)
            Console.WriteLine(dat.AddMonths(ctr).ToString("d"));

    }
    }
}
