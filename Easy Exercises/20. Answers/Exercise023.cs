#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise023.cs
// Created On    ::    10/07/2018 10:03
// Altered On    ::    10/07/2018 10:23
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Linq;

#endregion

namespace Easy_Exercises
{
    public class Exercise023
    {
        public static void Main(string[] args)
        {
            char[] charset1 = {'X', 'Y', 'Z'};
            int[] numset1 = {1, 2, 3, 4};

            Console.Write("\nLINQ : Generate a Cartesian Product of two sets : ");
            Console.Write("\n------------------------------------------------\n");

            var cartesianProduct = from letterList in charset1
                from numberList in numset1
                select new {letterList, numberList};

            Console.Write("The Cartesian Product are : \n");
            foreach (var productItem in cartesianProduct) Console.WriteLine(productItem);
            Console.ReadLine();
        }
    }

    public class Exercise023Other
    {
        public static void Main(string[] args)
        {
            var set1 = new[] {"X", "Y", "Z"};
            var set2 = new[] {1, 2, 3};

            Console.Write("\nLINQ : Generate a Cartesian Product of two sets : ");
            Console.Write("\n------------------------------------------------\n");

            var cartesianProduct =
                set1.SelectMany(p => set2.Select(q => p + q + ' '));


            Console.Write("The Cartesian Product are : \n");
            foreach (var ProductList in cartesianProduct) Console.Write(ProductList);
            Console.ReadLine();
        }
    }
}