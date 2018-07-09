#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise021.cs
// Created On    ::    09/07/2018 08:29
// Altered On    ::    09/07/2018 08:29
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise021
    {
        private static void Main(string[] args)
        {
            int x, y;
            int result;

            Console.WriteLine("\nInput an integer:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another integer:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || x + y == 20);
        }
    }
}