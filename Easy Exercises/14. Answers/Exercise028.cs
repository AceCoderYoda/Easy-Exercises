#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise028.cs
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
    public class Exercise028
    {
        public static void Main()
        {
            var str1 = "sister";
            var str2 = "Sister";
            string relation;
            int result;

            // Cultural (linguistic) comparison.
            result = string.Compare(str1, str2, new CultureInfo("en-US"),
                CompareOptions.None);
            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";

            Console.WriteLine("'{0}' {1} '{2}'.",
                str1, relation, str2);

            // Cultural (linguistic) case-insensitive comparison.
            result = string.Compare(str1, str2, new CultureInfo("en-US"),
                CompareOptions.IgnoreCase);
            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";

            Console.WriteLine("'{0}' {1} '{2}'.",
                str1, relation, str2);

            // Culture-insensitive ordinal comparison.
            result = string.CompareOrdinal(str1, str2);
            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";

            Console.WriteLine("'{0}' {1} '{2}'.",
                str1, relation, str2);
        }
    }
}