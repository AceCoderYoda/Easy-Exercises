#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.eXERCISE050.cs
// Created On    ::    09/07/2018 08:57
// Altered On    ::    09/07/2018 08:57
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise050
    {
        public static void Main()
        {
            int[] nums = {1, 2, 8};
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            var temp = nums[0];
            for (var i = 0; i < nums.Length - 1; i++) nums[i] = nums[i + 1];
            nums[nums.Length - 1] = temp;
            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));
        }
    }
}