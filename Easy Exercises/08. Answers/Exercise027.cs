#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise027.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise027
    {
        public static void Main()
        {
            int n, i, sum;

            Console.Write("\n\n");
            Console.Write("Check whether a given number is perfect number or not:\n");
            Console.Write("--------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("The positive divisor  : ");
            for (i = 1; i < n; i++)
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }

            Console.Write("\nThe sum of the divisor is : {0}", sum);
            if (sum == n)
                Console.Write("\nSo, the number is perfect.");
            else
                Console.Write("\nSo, the number is not perfect.");
            Console.Write("\n");
        }
    }
}