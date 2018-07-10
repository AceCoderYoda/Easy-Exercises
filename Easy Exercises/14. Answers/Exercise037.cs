#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise037.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise037
    {
        public static void Main()
        {
            // Make an array of strings. Note that we have included spaces.
            string[] str =
            {
                "hello ", "welcome ", "to ", "C# Sharp ",
                "create ", "Windows ", "client ", "applications "
            };

            // Put all the strings together.
            Console.WriteLine(string.Concat(str));

            // Sort the strings, and put them together.
            Array.Sort(str);
            Console.WriteLine(string.Concat(str));
        }
    }
}