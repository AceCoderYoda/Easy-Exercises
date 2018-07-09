#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise046.cs
// Created On    ::    09/07/2018 08:54
// Altered On    ::    09/07/2018 08:54
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise046
    {
        public static void Main()
        {
            Console.WriteLine("\nInput an integer:");
            var x = Convert.ToInt32(Console.ReadLine());
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            Console.WriteLine(nums[0] == x || nums[nums.Length - 1] == x);
        }
    }
}