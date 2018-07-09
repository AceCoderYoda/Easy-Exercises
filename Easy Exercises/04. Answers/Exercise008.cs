#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    04. Answers.Exercise008.cs
// Created On    ::    09/07/2018 09:37
// Altered On    ::    09/07/2018 09:37
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise008
    {
        public static void Main()
        {
            float r;
            var pi = 3.1415926535f;

            Console.Write("Radius: ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(4 * pi * (r * r));

            Console.WriteLine(4f / 3f * pi * (r * r * r));
        }
    }
}