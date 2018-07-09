#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    10. Answers.Exercise002.cs
// Created On    ::    09/07/2018 13:37
// Altered On    ::    09/07/2018 13:38
// By            ::    Arjan Crielaard

#endregion

using System;

namespace Easy_Exercises
{
    public class Exercise002
    {
        public static void Main()
        {
            int i, n;
            int[] a = new int[100];

            Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
            Console.Write("------------------------------------------------------------------------\n");

            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.Write("\n\nThe values store into the array in reverse are :\n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");
        }
    }
}