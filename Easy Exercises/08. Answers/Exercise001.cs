#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    08. Answers.Exercise001.cs
// Created On    ::    09/07/2018 12:20
// Altered On    ::    09/07/2018 13:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise001
    {
        public static void Main()
        {
            int i;
            Console.Write("\n\n");
            Console.Write("Display the first 10 natural numbers:\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");

            Console.WriteLine("The first 10 natural number are:");

            for (i = 1; i <= 10; i++) Console.Write("{0} ", i);
            Console.Write("\n\n");
        }
    }
}