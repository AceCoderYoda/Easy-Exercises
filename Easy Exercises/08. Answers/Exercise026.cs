#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise026.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise026
    {
        public static void Main()
        {
            int n, i, sum = 0;
            var t = 1;

            Console.Write("\n\n");
            Console.Write("Calculate the sum of the series 1 +11 + 111 + 1111 + .. n terms:\n");
            Console.Write("------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the numbe of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} + ", t);
                sum = sum + t;
                t = t * 10 + 1;
            }

            Console.Write("\nThe Sum is : {0}\n", sum);
        }
    }
}