#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise052.cs
// Created On    ::    09/07/2018 08:59
// Altered On    ::    09/07/2018 09:00
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise052
    {
        public static void Main()
        {
            int[] array1 = {1, 2, 5};
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
            int[] array2 = {0, 3, 8};
            Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array2));
            int[] array3 = {-1, 0, 2};
            Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array3));
            int[] new_array = {array1[1], array2[1], array3[1]};
            Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array));
        }
    }
}