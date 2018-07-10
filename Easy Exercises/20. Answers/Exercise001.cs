#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise001.cs
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
    public class Exercise001
    {
        private static void Main()
        {
            //  The first part is Data source.
            var n1 = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Console.Write("\nBasic structure of LINQ : ");
            Console.Write("\n---------------------------");

            // The second part is Query creation.
            // nQuery is an IEnumerable<int>
            var nQuery =
                from VrNum in n1
                where VrNum % 2 == 0
                select VrNum;

            // The third part is Query execution.

            Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
            foreach (var VrNum in nQuery) Console.Write("{0} ", VrNum);
            Console.Write("\n\n");
        }
    }
}