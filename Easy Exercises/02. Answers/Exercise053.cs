#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise053.cs
// Created On    ::    09/07/2018 09:01
// Altered On    ::    09/07/2018 09:01
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise053
    {
        public static void Main()
        {
            int[] nums = {2, 4, 7, 8, 6};
            Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));
            Console.WriteLine("Check if an array contains an odd number? " + EvenOdd(nums));
        }

        public static bool EvenOdd(int[] nums)
        {
            foreach (var n in nums)
                if (n % 2 != 0)
                    return true;
            return false;
        }
    }
}