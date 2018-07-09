#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise038.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise038
    {
        public static void Main()
        {
            int num, r, sum = 0, t;


            Console.Write("\n\n");
            Console.Write("Check whether a number is a palindrome or not:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }

            if (t == sum)
                Console.Write("{0} is a palindrome number.\n", t);
            else
                Console.Write("{0} is not a palindrome number.\n", t);
        }
    }
}