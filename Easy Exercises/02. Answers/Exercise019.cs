#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise019.cs
// Created On    ::    09/07/2018 08:26
// Altered On    ::    09/07/2018 08:26
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise019
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(SumTriple(2, 2));
            Console.WriteLine(SumTriple(12, 10));
            Console.WriteLine(SumTriple(-5, 2));
        }

        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
    }
}