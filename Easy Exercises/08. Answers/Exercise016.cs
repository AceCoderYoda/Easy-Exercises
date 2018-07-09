#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise016.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise016
    {
        public static void Main()
        {
            int i, n, sum = 0;

            Console.Write("\n\n");
            Console.Write("Calculate n terms of even natural number and their sum:\n");
            Console.Write("---------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe even numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i);
                sum += 2 * i;
            }

            Console.Write("\nThe Sum of even Natural Number upto {0} terms : {1} \n", n, sum);
        }
    }
}