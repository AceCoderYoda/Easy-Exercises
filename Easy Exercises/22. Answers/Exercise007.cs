#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    22. Answers.Exercise007.cs
// Created On    ::    10/07/2018 10:29
// Altered On    ::    10/07/2018 10:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public struct newStruct7
    {
        public int m, n;

        public newStruct7(int pt1, int pt2)
        {
            m = pt1;
            n = pt2;
        }
    }

    public class Exercise007
    {
        private static void Main()
        {
            Console.Write("\n\nStruct declares using default and parameterized constructors :\n");
            Console.Write("-----------------------------------------------------------------\n");
            var myPoint1 = new newStruct7();
            var myPoint2 = new newStruct7(25, 25);


            Console.Write("\nnewStruct 1: ");
            Console.WriteLine("m = {0}, n = {1}", myPoint1.m, myPoint1.n);

            Console.Write("newStruct 2: ");
            Console.WriteLine("m = {0}, n = {1}", myPoint2.m, myPoint2.n);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}