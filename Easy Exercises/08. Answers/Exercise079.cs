#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise079.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise079
    {
        public static void Main()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'V' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                    if ((column == 1 || column == 5) && row < 5 || row == 6 && column == 3 ||
                        row == 5 && (column == 2 || column == 4))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                Console.Write("\n");
            }

            Console.Write("\n");
        }
    }
}