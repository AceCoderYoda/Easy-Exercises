#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise006.cs
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
    public class Exercise006
    {
        private static void Main(string[] args)
        {
            string[] dayWeek = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

            Console.Write("\nLINQ : Display the name of the days of a week : ");
            Console.Write("\n------------------------------------------------\n");


            var days = from WeekDay in dayWeek
                select WeekDay;
            foreach (var WeekDay in days) Console.WriteLine(WeekDay);
            Console.WriteLine();
        }
    }
}