#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise047.cs
// Created On    ::    09/07/2018 08:55
// Altered On    ::    09/07/2018 08:55
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise047
    {
        public static void Main()
        {
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            var sum = 0;
            for (var i = 0; i < nums.Length; i++) sum += nums[i];
            Console.WriteLine("Sum: " + sum);
        }
    }
}