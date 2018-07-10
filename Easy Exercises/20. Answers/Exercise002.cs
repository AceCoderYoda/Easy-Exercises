#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    20. Answers.Exercise002.cs
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
    public class Exercise002
    {
        private static void Main()
        {
            int[] n1 =
            {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

            Console.Write("\nLINQ : Using multiple WHERE clause to find the positive numbers within the list : ");
            Console.Write("\n-----------------------------------------------------------------------------");

            var nQuery =
                from VrNum in n1
                where VrNum > 0
                where VrNum < 12
                select VrNum;
            Console.Write("\nThe numbers within the range of 1 to 11 are : \n");
            foreach (var VrNum in nQuery) Console.Write("{0}  ", VrNum);
            Console.Write("\n\n");
        }
    }
}