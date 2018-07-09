#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise022.cs
// Created On    ::    09/07/2018 08:29
// Altered On    ::    09/07/2018 08:30
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise022
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\nInput an integer:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(x));
        }

        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10)
                return true;
            return false;
        }
    }
}