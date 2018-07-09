#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise015.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise015
    {
        public static void Main()
        {
            int i, f = 1, num;

            Console.Write("\n\n");
            Console.Write("Calculate the factorial of a given number:\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.Write("The Factorial of {0} is: {1}\n", num, f);
        }
    }
}