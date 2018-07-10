#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise029.cs
// Created On    ::    10/07/2018 06:46
// Altered On    ::    10/07/2018 07:12
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Threading;

#endregion

namespace Easy_Exercises
{
    public class Exercise029
    {
        public static void Main()
        {
            var intro = "Compare three versions of the letter I using different " +
                        "values of StringComparison.";

            // Define an array of strings where each element contains a version of the 
            // letter I. (An array of strings is used so you can easily modify this 
            // code example to test additional or different combinations of strings.)  

            var threeIs = new string[3];
            // LATIN SMALL LETTER I (U+0069)
            threeIs[0] = "\u0069";
            // LATIN SMALL LETTER DOTLESS I (U+0131)
            threeIs[1] = "\u0131";
            // LATIN CAPITAL LETTER I (U+0049)
            threeIs[2] = "\u0049";

            string[] unicodeNames =
            {
                "LATIN SMALL LETTER I (U+0069)",
                "LATIN SMALL LETTER DOTLESS I (U+0131)",
                "LATIN CAPITAL LETTER I (U+0049)"
            };

            StringComparison[] scValues =
            {
                StringComparison.CurrentCulture,
                StringComparison.CurrentCultureIgnoreCase,
                StringComparison.InvariantCulture,
                StringComparison.InvariantCultureIgnoreCase,
                StringComparison.Ordinal,
                StringComparison.OrdinalIgnoreCase
            };

            //
            Console.Clear();
            Console.WriteLine(intro);

            // Display the current culture because the culture-specific comparisons
            // can produce different results with different cultures.
            Console.WriteLine("The current culture is {0}.\n",
                Thread.CurrentThread.CurrentCulture.Name);

            // Determine the relative sort order of three versions of the letter I. 
            foreach (var sc in scValues)
            {
                Console.WriteLine("StringComparison.{0}:", sc);

                // LATIN SMALL LETTER I (U+0069) : LATIN SMALL LETTER DOTLESS I (U+0131)
                Test(0, 1, sc, threeIs, unicodeNames);

                // LATIN SMALL LETTER I (U+0069) : LATIN CAPITAL LETTER I (U+0049)
                Test(0, 2, sc, threeIs, unicodeNames);

                // LATIN SMALL LETTER DOTLESS I (U+0131) : LATIN CAPITAL LETTER I (U+0049)
                Test(1, 2, sc, threeIs, unicodeNames);

                Console.WriteLine();
            }
        }

        protected static void Test(int x, int y,
            StringComparison comparison,
            string[] testI, string[] testNames)
        {
            var resultFmt = "{0} is {1} {2}";
            var result = "equal to";
            var cmpValue = 0;
            //
            cmpValue = string.Compare(testI[x], testI[y], comparison);
            if (cmpValue < 0)
                result = "less than";
            else if (cmpValue > 0)
                result = "greater than";
            Console.WriteLine(resultFmt, testNames[x], result, testNames[y]);
        }
    }
}