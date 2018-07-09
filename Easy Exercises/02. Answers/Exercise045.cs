#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise045.cs
// Created On    ::    09/07/2018 08:53
// Altered On    ::    09/07/2018 08:53
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise045
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\nInput an integer:");
            var x = Convert.ToInt32(Console.ReadLine());
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            Console.WriteLine("Number of " + x + " present in the said array:");
            Console.WriteLine(nums.Count(n => n == x));
        }
    }
}