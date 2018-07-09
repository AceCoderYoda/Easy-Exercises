#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    10. Answers.Exercise003.cs
// Created On    ::    09/07/2018 13:37
// Altered On    ::    09/07/2018 13:38
// By            ::    Arjan Crielaard

#endregion

using System;

namespace Easy_Exercises
{
    public class Exercise003
    {
        public static void Main()
        {
            int[] a = new int[100];
            int i, n, sum = 0;


            Console.Write("\n\nFind sum of all elements of array:\n");
            Console.Write("--------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
        }
    }
}