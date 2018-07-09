#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise029.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise029
    {
        public static void Main()
        {
            int num, r, sum = 0, temp;


            Console.Write("\n\n");
            Console.Write("Check whether a given number is armstrong number or not:\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input  a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (temp = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum + r * r * r;
            }

            if (sum == temp)
                Console.Write("{0} is an Armstrong number.\n", temp);
            else
                Console.Write("{0} is not an Armstrong number.\n", temp);
        }
    }
}