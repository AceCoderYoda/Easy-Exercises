#region ...   [Header]   ...

// Solution      ::    Easy Exercises
// Filename      ::    14. Answers.Exercise043.cs
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
    public class Exercise043
    {
        public static void Main()
        {
            var str = "Determine whether a string ends with another string, " +
                      "using\n  different values of StringComparison.";

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
            Console.WriteLine(str);

            // Display the current culture because the culture-specific comparisons
            // can produce different results with different cultures.
            Console.WriteLine("The current culture is {0}.\n",
                Thread.CurrentThread.CurrentCulture.Name);

            // Determine whether three versions of the letter I are equal to each other. 
            foreach (var sc in scValues)
            {
                Console.WriteLine("StringComparison.{0}:", sc);
                Test("xyzPQR", "PQR", sc);
                Test("xyzPQR", "PQR", sc);
                Console.WriteLine();
            }
        }

        protected static void Test(string x, string y, StringComparison comparison)
        {
            var resultFmt = "\"{0}\" {1} with \"{2}\".";
            var result = "does not end";
            //
            if (x.EndsWith(y, comparison))
                result = "ends";
            Console.WriteLine(resultFmt, x, result, y);
        }
    }
}