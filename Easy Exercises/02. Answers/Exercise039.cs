#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise039.cs
// Created On    ::    09/07/2018 08:47
// Altered On    ::    09/07/2018 08:47
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise039
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\nInput first integer:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third integer:");
            var z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));
        }
    }
}