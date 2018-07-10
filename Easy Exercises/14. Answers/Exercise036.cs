#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise036.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise036
    {
        public static void Main()
        {
            var str1 = "Don't count your chickens, ";
            var str2 = "before the eggs, ";
            var str3 = "have hatched.";

            var str = string.Concat(str1, str2, str3);
            Console.WriteLine(str);
        }
    }
}