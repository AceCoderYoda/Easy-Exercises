#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise012.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise012
    {
        public static void Main()
        {
            string[] arr1;
            string temp;
            int n, i, j, l;

            Console.Write("\n\nSorts the strings of an array using bubble sort :\n");
            Console.Write("-----------------------------------------------------\n");
            Console.Write("Input number of strings :");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("Input {0} strings below :\n", n);
            for (i = 0; i < n; i++) arr1[i] = Console.ReadLine();
            l = arr1.Length;

            for (i = 0; i < l; i++)
            for (j = 0; j < l - 1; j++)
                if (arr1[j].CompareTo(arr1[j + 1]) > 0)
                {
                    temp = arr1[j];
                    arr1[j] = arr1[j + 1];
                    arr1[j + 1] = temp;
                }

            Console.Write("\n\nAfter sorting the array appears like : \n");
            for (i = 0; i < l; i++) Console.WriteLine(arr1[i] + " ");
        }
    }
}