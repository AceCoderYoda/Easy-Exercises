#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise024.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Globalization;

#endregion

namespace Easy_Exercises
{
    public class Exercise024
    {
        public static void Main()
        {
            var name1 = "John Peterson";
            var name2 = "Michel Jhonson";

            // Get position of space character.
            var index1 = name1.IndexOf(" ");
            index1 = index1 < 0 ? 0 : index1--;

            var index2 = name2.IndexOf(" ");
            index1 = index1 < 0 ? 0 : index1--;

            var length = Math.Max(name1.Length, name2.Length);

            Console.WriteLine("Sorted alphabetically by last name:");
            if (string.Compare(name1, index1, name2, index2, length,
                    new CultureInfo("en-US"), CompareOptions.IgnoreCase) < 0)
                Console.WriteLine("{0}\n{1}", name1, name2);
            else
                Console.WriteLine("{0}\n{1}", name2, name1);
        }
    }
}