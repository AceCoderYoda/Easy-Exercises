#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    22. Answers.Exercise003.cs
// Created On    ::    10/07/2018 10:29
// Altered On    ::    10/07/2018 10:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    internal struct employee
    {
        public string eName;
        public dtObirth Date;
    }

    //dtObirth is a nested structure of employee
    internal struct dtObirth
    {
        public int Day;
        public int Month;
        public int Year;
    }

    public class Exercise003
    {
        private static void Main(string[] args)
        {
            int dd = 0, mm = 0, yy = 0;
            var total = 2;
            Console.Write("\n\nCreate a nested struct and store data in an array :\n");
            Console.Write("-------------------------------------------------------\n");
            var emp = new employee[total];

            for (var i = 0; i < total; i++)
            {
                Console.Write("Name of the employee : ");
                var nm = Console.ReadLine();
                emp[i].eName = nm;

                Console.Write("Input day of the birth : ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = dd;

                Console.Write("Input month of the birth : ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = mm;

                Console.Write("Input year for the birth : ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = yy;
            }
        }
    }
}