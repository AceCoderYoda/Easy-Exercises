#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise068.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise068
    {
        public static void Main()
        {
            int row, column, j = 5, i = 0;
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'K' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                    if (column == 1 || row == column + 1 && column != 0)
                    {
                        Console.Write("*");
                    }

                    else if (row == i && column == j)
                    {
                        Console.Write("*");
                        i = i + 1;
                        j = j - 1;
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                Console.Write("\n");
            }

            Console.Write("\n");
        }
    }
}