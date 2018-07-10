#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    22. Answers.Exercise001.cs
// Created On    ::    10/07/2018 10:29
// Altered On    ::    10/07/2018 10:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    internal struct w3rStruct
    {
        public int x;
        public int y;
    }

    public class Exercise001
    {
        public static void Main()
        {
            Console.Write("\n\nDeclare a simple structure :\n");
            Console.Write("--------------------------------\n");
            var w3st = new w3rStruct();
            w3st.x = 15;
            w3st.y = 25;
            var sum = w3st.x + w3st.y;
            Console.WriteLine("The sum of x and y is {0}\n", sum);
        }
    }
}