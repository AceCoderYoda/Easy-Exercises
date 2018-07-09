#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise051.cs
// Created On    ::    09/07/2018 08:58
// Altered On    ::    09/07/2018 08:58
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise051
    {
        public static void Main()
        {
            int[] nums = {1, 2, 5, 7, 8};
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            var hVal = nums[0];
            foreach (var t in nums)
                if (t > nums[0])
                    hVal = t;

            Console.WriteLine("\nHighest value between first and last values of the said array: {0}", hVal);
        }
    }
}