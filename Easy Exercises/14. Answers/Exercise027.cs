#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise027.cs
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
    public class Exercise027
    {
        public static void Main()
        {
            var str1 = "change";
            var str2 = "dollar";
            string relation = null;

            relation = symbol(string.Compare(str1, str2, false, new CultureInfo("en-US")));
            Console.WriteLine("\nFor en-US: {0} {1} {2}", str1, relation, str2);

            relation = symbol(string.Compare(str1, str2, false, new CultureInfo("cs-CZ")));
            Console.WriteLine("For cs-CZ: {0} {1} {2}\n", str1, relation, str2);
        }

        private static string symbol(int r)
        {
            var s = "=";
            if (r < 0) s = "<";
            else if (r > 0) s = ">";
            return s;
        }
    }
}