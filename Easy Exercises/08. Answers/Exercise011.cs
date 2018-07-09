#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise011.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise011
    {
        public static void Main()
        {
            int i, j, rows;

            Console.Write("\n\n");
            Console.Write("Display the pattern like right angle triangle which repeat a number in a row:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", i);
                Console.Write("\n");
            }
        }
    }