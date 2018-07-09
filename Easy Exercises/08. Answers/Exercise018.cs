#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise018.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise018
    {
        public static void Main()
        {
            double x, sum, t, d;
            int i, n;

            Console.Write("\n\n");
            Console.Write("Calculate the sum of the series [ 1-X^2/2!+X^4/4!- .........]:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the Value of x :");

            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 1;
            t = 1;
            for (i = 1; i < n; i++)
            {
                d = 2 * i * (2 * i - 1);
                t = -t * x * x / d;
                sum = sum + t;
            }

            Console.Write("\nthe sum = {0}\nNumber of terms = {1}\nvalue of x = {2}\n", sum, n, x);
        }
    }
}