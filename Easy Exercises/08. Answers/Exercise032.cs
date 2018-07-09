#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise032.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise032
    {
        public static void Main()
        {
            int num, i, ctr = 0;

            Console.Write("\n\n");
            Console.Write("Check whether a given number is prime or not:\n");
            Console.Write("-----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input  a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }

            if (ctr == 0 && num != 1)
                Console.Write("{0} is a prime number.\n", num);
            else
                Console.Write("{0} is not a prime number\n", num);
        }
    }
}