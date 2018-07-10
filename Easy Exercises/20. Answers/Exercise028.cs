#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise028.cs
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
    public class Exercise028
    {
        private static void Main(string[] args)
        {
            string[] cities =
            {
                "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"
            };

            Console.Write("\nLINQ : Display the list according to the length then by name in ascending order : ");
            Console.Write("\n--------------------------------------------------------------------------------\n");
            Console.Write(
                "\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");
            Console.Write("\nHere is the arranged list :\n");
            IEnumerable<string> cityOrder =
                cities.OrderBy(str => str.Length)
                    .ThenBy(str => str);
            foreach (var city in cityOrder)
                Console.WriteLine(city);
            Console.ReadLine();
        }
    }
}