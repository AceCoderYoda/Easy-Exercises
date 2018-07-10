#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise024.cs
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
    public class Exercise024
    {
        public static void Main(string[] args)
        {
            char[] charset1 = {'X', 'Y', 'Z'};
            int[] numset1 = {1, 2, 3};
            string[] colorset1 = {"Green", "Orange"};

            Console.Write("\nLINQ : Generate a Cartesian Product of three sets : ");
            Console.Write("\n----------------------------------------------------\n");

            var cartesianProduct = from letter in charset1
                from number in numset1
                from colour in colorset1
                select new {letter, number, colour};

            Console.Write("The Cartesian Product are : \n");
            foreach (var ProductList in cartesianProduct) Console.WriteLine(ProductList);
            Console.ReadLine();
        }
    }

    public class Exercise024Other
    {
        public static void Main(string[] args)
        {
            char[] set1 = {'X', 'Y', 'Z'};
            int[] set2 = {1, 2, 3};
            string[] set3 = {"Green", "Pink"};

            Console.Write("\nLINQ : Generate a Cartesian Product of three sets: ");
            Console.Write("\n---------------------------------------------------\n");

            var set12CartesianProduct = set1.SelectMany(
                letterList => set2.Select(numList =>
                    new {letterList, numList}));

            var cartesianProduct = set12CartesianProduct.SelectMany(
                set1and2 => set3.Select(colorList =>
                    new {set1and2.letterList, set1and2.numList, colorList}));

            Console.Write("The Cartesian Product are : \n");
            foreach (var ProductList in cartesianProduct) Console.WriteLine(ProductList);
            Console.ReadLine();
        }
    }
}