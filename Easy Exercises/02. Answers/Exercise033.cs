#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise033.cs
// Created On    ::    09/07/2018 08:41
// Altered On    ::    09/07/2018 08:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise033
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\nInput first integer:");
            var x = Convert.ToInt32(Console.ReadLine());
            if (x > 0) Console.WriteLine(x % 3 == 0 || x % 7 == 0);
        }
    }
}