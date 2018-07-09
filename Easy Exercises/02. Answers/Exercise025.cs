#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    02. Answers.Exercise025.cs
// Created On    ::    09/07/2018 08:32
// Altered On    ::    09/07/2018 08:32
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise025
    {
        public static void Main()
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            for (var n = 1; n < 99 + 1; n++)
                if (n % 2 != 0)
                    Console.WriteLine(n.ToString());
        }
    }
}