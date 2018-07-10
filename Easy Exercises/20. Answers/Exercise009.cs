#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise009.cs
// Created On    ::    10/07/2018 10:03
// Altered On    ::    10/07/2018 10:23
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;

#endregion

namespace Easy_Exercises
{
    public class Exercise009
    {
        private static void Main(string[] args)
        {
            var i = 0;
            var templist = new List<int>();
            templist.Add(55);
            templist.Add(200);
            templist.Add(740);
            templist.Add(76);
            templist.Add(230);
            templist.Add(482);
            templist.Add(95);

            Console.Write("\nLINQ : Create a list of numbers and display the numbers greater than 80 : ");
            Console.Write("\n-------------------------------------------------------------------------\n");
            Console.WriteLine("\nThe members of the list are : ");
            foreach (var lstnum in templist) Console.Write(lstnum + " ");
            var FilterList = templist.FindAll(x => x > 80 ? true : false);
            Console.WriteLine("\n\nThe numbers greater than 80 are : ");
            foreach (var num in FilterList) Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}