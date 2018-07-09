#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise037.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise037
    {
        public static void Main()
        {
            int num, r, sum = 0, t;

            Console.Write("\n\n");
            Console.Write("Display the number in reverse order:\n");
            Console.Write("--------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }

            Console.Write("The number in reverse order is : {0} \n", sum);
        }
    }
}