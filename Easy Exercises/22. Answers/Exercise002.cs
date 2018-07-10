#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    22. Answers.Exercise002.cs
// Created On    ::    10/07/2018 10:29
// Altered On    ::    10/07/2018 10:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise002
    {
        public static void Main()
        {
            Console.Write("\n\nStructure with the use of static fields inside a struct :\n");
            Console.Write("-------------------------------------------------------------\n");
            var sum = w3rStruct.x + w3rStruct.y;
            Console.WriteLine("The sum of x and y is {0}\n", sum);
        }

        private struct w3rStruct
        {
            public static readonly int x = 15;
            public static readonly int y = 25;
        }
    }
}