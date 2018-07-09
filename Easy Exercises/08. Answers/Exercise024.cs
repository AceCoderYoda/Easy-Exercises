#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise024.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise024
    {
        public static void Main()
        {
            double x, sum, no_row, ctr;
            int i, n;

            Console.Write("\n\n");
            Console.Write("Calculate the sum of the series [ x - x^3 + x^5 + ......]:\n");
            Console.Write("------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the value of x :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = x;
            no_row = x;
            for (i = 1; i < n; i++)
            {
                ctr = 2 * i * (2 * i + 1);
                no_row = -no_row * x * x / ctr;
                sum = sum + no_row;
            }

            Console.Write("\nThe sum = {0}\nNumber of terms = {1}\n The value of x = {2}\n", sum, n, x);
        }
    }
}