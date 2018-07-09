#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise004.cs
// Created On    ::    09/07/2018 07:40
// Altered On    ::    09/07/2018 08:10
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise004
    {
        public static void Main()
        {
            Console.WriteLine(-1 + 4 * 6);
            //-1 + 24 = 23
            Console.WriteLine((35 + 5) % 7);
            //40 % 7 = 5 (remainder of 40/7)
            Console.WriteLine(14 + -4 * 6 / 11);
            //14 - (24/11)= 14 - 2 = 12
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //2 + (15/6) - remainder of (7/2) = 2 + 2 - 1 = 4 - 1 = 3
        }
    }
}