#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    22. Answers.Exercise008.cs
// Created On    ::    10/07/2018 10:29
// Altered On    ::    10/07/2018 10:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public struct newStruct8
    {
        public int m, n;

        public newStruct8(int pt1, int pt2)
        {
            m = pt1;
            n = pt2;
        }
    }

    public class Exercise008
    {
        private static void Main()
        {
            Console.Write("\n\nStruct initialization without using the new operator :\n");
            Console.Write("----------------------------------------------------------\n");

            newStruct8 myPoint;

            myPoint.m = 30;
            myPoint.n = 40;


            Console.Write("\nnewStruct : ");
            Console.WriteLine("m = {0}, n = {1}", myPoint.m, myPoint.n);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}