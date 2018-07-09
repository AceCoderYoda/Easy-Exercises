#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise008.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise008
    {
        public static void Main()
        {
            int i, n, sum = 0;
            Console.Write("\n\n");
            Console.Write("Display the sum of n odd natural number:\n");
            Console.Write("------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }

            Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum);
        }
    }
}