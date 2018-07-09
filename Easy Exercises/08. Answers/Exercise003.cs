#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise003.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise003
    {
        public static void Main()
        {
            int i, n, sum = 0;

            Console.Write("\n\n");
            Console.Write("Display n terms of natural number and their sum:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input Value of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }

            Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, sum);
        }
    }
}