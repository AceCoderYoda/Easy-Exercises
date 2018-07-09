#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise058.cs
// Created On    ::    09/07/2018 09:08
// Altered On    ::    09/07/2018 09:09
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise058
    {
        public static int consecutive_array(int[] input_Array)
        {
            Array.Sort(input_Array);
            var ctr = 0;
            for (var i = 0; i < input_Array.Length - 1; i++) ctr += input_Array[i + 1] - input_Array[i] - 1;
            return ctr;
        }

        public static void Main()
        {
            Console.WriteLine(consecutive_array(new[] {1, 3, 5, 6, 9}));
            Console.WriteLine(consecutive_array(new[] {0, 10}));
        }
    }
}