#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise036.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise036
    {
        public static void Main()
        {
            int i, j, n;

            Console.Write("\n\n");
            Console.Write(" Display the pattern in which first and last number of each row will be 1:\n");
            Console.Write("----------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                /* print blank spaces */
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                /* Display number in ascending order upto middle*/
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);

                /* Display  number in reverse order after middle */
                for (j = i - 1; j >= 1; j--)
                    Console.Write("{0}", j);

                Console.Write("\n");
            }
        }
    }
}