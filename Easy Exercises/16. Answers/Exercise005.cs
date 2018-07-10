#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    16. Answers.Exercise005.cs
// Created On    ::    10/07/2018 09:34
// Altered On    ::    10/07/2018 09:42
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise005
    {
        public static int Sum(int[] arr1)
        {
            var tot = 0;
            for (var i = 0; i < arr1.Length; i++)
                tot += arr1[i];
            return tot;
        }

        public static void Main()
        {
            var arr1 = new int[5];
            Console.Write("\n\nFunction : Calculate the sum of the elements in an array :\n");
            Console.Write("--------------------------------------------------------------\n");

            Console.Write("Input 5 elements in the array :\n");
            for (var j = 0; j < 5; j++)
            {
                Console.Write("element - {0} : ", j);
                arr1[j] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The sum of the elements of the array is {0}", Sum(arr1));
        }
    }
}