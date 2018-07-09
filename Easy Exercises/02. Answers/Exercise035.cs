#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise035.cs
// Created On    ::    09/07/2018 08:43
// Altered On    ::    09/07/2018 08:43
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise035
    {
        private static void Main(string[] args)
        {
            Console.Write("Input a first number(<100): ");
            var m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number(>200): ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m < 100 && n > 200);
        }
    }
}