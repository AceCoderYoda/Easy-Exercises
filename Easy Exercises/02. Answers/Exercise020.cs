#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise020.cs
// Created On    ::    09/07/2018 08:28
// Altered On    ::    09/07/2018 08:28
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise020
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(result(13, 40));
            Console.WriteLine(result(50, 21));
            Console.WriteLine(result(0, 23));
        }

        public static int result(int a, int b)
        {
            if (a > b) return (a - b) * 2;
            return b - a;
        }
    }
}