#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise018.cs
// Created On    ::    09/07/2018 08:11
// Altered On    ::    09/07/2018 08:11
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise018
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\nInput first integer:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine(x < 0 && y > 0 || x > 0 && y < 0);
        }
    }
}