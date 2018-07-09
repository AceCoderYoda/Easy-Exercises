#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    10. Answers.Exercise004.cs
// Created On    ::    09/07/2018 13:37
// Altered On    ::    09/07/2018 13:38
// By            ::    Arjan Crielaard

#endregion

using System;

namespace Easy_Exercises
{
    public class Exercise004
    {
        public static void Main()
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;


            Console.Write("\n\nCopy the elements one array into another array :\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* Copy elements of first array into second array.*/
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

            /* Prints the elements of first array   */
            Console.Write("\nThe elements stored in the first array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            /* Prints the elements copied into the second array. */
            Console.Write("\n\nThe elements copied into the second array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.Write("\n\n");
        }
    }
}