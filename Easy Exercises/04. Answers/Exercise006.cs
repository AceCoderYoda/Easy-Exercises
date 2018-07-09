#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    04. Answers.Exercise006.cs
// Created On    ::    09/07/2018 09:35
// Altered On    ::    09/07/2018 09:35
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise006
    {
        public static void Main()
        {
            int x, y;

            Console.WriteLine("x = y² - 2y +1");
            Console.WriteLine();

            for (y = -5; y <= 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine(
                    "y = {0} ; x=({0})² - 2*({0}) +1 = {1}",
                    y, x);
            }
        }
    }
}