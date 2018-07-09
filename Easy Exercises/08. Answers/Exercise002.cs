#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise002.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise002
    {
        public static void Main()
        {
            int j, sum = 0;

            Console.Write("\n\n");
            Console.Write("Find the sum of first 10 natural numbers:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("The first 10 natural number are :\n");
            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write("{0} ", j);
            }

            Console.Write("\nThe Sum is : {0}\n", sum);
        }
    }
}