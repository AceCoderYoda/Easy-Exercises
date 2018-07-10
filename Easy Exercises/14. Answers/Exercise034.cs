#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise034.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise034
    {
        public static void Main()
        {
            var i = -123;
            object o = i;
            var objs = {-123, -456, -789};

            Console.WriteLine("Concatenate 1, 2, and 3 objects:");
            Console.WriteLine("1) {0}", string.Concat(o));
            Console.WriteLine("2) {0}", string.Concat(o, o));
            Console.WriteLine("3) {0}", string.Concat(o, o, o));

            Console.WriteLine("\nConcatenate 4 objects and a variable length parameter list:");
            Console.WriteLine("4) {0}", string.Concat(o, o, o, o));
            Console.WriteLine("5) {0}", string.Concat(o, o, o, o, o));

            Console.WriteLine("\nConcatenate a 3-element object array:");
            Console.WriteLine("6) {0}", string.Concat(objs));
        }
    }
}