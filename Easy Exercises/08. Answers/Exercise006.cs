#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise006.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise006
    {
        public static void Main()
        {
            int j, n;

            Console.Write("\n\n");
            Console.Write("Display the multiplication table:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number (Table to be calculated) : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++) Console.Write("{0} X {1} = {2} \n", n, j, n * j);
        }
    }
}