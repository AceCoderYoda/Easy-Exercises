#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise031.cs
// Created On    ::    09/07/2018 08:39
// Altered On    ::    09/07/2018 08:39
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise031
    {
        public static void Main()
        {
            int[] firstArray = {1, 3, -5, 4};
            int[] secondArray = {1, 4, -5, -2};

            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", firstArray));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", secondArray));

            Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

            for (var i = 0; i < firstArray.Length; i++) Console.Write(firstArray[i] * secondArray[i] + " ");
            Console.WriteLine("\n");
        }
    }
}