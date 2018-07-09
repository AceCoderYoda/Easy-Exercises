#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise023.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise023
    {
        public static void Main()
        {
            double x, sum, no_row;
            int i, n;

            Console.Write("\n\n");
            Console.Write("Calculate the sum of the series [ 1+x+x^2/2!+x^3/3!+....]:\n");
            Console.Write("------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the value of x :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 1;
            no_row = 1;
            for (i = 1; i < n; i++)
            {
                no_row = no_row * x / i;
                sum = sum + no_row;
            }

            Console.Write("\nThe sum  is : {0}\nNumber of terms = {1}\nThe value of x = {2}\n", sum, n, x);
        }
    }
}