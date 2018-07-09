#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise036.cs
// Created On    ::    09/07/2018 08:44
// Altered On    ::    09/07/2018 08:44
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise036
    {
        private static void Main(string[] args)
        {
            Console.Write("Input a first number: ");
            var m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m >= -10 && m <= 10 || n >= -10 && n <= 10);
        }
    }
}