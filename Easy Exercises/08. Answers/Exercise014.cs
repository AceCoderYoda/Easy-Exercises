#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise014.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise014
    {
        public static void Main()
        {
            int i, j, spc, rows, k;

            Console.Write("\n\n");
            Console.Write("Display the pattern like pyramid with asterisk:\n");
            Console.Write("-------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--) Console.Write(" ");

                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                spc--;
            }
        }
    }
}