#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    10. Answers.Exercise011.cs
// Created On    ::    09/07/2018 13:37
// Altered On    ::    09/07/2018 13:38
// By            ::    Arjan Crielaard

#endregion

using System;

namespace Easy_Exercises
{
    public class Exercise011
    {
        public static void Main()
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp;


            Console.Write("\n\nSort elements of array in ascending order :\n");
            Console.Write("----------------------------------------------\n");

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nElements of array in sorted ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");
        }
    }
}