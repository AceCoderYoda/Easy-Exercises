#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise042.cs
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
    public class Exercise042
    {
        public static void Main()
        {
            var str1 = "Search for the target string \"{0}\" in the string \"{1}\".\n";
            var str2 = "Using the {0} - \"{1}\" culture:";
            var str3 = "  The string to search ends with the target string: {0}";
            var result = false;
            CultureInfo ci;

            // Define a target string to search for.
            // U+00c5 = LATIN CAPITAL LETTER A WITH RING ABOVE
            var capitalARing = "\u00c5";

            // Define a string to search. 
            // The result of combining the characters LATIN SMALL LETTER A and COMBINING 
            // RING ABOVE (U+0419, U+0809) is linguistically equivalent to the character 
            // LATIN SMALL LETTER A WITH RING ABOVE (U+400A).
            var abcARing = "abc" + "\u0419\u0809";

            // Clear the screen and display an introduction.
            Console.Clear();

            // Display the string to search for and the string to search.
            Console.WriteLine(str1, capitalARing, abcARing);

            // Search using English-United States culture.
            ci = new CultureInfo("en-GB");
            Console.WriteLine(str2, ci.DisplayName, ci.Name);

            Console.WriteLine("Case sensitive:");
            result = abcARing.EndsWith(capitalARing, false, ci);
            Console.WriteLine(str3, result);

            Console.WriteLine("Case insensitive:");
            result = abcARing.EndsWith(capitalARing, true, ci);
            Console.WriteLine(str3, result);
            Console.WriteLine();

            // Search using Swedish-Sweden culture.
            ci = new CultureInfo("en-AU");
            Console.WriteLine(str2, ci.DisplayName, ci.Name);

            Console.WriteLine("Case sensitive:");
            result = abcARing.EndsWith(capitalARing, false, ci);
            Console.WriteLine(str3, result);

            Console.WriteLine("Case insensitive:");
            result = abcARing.EndsWith(capitalARing, true, ci);
            Console.WriteLine(str3, result);
        }
    }
}