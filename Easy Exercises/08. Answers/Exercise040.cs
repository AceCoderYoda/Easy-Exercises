#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise040.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise040
    {
        public static void Main()
        {
            int i, j;
            var alph = 'A';
            int n;
            var ctr = 1;

            Console.Write("\n\n");
            Console.Write("Display the pattern like pyramid using the alphabet:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number of Letters (less than 26) in the Pyramid : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 0; j <= ctr / 2; j++) Console.Write("{0} ", alph++);
                alph--;
                alph--;

                for (j = 0; j < ctr / 2; j++) Console.Write("{0} ", alph--);
                ctr = ctr + 2;
                alph = 'A';
                Console.Write("\n");
            }
        }
    }
}