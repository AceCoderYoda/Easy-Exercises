#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise029.cs
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
    public class Exercise029
    {
        private static void Main(string[] args)
        {
            string[] cities =
            {
                "ROME", "LONDON", "NAIROBI", "CALIFORNIA",
                "ZURICH", "NEW DELHI", "AMSTERDAM",
                "ABU DHABI", "PARIS", "NEW YORK"
            };

            Console.Write("\nLINQ : Split a collection of strings into some groups  : ");
            Console.Write("\n-------------------------------------------------------\n");
            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI', \n");
            Console.Write("                   'AMSTERDAM','ABU DHABI','PARIS','NEW YORK' \n");
            Console.Write("\nHere is the group of cities : \n\n");

            var citySplit = from i in Enumerable.Range(0, cities.Length)
                group cities[i] by i / 3;

            foreach (var city in citySplit)
                cityView(string.Join(";  ", city.ToArray()));


            Console.ReadLine();
        }

        private static void cityView(string cityMetro)
        {
            Console.WriteLine(cityMetro);
            Console.WriteLine("-- here is a group of cities --\n");
        }
    }
}