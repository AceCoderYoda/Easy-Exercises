#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise033.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Easy_Exercises
{
    public class Exercise033
    {
        public static void Main()
        {
            var str1 = "Goodbye";
            var str2 = "Hello";
            var str3 = "a small string";
            var str4 = "goodbye";

            // Compare a string to itself.
            Console.WriteLine(CompareStrings(str1, str1));

            Console.WriteLine(CompareStrings(str1, str2));
            Console.WriteLine(CompareStrings(str1, str3));

            // Compare a string to another string that varies only by case.
            Console.WriteLine(CompareStrings(str1, str4));
            Console.WriteLine(CompareStrings(str4, str1));
        }

        private static string CompareStrings(string str1, string str2)
        {
            // Compare the values, using the CompareTo method on the first string.
            var cmpVal = str1.CompareTo(str2);

            if (cmpVal == 0) // The strings are the same.
                return "The strings occur in the same position in the sort order.";
            if (cmpVal > 0)
                return "The first string precedes the second in the sort order.";
            return "The first string follows the second in the sort order.";
        }
    }
}