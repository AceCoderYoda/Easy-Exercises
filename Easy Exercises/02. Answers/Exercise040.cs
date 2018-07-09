#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise040.cs
// Created On    ::    09/07/2018 08:48
// Altered On    ::    09/07/2018 08:48
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise040
    {
        public static void Main()
        {
            Console.WriteLine("\nInput first integer:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            var y = Convert.ToInt32(Console.ReadLine());
            var n = 20;
            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);
            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
        }
    }
}