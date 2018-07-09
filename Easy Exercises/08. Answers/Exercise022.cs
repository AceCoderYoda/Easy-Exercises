#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise022.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise022
    {
        public static void Main()
        {
            int i, j, n, p, q;

            Console.Write("\n\n");
            Console.Write("Print the Floyd's Triangle:\n");
            Console.Write("-----------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    p = 1;
                    q = 0;
                }
                else
                {
                    p = 0;
                    q = 1;
                }

                for (j = 1; j <= i; j++)
                    if (j % 2 == 0)
                        Console.Write("{0}", p);
                    else
                        Console.Write("{0}", q);
                Console.Write("\n");
            }
        }
    }
}