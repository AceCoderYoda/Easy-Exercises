#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise022.cs
// Created On    ::    10/07/2018 10:03
// Altered On    ::    10/07/2018 10:23
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise022
    {
        private static void Main(string[] args)
        {
            string[] arr1;
            int n, i, ctr;

            Console.Write("\nLINQ : Find the strings for a specific minimum length : ");
            Console.Write("\n------------------------------------------------------\n");

            Console.Write("Input number of strings to  store in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("\nInput {0} strings for the array  :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element[{0}] : ", i);
                arr1[i] = Console.ReadLine();
            }

            Console.Write("\nInput the minimum length of the item you want to find : ");
            ctr = Convert.ToInt32(Console.ReadLine());

            IEnumerable<string> objNew = from m in arr1
                where m.Length >= ctr
                orderby m
                select m;
            Console.Write("\nThe items of minimum {0} characters are : \n", ctr);
            foreach (var z in objNew)
                Console.WriteLine("Item: {0}", z);

            Console.ReadLine();
        }
    }
}