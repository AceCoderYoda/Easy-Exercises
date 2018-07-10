#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise010.cs
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
    public class Exercise010
    {
        private static void Main(string[] args)
        {
            var i = 0;
            int memlist, n, m;
            var templist = new List<int>();
            Console.Write(
                "\nLINQ : Accept the members of a list and display the members more than a specific value : ");
            Console.Write(
                "\n----------------------------------------------------------------------------------------\n");

            Console.Write("Input the number of members on the List : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Member {0} : ", i);
                memlist = Convert.ToInt32(Console.ReadLine());
                templist.Add(memlist);
            }

            Console.Write("\nInput the value above you want to display the members of the List : ");
            m = Convert.ToInt32(Console.ReadLine());

            var FilterList = templist.FindAll(x => x > m ? true : false);
            Console.WriteLine("\nThe numbers greater than {0} are : ", m);
            foreach (var num in FilterList) Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}