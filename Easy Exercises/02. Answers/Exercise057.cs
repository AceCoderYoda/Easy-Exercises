#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise057.cs
// Created On    ::    09/07/2018 09:08
// Altered On    ::    09/07/2018 09:08
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise057
    {
        public static int adjacent_Elements_Product(int[] input_Array)
        {
            var max = 0;
            for (var i = 1; i < input_Array.Length;) max = Math.Max(max, input_Array[i - 1] * input_Array[i++]);
            return max;
        }

        public static void Main()
        {
            Console.WriteLine(adjacent_Elements_Product(new[] {1, 3, 4, 5, 2}));
            Console.WriteLine(adjacent_Elements_Product(new[] {1, 3, -4, 5, 2}));
            Console.WriteLine(adjacent_Elements_Product(new[] {1, 0, -4, 0, 2}));
        }
    }
}